using ModelLibrary.Model.Animal;
using ModelLibrary.Model.Organization;
using ModelLibrary.View;
using PetsClient.Act;
using PetsClient.Etc;
using PetsClient.Services;

namespace PetsClient.Animal;

public partial class AnimalView : Form
{
    private string _columnName;
    private SortSettings _sortSettings;
    private PageSettingsView _page;
    private FilterSetting _filterSetting;
    private APIServiceConnection<AnimalViewList, AnimalEdit, AnimalViewList> service;

    public AnimalView()
    {
        service = new APIServiceConnection<AnimalViewList, AnimalEdit, AnimalViewList>();
        InitializeComponent();
        InitializeForm();
        InitializeFiltrsDictionary();
        ShowOrganizations();
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
        (string Column, int Value) sortCol = ViewDataGridView.SortedColumn == null ?
            ("Id", 0) : (ViewDataGridView.SortedColumn.Name, ViewDataGridView.SortOrder == SortOrder.Descending ? 0 : 1);
        _page = new PageSettingsView();
        _sortSettings = new SortSettings(sortCol.Column, sortCol.Value);

        _page.Sort = _sortSettings;
        _page.Filter = _filterSetting;
        _page.Pages = (int)PagesSize.Value;
        _page.Page = (int)NumberOfPage.Value;
        var page = service.Get("animals", _page);
        if (page != null)
        {
            ViewDataGridView.DataSource = page.Items;
            NumberOfPage.Maximum = page.Pages;
        }

    }

    private void CreateOrgButton_Click(object sender, EventArgs e)
    {
        var result = new AnimalEditView();
        if (result.ShowDialog() == DialogResult.OK)
            service.Post("animals", result.Animal);

        ShowOrganizations();
    }

    private void PagesSize_ValueChanged(object sender, EventArgs e) => ShowOrganizations();

    private void AcceptButton_Click(object sender, EventArgs e) => ShowOrganizations();

    private void ExportButton_Click(object sender, EventArgs e)
    {
        var byteArray = service.GetFile("animalsexport", _filterSetting);
        File.WriteAllBytes("Животные.xlsx", byteArray);
    }

    private void ViewDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
            ShowOrganizations();
    }

    private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var selectedRow = ViewDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
        var selectedItem = (AnimalViewList)ViewDataGridView.Rows[selectedRow].DataBoundItem;
        var result = new AnimalEditView(State.Update, selectedItem.Id);
        if (result.ShowDialog() == DialogResult.OK)
        {
            service.Put("animals", selectedItem.Id, result.Animal);
        }
        ShowOrganizations();
    }

    private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var selectedRow = ViewDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
        service.Delete("animals", ((OrganizationViewList)ViewDataGridView.Rows[selectedRow].DataBoundItem).Id);
        ShowOrganizations();
    }

    private void ViewDataGrid_MouseDown(object sender, MouseEventArgs e)
    {
        FiltrGroupBox.Visible = false;
        if (e.Button == MouseButtons.Right)
        {
            var hti = ViewDataGridView.HitTest(e.X, e.Y);
            if (hti.RowIndex != -1)
            {
                ViewDataGridView.ClearSelection();
                ViewDataGridView.Rows[hti.RowIndex].Selected = true;
                OrganizationContextMenuStrip.Show(ViewDataGridView, e.Location);
            }
            else if (hti.ColumnIndex > -1)
            {
                FiltrTextBox.Text = _filterSetting[ViewDataGridView.Columns[hti.ColumnIndex].DataPropertyName];
                FiltrGroupBox.Visible = true;
                if (hti.ColumnIndex == ViewDataGridView.ColumnCount - 1)
                    FiltrGroupBox.Location = new Point(hti.ColumnX - 80, hti.RowY + 80);
                else FiltrGroupBox.Location = new Point(hti.ColumnX, hti.RowY + 80);
                _columnName = ViewDataGridView.Columns[hti.ColumnIndex].DataPropertyName;
            }
        }

    }

    private void ViewDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            var hti = ViewDataGridView.HitTest(e.X, e.Y);
            if (hti.RowIndex != -1)
            {
                var selectedRow = ViewDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                new AnimalEditView(State.Read, ((AnimalViewList)ViewDataGridView.Rows[selectedRow].DataBoundItem).Id).ShowDialog();
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