using IS_5.Services;
using IS_5.View;
using ModelLibrary.View;
using ModelLibrary.Model.Organization;

namespace IS_5
{
    public partial class OrganizationView : Form
    {
        private string _columnName;
        private SortSettings _sortSettings;
        private PageSettingsView _page;
        private FilterSetting _filterSetting;
        private APIServiceConnection<OrganizationViewList> service;

        public OrganizationView()
        {
            service = new APIServiceConnection<OrganizationViewList>();
            InitializeComponent();
            InitializeFiltrsDictionary();
            InitializeForm();
            ShowOrganizations();
        }

        private void InitializeFiltrsDictionary()
        {
            _filterSetting = new FilterSetting(typeof(OrganizationViewList));
        }

        private void InitializeForm()
        {
            //var possibilites = UserSession.User.Privilege.Organizations.Item2;
            //CreateOrgButton.Enabled = false;
            //ChangeToolStripMenuItem.Enabled = false;
            //DeleteToolStripMenuItem.Enabled = false;
            //if (possibilites == null) return;
            //foreach (var poss in possibilites)
            //{
            //    switch (poss)
            //    {
            //        case Possibilities.Add:
            //            CreateOrgButton.Enabled = true;
            //            break;
            //        case Possibilities.Change:
            //            ChangeToolStripMenuItem.Enabled = true;
            //            break;
            //        case Possibilities.Delete:
            //            DeleteToolStripMenuItem.Enabled = true;
            //            break;
            //    }
            //}
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
            //(string Column, int Value) sortCol = OrgDataGrid.SortedColumn == null ?
            //    ("Id", 0) : (OrgDataGrid.SortedColumn.Name, OrgDataGrid.SortOrder == SortOrder.Descending ? 0 : 1);
            //_page = new PageSettingsView();
            //_sortSettings = new SortSettings(sortCol.Column, sortCol.Value);

            //_page.Sort = _sortSettings;
            //_page.Filter = _filterSetting;
            //_page.Pages = (int)PagesSize.Value;
            //_page.Page = (int)NumberOfPage.Value;
            //var page = service.Get("organizations", _page);
            //OrgDataGrid.DataSource = page.Items;
            //NumberOfPage.Maximum = page.Pages;
        }

        private void CreateOrgButton_Click(object sender, EventArgs e)
        {
            new OrganizationEditOne().ShowDialog();
            ShowOrganizations();
        }

        private void PagesSize_ValueChanged(object sender, EventArgs e)
        {
            ShowOrganizations();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            ShowOrganizations();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            //var columns = new string[OrgDataGrid.ColumnCount];
            //for (var col = 0; col < OrgDataGrid.ColumnCount; col++)
            //    columns[col] = OrgDataGrid.Columns[col].HeaderText;
            //_controller.ExportToExcel(columns, _filterSetting);
        }

        private void OrgDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ShowOrganizations();
        }

        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var selectedRow = OrgDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            //new OrganizationEditView(_controller, State.Update,
            //    int.Parse(OrgDataGrid.Rows[selectedRow].Cells[0].Value.ToString())).ShowDialog();
            //ShowOrganizations();
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
                    //var selectedRow = OrgDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    //new OrganizationEditOne(
                    //    (OrganizationViewList)OrgDataGrid.Rows[selectedRow].DataBoundItem,
                    //    PetsClient.Etc.State.Read).ShowDialog();
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
    }
}