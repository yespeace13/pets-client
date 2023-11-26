using PetsClient.Act;
using PetsClient.Authentication;
using PetsClient.Contract;
using PetsClient.Domain.Plan;
using PetsClient.Domain.Report;
using PetsClient.Organization.View;

namespace PetsClient
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            InitPossibilities();
        }

        private void InitPossibilities()
        {
            ActsButton.Enabled = false;
            ContractsButton.Enabled = false;
            OrganizationsButton.Enabled = false;
            CactchScheduleButton.Enabled = false;
            ReportButton.Enabled = false;


            var possibilities = UserData.Possibilities.Where(p => p.Possibility == "Read");

            foreach (var possibility in possibilities)
            {
                if (possibility.Entity == "Act")
                    ActsButton.Enabled = true;
                if (possibility.Entity == "Contract")
                    ContractsButton.Enabled = true;
                if (possibility.Entity == "Organization")
                    OrganizationsButton.Enabled = true;
                if (possibility.Entity == "Schedule")
                    CactchScheduleButton.Enabled = true;
                if (possibility.Entity == "Report")
                    ReportButton.Enabled = true;

            }
        }

        private void OrgsButton_Click(object sender, EventArgs e)
        {
            new OrganizationView().ShowDialog();

        }

        private void ContractsButton_Click(object sender, EventArgs e)
        {
            new Contractview().ShowDialog();
        }

        private void CatchScheduleButton_Click(object sender, EventArgs e)
        {
            new PlanView().ShowDialog();
        }
        private void ActsButton_Click(object sender, EventArgs e)
        {
            new Actview().ShowDialog();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            new ReportView().ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Restart();

        }
    }
}
