using ModelLibrary.Model.Report;
using PetsClient.Services;
using System.Collections;

namespace PetsClient.Domain.Report
{
    public partial class ReportEditView : Form, IView
    {
        private APIServiceConnection<ReportViewList, ReportViewList, ReportViewOne> _service;
        private int  _id;
        public ReportEditView(APIServiceConnection<ReportViewList, ReportViewList, ReportViewOne> service, int id)
        {
            InitializeComponent();
            _service = service;
            ToDateTimePicker.Enabled = false;
            FromDateTimePicker.Enabled = false;
            NumberTextBox.Enabled = false;
            _id = id;
            FillFields();
        }

        private void FillFields()
        {
            var report = _service.Get("reports", _id);
            ToDateTimePicker.Value = report.DateEnd.ToDateTime(TimeOnly.MinValue);
            FromDateTimePicker.Value = report.DateStart.ToDateTime(TimeOnly.MinValue);
            NumberTextBox.Text = report.Number.ToString();
            ContentDataGridView.DataSource = report.ReportContent;
        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();

        private void ExportExcelButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel | *.xlsx";
            saveFileDialog.DefaultExt = "Отчет";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var byteArray = APIServiceOne.GetFile("reports-excel/" + _id);
                var path = saveFileDialog.FileName;
                File.WriteAllBytes(path, byteArray);
            }
        }
    }
}
