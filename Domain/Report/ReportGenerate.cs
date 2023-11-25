namespace PetsClient.Domain.Report
{
    public partial class ReportGenerate : Form
    {
        public ReportGenerate()
        {
            InitializeComponent();
        }

        public DateOnly From { get; internal set; }
        public DateOnly To { get; internal set; }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var from = FromDateTimePicker.Value;
            var to = ToDateTimePicker.Value;
            if (from < to)
            {
                From = DateOnly.Parse(from.ToShortDateString());
                To = DateOnly.Parse(to.ToShortDateString());
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
