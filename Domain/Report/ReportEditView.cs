using ModelLibrary.Model.Report;
using PetsClient.Etc;
using PetsClient.Services;

namespace PetsClient.Domain.Report
{
    public partial class ReportEditView : Form, IView
    {
        private readonly APIServiceModel<ReportViewList, ReportViewList, ReportViewOne> _service = new();
        private readonly int _id;
        private ReportViewOne _report;
        private ReportStatusView? _oldStatus;

        public ReportEditView(int id)
        {
            InitializeComponent();
            ExitButton.Left = (ClientSize.Width - ExitButton.Width) / 2;
            ToDateTimePicker.Enabled = false;
            FromDateTimePicker.Enabled = false;
            NumberTextBox.Enabled = false;
            ReportStatusComboBox.Enabled = false;
            OkButton.Visible = false;
            ContentDataGridView.AllowUserToAddRows = false;
            ContentDataGridView.AllowUserToDeleteRows = false;
            ContentDataGridView.ReadOnly = true;
            _id = id;
            FillStatuses();
            FillFields();
        }

        public ReportEditView(int id, State update)
        {
            InitializeComponent();
            _id = id;
            ContentDataGridView.AllowUserToAddRows = true;
            FillStatuses();
            FillFields();
        }

        private void FillFields()
        {
            _report = _service.Get("reports", _id);
            _oldStatus = APIServiceOne.Get<ReportStatusView>($"reports/{_report.Id}/actual-status");
            
            ToDateTimePicker.Value = _report.DateEnd.ToDateTime(TimeOnly.MinValue);
            FromDateTimePicker.Value = _report.DateStart.ToDateTime(TimeOnly.MinValue);
            NumberTextBox.Text = _report.Number.ToString();
            ContentDataGridView.DataSource = _report.ReportContent;
            ReportStatusComboBox.SelectedValue = _oldStatus?.Id;

        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();

        private void ExportExcelButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel | *.xlsx",
                DefaultExt = "xlsx",
                FileName = "Отчет"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var byteArray = APIServiceOne.GetFile("reports-excel/" + _id);
                var path = saveFileDialog.FileName;
                File.WriteAllBytes(path, byteArray);
            }
        }

        private void FillStatuses()
        {
            var statuses = APIServiceOne.Get<List<ReportStatusView>>($"reports/{_id}/statuses");
            ReportStatusComboBox.DataSource = statuses;
            ReportStatusComboBox.ValueMember = "Id";
            ReportStatusComboBox.DisplayMember = "StatusName";
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            var newStatus = (ReportStatusView)ReportStatusComboBox.SelectedItem;
            if(_oldStatus == null || newStatus.Id != _oldStatus.Id)
            {
                var message = APIServiceOne.Post($"reports/{_report.Id}/statuses/{newStatus.Id}");
                if(String.IsNullOrEmpty(message))
                {
                    MessageBox.Show("Статус изменен");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                    MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Статус остался без изменения");
            }
        }
    }
}
