using ModelLibrary.Model.Report;
using PetsClient.Services;

namespace PetsClient.Domain.Report
{
    public partial class ReportEditView : Form, IView
    {
        private APIServiceConnection<ReportViewList, ReportViewList, ReportViewOne> _service;
        public ReportEditView(APIServiceConnection<ReportViewList, ReportViewList, ReportViewOne> service, int id)
        {
            InitializeComponent();
            _service = service;
            ToDateTimePicker.Enabled = false;
            FromDateTimePicker.Enabled = false;
            NumberTextBox.Enabled = false;
            FillFields(id);
        }

        private void FillFields(int id)
        {
            var report = _service.Get("reports", id);
            ToDateTimePicker.Value = report.DateEnd.ToDateTime(TimeOnly.MinValue);
            FromDateTimePicker.Value = report.DateStart.ToDateTime(TimeOnly.MinValue);
            NumberTextBox.Text = report.Number.ToString();
            ContentDataGridView.DataSource = report.ReportContent;
        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();
    }
}
