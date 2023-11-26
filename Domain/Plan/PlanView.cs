using ModelLibrary.Model.Plan;
using ModelLibrary.View;
using PetsClient.Authentication;
using PetsClient.Etc;
using PetsClient.Services;

namespace PetsClient.Domain.Plan;

public partial class PlanView : Form
{
    private string _columnName;
    private SortSettings _sortSettings;
    private PageSettingsView _page;
    private FilterSetting _filterSetting;
    private APIServiceConnection<PlanViewList, PlanEdit, PlanViewOne> _service;
    public PlanView()
    {
        InitializeComponent();
        InitializeForm();
        InitializeFiltrsDictionary();
        ShowData();
    }
    private void InitializeFiltrsDictionary()
    {
        _filterSetting = new FilterSetting(typeof(PlanViewList));
        _service = new APIServiceConnection<PlanViewList, PlanEdit, PlanViewOne>();
    }

    private void InitializeForm()
    {
        CreateButton.Enabled = false;
        ChangeToolStripMenuItem.Enabled = false;
        DeleteToolStripMenuItem.Enabled = false;

        foreach (var possibility in UserData.PossibilitiesForEntity("Schedule"))
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
        ShowData();
    }

    private void NextPageButton_Click(object sender, EventArgs e)
    {
        if (NumberOfPage.Maximum > NumberOfPage.Value)
        {
            NumberOfPage.Value++;
            ShowData();
        }

    }

    private void PreviousPageButton_Click(object sender, EventArgs e)
    {
        NumberOfPage.Value = NumberOfPage.Value > 1 ? --NumberOfPage.Value : NumberOfPage.Value;
        ShowData();
    }

    public void ShowData()
    {
        (string Column, int Value) sortCol = ItemsDataGridView.SortedColumn == null ?
            ("Id", 0) : (ItemsDataGridView.SortedColumn.Name, ItemsDataGridView.SortOrder == SortOrder.Descending ? 0 : 1);
        _page = new PageSettingsView();
        _sortSettings = new SortSettings(sortCol.Column, sortCol.Value);

        _page.Sort = _sortSettings;
        _page.Filter = _filterSetting;
        _page.Pages = (int)PagesSize.Value;
        _page.Page = (int)NumberOfPage.Value;
        var page = _service.Get("plans", _page);
        if (page != null)
        {
            ItemsDataGridView.DataSource = page.Items;
            NumberOfPage.Maximum = page.Pages;
        }
    }

    private void CreateContractButton_Click(object sender, EventArgs e)
    {
        var result = new PlanEditView(_service);
        if (result.ShowDialog() == DialogResult.OK)
            _service.Post("plans", result.PlanEdited);

        ShowData();
    }

    private void PagesSize_ValueChanged(object sender, EventArgs e)
    {
        ShowData();
    }


    private void AcceptButton_Click(object sender, EventArgs e)
    {
        ShowData();
    }

    private void ExportButton_Click(object sender, EventArgs e)
    {
        var saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Excel | *.xlsx";
        saveFileDialog.DefaultExt = "xlsx";
        saveFileDialog.FileName = "Планы-графики отлова";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            var byteArray = _service.GetFile("plans-excel", _filterSetting);
            var path = saveFileDialog.FileName;
            File.WriteAllBytes(path, byteArray);
        }
    }

    private void ConDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) =>
        ShowData();

    private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var selectedRow = ItemsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
        var selectedItem = (PlanViewList)ItemsDataGridView.Rows[selectedRow].DataBoundItem;
        var result = new PlanEditView(State.Update, selectedItem.Id, _service);
        if (result.ShowDialog() == DialogResult.OK)
        {
            _service.Put("plans", selectedItem.Id, result.PlanEdited);
        }
        ShowData();
    }

    private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var selectedRow = ItemsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
        var selectedItem = (PlanViewList)ItemsDataGridView.Rows[selectedRow].DataBoundItem;
        _service.Delete("plans", selectedItem.Id);
        ShowData();
    }

    private void ConDataGrid_MouseDown(object sender, MouseEventArgs e)
    {
        FiltrGroupBox.Visible = false;
        if (e.Button == MouseButtons.Right)
        {
            var hti = ItemsDataGridView.HitTest(e.X, e.Y);
            if (hti.RowIndex != -1)
            {
                ItemsDataGridView.ClearSelection();
                ItemsDataGridView.Rows[hti.RowIndex].Selected = true;
                ContractContextMenuStrip.Show(ItemsDataGridView, e.Location);
            }
            else if (hti.ColumnIndex > -1)
            {
                FiltrTextBox.Text = _filterSetting[ItemsDataGridView.Columns[hti.ColumnIndex].DataPropertyName];


                //else
                //{
                //    FiltrGroupBox.Size = new Size(FiltrGroupBox.Size.Width, 89);
                //    FiltrTextBox.Visible = true;
                //}
                //FiltrGroupBox.Visible = true;
                //if (hti.ColumnIndex == ItemsDataGridView.ColumnCount - 1)
                //    FiltrGroupBox.Location = new Point(hti.ColumnX - 80, hti.RowY + 60);
                //else FiltrGroupBox.Location = new Point(hti.ColumnX, hti.RowY + 60);
                //_columnName = ItemsDataGridView.Columns[hti.ColumnIndex].DataPropertyName;
            }
        }

    }

    private void ConDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            var hti = ItemsDataGridView.HitTest(e.X, e.Y);
            if (hti.RowIndex != -1)
            {
                var selectedRow = ItemsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                new PlanEditView(State.Read, ((PlanViewList)ItemsDataGridView.Rows[selectedRow].DataBoundItem).Id, _service)
                    .ShowDialog();
            }
        }
    }

    private void AcceptFiltrButton_Click(object sender, EventArgs e)
    {
        //if (_columnName == "DateOfConclusion" || _columnName == "DateValidation")
        //{
        //    _filterSetting[_columnName] = FiltrStartDateTimePicker.Value.ToShortDateString() + " "
        //        + FiltrEndDateTimePicker.Value.ToShortDateString();
        //    FiltrStartDateTimePicker.Value = DateTime.Now;
        //    FiltrGroupBox.Visible = false;
        //    ShowContracts();
        //}
        //else if (FiltrTextBox.Text.Length != 0)
        //{
        //    _filterSetting[_columnName] = FiltrTextBox.Text;
        //    FiltrTextBox.Clear();
        //    FiltrGroupBox.Visible = false;
        //    ShowContracts();
        //}

    }

    private void ClearFiltrsButton_Click(object sender, EventArgs e)
    {
        InitializeFiltrsDictionary();
        FiltrTextBox.Clear();
        ShowData();
        FiltrGroupBox.Visible = false;
    }
}
