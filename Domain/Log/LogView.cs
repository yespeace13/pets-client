using ModelLibrary.Model.LogInformation;
using ModelLibrary.View;
using PetsClient.Services;

namespace PetsClient.Domain.Log
{
    public partial class LogView : Form
    {
        private string _columnName;
        private SortSettings _sortSettings;
        private PageSettingsView _page;
        private FilterSetting _filterSetting;
        private readonly APIServiceModel<LogViewList, LogViewList, LogViewList> _service;

        public LogView()
        {
            _service = new APIServiceModel<LogViewList, LogViewList, LogViewList>();
            InitializeComponent();
            InitializeFiltrsDictionary();
            ShowData();
        }

        private void InitializeFiltrsDictionary()
        {
            _filterSetting = new FilterSetting(typeof(LogViewList));
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
            if (NumberOfPage.Minimum < NumberOfPage.Value)
            {
                NumberOfPage.Value--;
                ShowData();
            }
        }

        public void ShowData()
        {
            (string Column, int Value) = ViewDataGridView.SortedColumn == null ?
                ("Id", 0) : (ViewDataGridView.SortedColumn.Name, ViewDataGridView.SortOrder == SortOrder.Descending ? 0 : 1);
            _page = new PageSettingsView();
            _sortSettings = new SortSettings(Column, Value);

            _page.Sort = _sortSettings;
            _page.Filter = _filterSetting;
            _page.Pages = (int)PagesSize.Value;
            _page.Page = (int)NumberOfPage.Value;
            var page = _service.Get("logs", _page);
            if (page != null)
            {
                ViewDataGridView.DataSource = page.Items;
                NumberOfPage.Maximum = page.Pages;
            }

        }

        private void PagesSize_ValueChanged(object sender, EventArgs e) => ShowData();

        private void AcceptButton_Click(object sender, EventArgs e) => ShowData();

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel | *.xlsx",
                DefaultExt = "xlsx",
                FileName = "Отчет"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var byteArray = APIServiceOne.GetFile("logs-export");
                var path = saveFileDialog.FileName;
                if (byteArray != null)
                    File.WriteAllBytes(path, byteArray);
            }
        }

        private void OrgDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ShowData();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = ViewDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            _service.Delete("logs", ((LogViewList)ViewDataGridView.Rows[selectedRow].DataBoundItem).Id);
            //var selectedItem = (LogViewList)ViewDataGridView.Rows[selectedRow].DataBoundItem;
            //_service.Delete("logs", selectedItem.Id);
            ShowData();
        }

        private void OrgDataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            FiltrGroupBox.Visible = false;
            if (e.Button == MouseButtons.Right)
            {
                var hti = ViewDataGridView.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    ViewDataGridView.ClearSelection();
                    ViewDataGridView.Rows[hti.RowIndex].Selected = true;
                    LogContextMenuStrip.Show(ViewDataGridView, e.Location);
                }
                else if (hti.ColumnIndex > -1)
                {
                    FiltrTextBox.Text = _filterSetting[ViewDataGridView.Columns[hti.ColumnIndex].DataPropertyName];
                    //FiltrGroupBox.Visible = true;
                    //if (hti.ColumnIndex == ViewDataGridView.ColumnCount - 1)
                    //    FiltrGroupBox.Location = new Point(hti.ColumnX - 80, hti.RowY + 80);
                    //else FiltrGroupBox.Location = new Point(hti.ColumnX, hti.RowY + 80);
                    //_columnName = ViewDataGridView.Columns[hti.ColumnIndex].DataPropertyName;

                    if (hti.ColumnIndex == 12)
                    {
                        if (FiltrGroupBox.Size.Height == 89)
                            FiltrGroupBox.Size = new Size(FiltrGroupBox.Size.Width, FiltrGroupBox.Size.Height + 28);
                        FiltrTextBox.Visible = false;

                        FiltrStartDateTimePicker.Visible = true;
                        FiltrStartDateTimePicker.Location = FiltrTextBox.Location;

                        FiltrEndDateTimePicker.Location = new Point(FiltrTextBox.Location.X, FiltrTextBox.Location.Y + 28);
                        FiltrEndDateTimePicker.Visible = true;

                        // Фильтрация по дате TODO надо переделать общий фильтр в сервисе, чтобы работал с датой
                        if (_filterSetting[ViewDataGridView.Columns[hti.ColumnIndex].DataPropertyName] != "")
                        {
                            var dates = _filterSetting[ViewDataGridView.Columns[hti.ColumnIndex].DataPropertyName].Split(' ');
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
                    if (hti.ColumnIndex == ViewDataGridView.ColumnCount - 1)
                        FiltrGroupBox.Location = new Point(hti.ColumnX - 80, hti.RowY + 80);
                    else FiltrGroupBox.Location = new Point(hti.ColumnX, hti.RowY + 80);
                    _columnName = ViewDataGridView.Columns[hti.ColumnIndex].DataPropertyName;
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