﻿using ModelLibrary.Model.Organization;
using ModelLibrary.Model.Report;
using ModelLibrary.View;
using PetsClient.Etc;
using PetsClient.Services;

namespace PetsClient.Domain.Report
{
    public partial class ReportView : Form
    {
        private string _columnName;
        private SortSettings _sortSettings;
        private PageSettingsView _page;
        private FilterSetting _filterSetting;
        private readonly APIServiceModel<ReportViewList, ReportViewList, ReportViewOne> _service;

        public ReportView()
        {
            _service = new APIServiceModel<ReportViewList, ReportViewList, ReportViewOne>();
            InitializeComponent();
            InitializeFiltrsDictionary();
            ShowData();
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
            var page = _service.Get("reports", _page);
            if (page != null)
            {
                ViewDataGridView.DataSource = page.Items;
                NumberOfPage.Maximum = page.Pages;
            }

        }

        private void CreateItemButton_Click(object sender, EventArgs e)
        {
            var result = new ReportGenerate();
            if (result.ShowDialog() == DialogResult.OK)
                APIServiceOne.CreateReport("reports", result.From, result.To);

            ShowData();
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
                var byteArray = APIServiceOne.GetFile("reports-export");
                var path = saveFileDialog.FileName;
                if(byteArray != null)
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
            _service.Delete("reports", ((ReportViewList)ViewDataGridView.Rows[selectedRow].DataBoundItem).Id);
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
                    ReportContextMenuStrip.Show(ViewDataGridView, e.Location);
                    var report = (ReportViewList)ViewDataGridView.Rows[hti.RowIndex].DataBoundItem;
                    var statuses = APIServiceOne.Get<List<ReportStatusView>>($"reports/{report.Id}/statuses");
                    if (statuses?.Count == 1)
                        ChangeToolStripMenuItem.Enabled = false;
                    else
                        ChangeToolStripMenuItem.Enabled = true;

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

        private void OrgDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var hti = ViewDataGridView.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    var selectedRow = ViewDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    new ReportEditView(((ReportViewList)ViewDataGridView.Rows[selectedRow].DataBoundItem).Id).ShowDialog();
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
            _filterSetting = new FilterSetting(typeof(ReportViewList));
        }

        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = ViewDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            var id = ((ReportViewList)ViewDataGridView.Rows[selectedRow].DataBoundItem).Id;
            if (new ReportEditView(id, State.Update).ShowDialog() == DialogResult.OK)
                ShowData();
            
        }
    }
}