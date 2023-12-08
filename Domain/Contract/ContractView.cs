using ModelLibrary.Model.Contract;
using ModelLibrary.View;
using PetsClient.Authentication;
using PetsClient.Etc;
using PetsClient.Services;

namespace PetsClient.Contract
{
    public partial class Contractview : Form
    {
        private string _columnName;
        private SortSettings _sortSettings;
        private PageSettingsView _page;
        private FilterSetting _filterSetting;
        private APIServiceModel<ContractViewList, ContractEdit, ContractViewOne> _service;
        public Contractview()
        {
            InitializeComponent();
            InitializeForm();
            InitializeFiltrsDictionary();
            ShowData();
        }
        private void InitializeFiltrsDictionary()
        {
            _filterSetting = new FilterSetting(typeof(ContractViewList));
            _service = new APIServiceModel<ContractViewList, ContractEdit, ContractViewOne>();
        }

        private void InitializeForm()
        {
            CreateButton.Enabled = false;
            ChangeToolStripMenuItem.Enabled = false;
            DeleteToolStripMenuItem.Enabled = false;

            foreach (var possibility in UserData.PossibilitiesForEntity("Contract"))
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
            (string Column, int Value) sortCol = ConDataGrid.SortedColumn == null ?
                ("Id", 0) : (ConDataGrid.SortedColumn.Name, ConDataGrid.SortOrder == SortOrder.Descending ? 0 : 1);
            _page = new PageSettingsView();
            _sortSettings = new SortSettings(sortCol.Column, sortCol.Value);

            _page.Sort = _sortSettings;
            _page.Filter = _filterSetting;
            _page.Pages = (int)PagesSize.Value;
            _page.Page = (int)NumberOfPage.Value;
            var page = _service.Get("contracts", _page);
            if (page != null)
            {
                ConDataGrid.DataSource = page.Items;
                NumberOfPage.Maximum = page.Pages;
            }
        }

        private void CreateContractButton_Click(object sender, EventArgs e)
        {
            if (new ContractEditView().ShowDialog() == DialogResult.OK)
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
            saveFileDialog.DefaultExt = "Контракты";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var byteArray = _service.GetFile("contract-export", _filterSetting);
                var path = saveFileDialog.FileName;
                File.WriteAllBytes(path, byteArray);
            }
        }

        private void ConDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) =>
            ShowData();

        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = ConDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            var selectedItem = (ContractViewList)ConDataGrid.Rows[selectedRow].DataBoundItem;
            if (new ContractEditView(State.Update, selectedItem.Id).ShowDialog() == DialogResult.OK)
                ShowData();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = ConDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            var selectedItem = (ContractViewList)ConDataGrid.Rows[selectedRow].DataBoundItem;
            _service.Delete("contracts", selectedItem.Id);
            ShowData();
        }

        private void ConDataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            FiltrGroupBox.Visible = false;
            if (e.Button == MouseButtons.Right)
            {
                var hti = ConDataGrid.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    ConDataGrid.ClearSelection();
                    ConDataGrid.Rows[hti.RowIndex].Selected = true;
                    ContractContextMenuStrip.Show(ConDataGrid, e.Location);
                }
                else if (hti.ColumnIndex > -1)
                {
                    FiltrTextBox.Text = _filterSetting[ConDataGrid.Columns[hti.ColumnIndex].DataPropertyName];

                    // Для даты
                    if (hti.ColumnIndex == 2 || hti.ColumnIndex == 3)
                    {
                        if (FiltrGroupBox.Size.Height == 89)
                            FiltrGroupBox.Size = new Size(FiltrGroupBox.Size.Width, FiltrGroupBox.Size.Height + 28);
                        FiltrTextBox.Visible = false;

                        FiltrStartDateTimePicker.Visible = true;
                        FiltrStartDateTimePicker.Location = FiltrTextBox.Location;

                        FiltrEndDateTimePicker.Location = new Point(FiltrTextBox.Location.X, FiltrTextBox.Location.Y + 28);
                        FiltrEndDateTimePicker.Visible = true;

                        // Фильтрация по дате TODO надо переделать общий фильтр в сервисе, чтобы работал с датой
                        if (_filterSetting[ConDataGrid.Columns[hti.ColumnIndex].DataPropertyName] != "")
                        {
                            var dates = _filterSetting[ConDataGrid.Columns[hti.ColumnIndex].DataPropertyName].Split(' ');
                            FiltrStartDateTimePicker.Value = DateTime.Parse(dates[0]);
                            FiltrEndDateTimePicker.Value = DateTime.Parse(dates[1]);
                        }
                    }
                    else
                    {
                        FiltrGroupBox.Size = new Size(FiltrGroupBox.Size.Width, 89);
                        FiltrTextBox.Visible = true;
                        FiltrStartDateTimePicker.Visible = false;
                        FiltrEndDateTimePicker.Visible = false;
                    }
                    FiltrGroupBox.Visible = true;
                    if (hti.ColumnIndex == ConDataGrid.ColumnCount - 1)
                        FiltrGroupBox.Location = new Point(hti.ColumnX - 80, hti.RowY + 60);
                    else FiltrGroupBox.Location = new Point(hti.ColumnX, hti.RowY + 60);
                    _columnName = ConDataGrid.Columns[hti.ColumnIndex].DataPropertyName;
                }
            }

        }

        private void ConDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var hti = ConDataGrid.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    var selectedRow = ConDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    new ContractEditView(State.Read, ((ContractViewList)ConDataGrid.Rows[selectedRow].DataBoundItem).Id).ShowDialog();
                }
            }
        }

        private void AcceptFiltrButton_Click(object sender, EventArgs e)
        {
            if (_columnName == "DateOfConclusion" || _columnName == "DateValid")
            {
                _filterSetting[_columnName] = FiltrStartDateTimePicker.Value.ToShortDateString() + " "
                    + FiltrEndDateTimePicker.Value.ToShortDateString();
                FiltrStartDateTimePicker.Value = DateTime.Now;
                FiltrGroupBox.Visible = false;
                ShowData();
            }
            else if (FiltrTextBox.Text.Length != 0)
            {
                _filterSetting[_columnName] = FiltrTextBox.Text;
                FiltrTextBox.Clear();
                FiltrGroupBox.Visible = false;
                ShowData();
            }

        }

        private void ClearFiltrsButton_Click(object sender, EventArgs e)
        {
            InitializeFiltrsDictionary();
            FiltrTextBox.Clear();
            ShowData();
            FiltrGroupBox.Visible = false;
        }
    }
}
