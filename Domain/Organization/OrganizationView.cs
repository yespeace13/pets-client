using ModelLibrary.Model.Organization;
using ModelLibrary.View;
using PetsClient.Authentication;
using PetsClient.Etc;
using PetsClient.Services;

namespace PetsClient.Organization.View
{
    public partial class OrganizationView : Form
    {
        private string _columnName;
        private SortSettings _sortSettings;
        private PageSettingsView _page;
        private FilterSetting _filterSetting;
        private APIServiceConnection<OrganizationViewList, OrganizationEdit, OrganizationEdit> service;

        public OrganizationView()
        {
            service = new APIServiceConnection<OrganizationViewList, OrganizationEdit, OrganizationEdit>();
            InitializeComponent();
            InitializeForm();
            InitializeFiltrsDictionary();
            ShowOrganizations();
        }

        private void InitializeForm()
        {
            CreateButton.Enabled = false;
            ChangeToolStripMenuItem.Enabled = false;
            DeleteToolStripMenuItem.Enabled = false;

            foreach (var possibility in UserData.PossibilitiesForEntity("Organization"))
            {
                switch (possibility)
                {
                    case "Insert":
                        CreateButton.Enabled = true;
                        break;
                    case "Update":
                        ChangeToolStripMenuItem.Enabled = true;
                        break;
                    case "Delete":
                        DeleteToolStripMenuItem.Enabled = true;
                        break;
                }
            }
        }

        private void ForwardToPage_Click(object sender, EventArgs e)
        {
            ShowOrganizations();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            if (NumberOfPage.Maximum > NumberOfPage.Value)
            {
                NumberOfPage.Value++;
                ShowOrganizations();
            }
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            if (NumberOfPage.Minimum < NumberOfPage.Value)
            {
                NumberOfPage.Value--;
                ShowOrganizations();
            }
        }

        public void ShowOrganizations()
        {
            (string Column, int Value) sortCol = OrgDataGrid.SortedColumn == null ?
                ("Id", 0) : (OrgDataGrid.SortedColumn.Name, OrgDataGrid.SortOrder == SortOrder.Descending ? 0 : 1);
            _page = new PageSettingsView();
            _sortSettings = new SortSettings(sortCol.Column, sortCol.Value);

            _page.Sort = _sortSettings;
            _page.Filter = _filterSetting;
            _page.Pages = (int)PagesSize.Value;
            _page.Page = (int)NumberOfPage.Value;
            var page = service.Get("organizations", _page);
            if(page != null)
            {
                OrgDataGrid.DataSource = page.Items;
                NumberOfPage.Maximum = page.Pages;
            }
            
        }

        private void CreateOrgButton_Click(object sender, EventArgs e)
        {
            var result = new OrganizationEditView();
            if (result.ShowDialog() == DialogResult.OK)
                service.Post("organizations", result.OrganizationEdit);

            ShowOrganizations();
        }

        private void PagesSize_ValueChanged(object sender, EventArgs e) => ShowOrganizations();

        private void AcceptButton_Click(object sender, EventArgs e) => ShowOrganizations();

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var byteArray = service.GetFile("organizationexport", _filterSetting);
            File.WriteAllBytes("Организации.xlsx", byteArray);
        }

        private void OrgDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ShowOrganizations();
        }

        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = OrgDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            var selectedItem = (OrganizationViewList)OrgDataGrid.Rows[selectedRow].DataBoundItem;
            var result = new OrganizationEditView(selectedItem, State.Update);
            if (result.ShowDialog() == DialogResult.OK)
            {
                service.Put("organizations", selectedItem.Id, result.OrganizationEdit);
            }
            ShowOrganizations();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = OrgDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            service.Delete("organizations", ((OrganizationViewList)OrgDataGrid.Rows[selectedRow].DataBoundItem).Id);
            ShowOrganizations();
        }

        private void OrgDataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            FiltrGroupBox.Visible = false;
            if (e.Button == MouseButtons.Right)
            {
                var hti = OrgDataGrid.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    OrgDataGrid.ClearSelection();
                    OrgDataGrid.Rows[hti.RowIndex].Selected = true;
                    OrganizationContextMenuStrip.Show(OrgDataGrid, e.Location);
                }
                else if (hti.ColumnIndex > -1)
                {
                    FiltrTextBox.Text = _filterSetting[OrgDataGrid.Columns[hti.ColumnIndex].DataPropertyName];
                    FiltrGroupBox.Visible = true;
                    if (hti.ColumnIndex == OrgDataGrid.ColumnCount - 1)
                        FiltrGroupBox.Location = new Point(hti.ColumnX - 80, hti.RowY + 80);
                    else FiltrGroupBox.Location = new Point(hti.ColumnX, hti.RowY + 80);
                    _columnName = OrgDataGrid.Columns[hti.ColumnIndex].DataPropertyName;
                }
            }

        }

        private void OrgDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var hti = OrgDataGrid.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    var selectedRow = OrgDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    new OrganizationEditView((OrganizationViewList)OrgDataGrid.Rows[selectedRow].DataBoundItem,
                        State.Read).ShowDialog();
                }
            }
        }

        private void AcceptFiltrButton_Click(object sender, EventArgs e)
        {
            if (FiltrTextBox.Text.Length != 0)
            {
                _filterSetting[_columnName] = FiltrTextBox.Text;
                FiltrTextBox.Clear();
                FiltrGroupBox.Visible = false;
                ShowOrganizations();
            }
        }

        private void ClearFiltrsButton_Click(object sender, EventArgs e)
        {
            InitializeFiltrsDictionary();
            FiltrTextBox.Clear();
            ShowOrganizations();
            FiltrGroupBox.Visible = false;
        }

        private void InitializeFiltrsDictionary()
        {
            _filterSetting = new FilterSetting(typeof(OrganizationViewList));
        }
    }
}