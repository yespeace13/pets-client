using ModelLibrary.Model.Organization;
using ModelLibrary.Model.Papka;
using ModelLibrary.Model.Report;
using ModelLibrary.View;
using PetsClient.Authentication;
using PetsClient.Etc;
using PetsClient.Services;
using System.Security.Cryptography;

namespace PetsClient.Domain.Log
{
    public partial class LogView : Form
    {
        private string _columnName;
        private SortSettings _sortSettings;
        private PageSettingsView _page;
        private FilterSetting _filterSetting;
        private APIServiceModel<LogViewList, LogViewList, LogViewList> _service;

        public LogView()
        {
            _service = new APIServiceModel<LogViewList, LogViewList, LogViewList>();
            InitializeComponent();
            InitializeForm();
            InitializeFiltrsDictionary();
            ShowData();
        }

        private void InitializeForm()
        {

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
            (string Column, int Value) sortCol = ViewDataGridView.SortedColumn == null ?
                ("Id", 0) : (ViewDataGridView.SortedColumn.Name, ViewDataGridView.SortOrder == SortOrder.Descending ? 0 : 1);
            _page = new PageSettingsView();
            _sortSettings = new SortSettings(sortCol.Column, sortCol.Value);

            _page.Sort = _sortSettings;
            _page.Filter = _filterSetting;
            _page.Pages = (int)PagesSize.Value;
            _page.Page = (int)NumberOfPage.Value;
            var page = APIServiceOne.GetAllFromPage<LogViewList>("logs");
            if (page != null)
            {
                ViewDataGridView.DataSource = page;
                NumberOfPage.Maximum = 1;
            }

        }

        private void PagesSize_ValueChanged(object sender, EventArgs e) => ShowData();

        private void AcceptButton_Click(object sender, EventArgs e) => ShowData();

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel | *.xlsx";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.FileName = "Отчет";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var byteArray = APIServiceOne.GetFile("logs-excel");
                var path = saveFileDialog.FileName;
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
                    //OrganizationContextMenuStrip.Show(ViewDataGridView, e.Location);
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

        private void InitializeFiltrsDictionary()
        {
            _filterSetting = new FilterSetting(typeof(OrganizationViewList));
        }
    }
}