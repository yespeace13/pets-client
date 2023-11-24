using ModelLibrary.Model.Act;
using ModelLibrary.View;
using PetsClient.Authentication;
using PetsClient.Etc;
using PetsClient.Services;

namespace PetsClient.Act
{
    public partial class Actview : Form
    {
        private string _columnName;
        private SortSettings _sortSettings;
        private PageSettingsView _page;
        private FilterSetting _filterSetting;
        private APIServiceConnection<ActViewList, ActEdit, ActViewOne> _service;
        public Actview()
        {
            _service = new APIServiceConnection<ActViewList, ActEdit, ActViewOne>();
            InitializeComponent();
            InitializeForm();
            InitializeFiltrsDictionary();
            ShowActs();
        }
        private void InitializeFiltrsDictionary()
        {
            _filterSetting = new FilterSetting(typeof(ActViewList));
        }

        private void InitializeForm()
        {
            CreateButton.Enabled = false;
            ChangeToolStripMenuItem.Enabled = false;
            DeleteToolStripMenuItem.Enabled = false;

            foreach (var possibility in UserData.PossibilitiesForEntity("Act"))
            {
                switch (possibility)
                {
                    case "Create":
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
            ShowActs();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            if (NumberOfPage.Maximum > NumberOfPage.Value)
            {
                NumberOfPage.Value++;
                ShowActs();
            }

        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            NumberOfPage.Value = NumberOfPage.Value > 1 ? --NumberOfPage.Value : NumberOfPage.Value;
            ShowActs();
        }

        public void ShowActs()
        {
            (string Column, int Value) sortCol = ActsDataGridView.SortedColumn == null ?
                ("Id", 0) : (ActsDataGridView.SortedColumn.Name, ActsDataGridView.SortOrder == SortOrder.Descending ? 0 : 1);
            _page = new PageSettingsView();
            _sortSettings = new SortSettings(sortCol.Column, sortCol.Value);

            _page.Sort = _sortSettings;
            _page.Filter = _filterSetting;
            _page.Pages = (int)PagesSize.Value;
            _page.Page = (int)NumberOfPage.Value;
            var page = _service.Get("acts", _page);
            if (page != null)
            {
                ActsDataGridView.DataSource = page.Items;
                NumberOfPage.Maximum = page.Pages;
            }
        }

        private void CreateActButton_Click(object sender, EventArgs e)
        {
            var result = new ActEditView();
            if (result.ShowDialog() == DialogResult.OK)
            {
                _service.Post("acts", result.Act);
            }
            ShowActs();
        }

        private void PagesSize_ValueChanged(object sender, EventArgs e)
        {
            ShowActs();
        }


        private void AcceptButton_Click(object sender, EventArgs e)
        {
            ShowActs();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var byteArray = _service.GetFile("actsexport", _filterSetting);
            File.WriteAllBytes("Акты.xlsx", byteArray);
        }

        private void ActsDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) =>
            ShowActs();

        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = ActsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            var selectedItem = (ActViewList)ActsDataGridView.Rows[selectedRow].DataBoundItem;
            var result = new ActEditView(State.Update, selectedItem.Id);
            if (result.ShowDialog() == DialogResult.OK)
            {
                _service.Put("acts", selectedItem.Id, result.Act);
            }
            ShowActs();
        }


        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = ActsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            _service.Delete("acts", ((ActViewList)ActsDataGridView.Rows[selectedRow].DataBoundItem).Id);
            ShowActs();
        }

        private void ConDataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            FiltrGroupBox.Visible = false;
            if (e.Button == MouseButtons.Right)
            {
                var hti = ActsDataGridView.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    ActsDataGridView.ClearSelection();
                    ActsDataGridView.Rows[hti.RowIndex].Selected = true;
                    ContractContextMenuStrip.Show(ActsDataGridView, e.Location);
                }
                else if (hti.ColumnIndex > -1)
                {
                    FiltrTextBox.Text = _filterSetting[ActsDataGridView.Columns[hti.ColumnIndex].Name];
                    if (hti.ColumnIndex == 2)
                    {
                        if (FiltrGroupBox.Size.Height == 89)
                            FiltrGroupBox.Size = new Size(FiltrGroupBox.Size.Width, FiltrGroupBox.Size.Height + 28);
                        FiltrTextBox.Visible = false;

                        FiltrStartDateTimePicker.Visible = true;
                        FiltrStartDateTimePicker.Location = FiltrTextBox.Location;

                        FiltrEndDateTimePicker.Location = new Point(FiltrTextBox.Location.X, FiltrTextBox.Location.Y + 28);
                        FiltrEndDateTimePicker.Visible = true;

                        if (_filterSetting[ActsDataGridView.Columns[hti.ColumnIndex].DataPropertyName] != "")
                        {
                            var dates = _filterSetting[ActsDataGridView.Columns[hti.ColumnIndex].DataPropertyName].Split(' ');
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
                    //if (hti.ColumnIndex == ConDataGrid.ColumnCount - 1)
                    //    FiltrGroupBox.Location = new Point(hti.ColumnX - 60, hti.RowY + 60);
                    //else 
                    FiltrGroupBox.Location = new Point(hti.ColumnX, hti.RowY + 60);
                    _columnName = ActsDataGridView.Columns[hti.ColumnIndex].Name;
                }
            }

        }

        private void ActsDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var hti = ActsDataGridView.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    var selectedRow = ActsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    new ActEditView(State.Read, ((ActViewList)ActsDataGridView.Rows[selectedRow].DataBoundItem).Id).ShowDialog();
                }
            }
        }

        private void AcceptFiltrButton_Click(object sender, EventArgs e)
        {
            if (_columnName == "DateOfCapture")
            {
                _filterSetting[_columnName] = FiltrStartDateTimePicker.Value.ToShortDateString() + " "
                    + FiltrEndDateTimePicker.Value.ToShortDateString();
                FiltrStartDateTimePicker.Value = DateTime.Now;
                FiltrGroupBox.Visible = false;
                ShowActs();
            }
            else if (FiltrTextBox.Text.Length != 0)
            {
                _filterSetting[_columnName] = FiltrTextBox.Text;
                FiltrTextBox.Clear();
                FiltrGroupBox.Visible = false;
                ShowActs();
            }
        }

        private void ClearFiltrsButton_Click(object sender, EventArgs e)
        {
            InitializeFiltrsDictionary();
            FiltrTextBox.Clear();
            ShowActs();
            FiltrGroupBox.Visible = false;
        }
    }
}
