using PetsClient.Act;
using PetsClient.Contract;
using PetsClient.Organization.View;

namespace PetsClient
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            //OrgsButton.Enabled = UserSession.User.Privilege.Organizations.Item1 != Model.Restrictions.None;
            //ContractsButton.Enabled = UserSession.User.Privilege.Contracts.Item1 != Model.Restrictions.None;
            //ActsButton.Enabled = UserSession.User.Privilege.Acts.Item1 != Model.Restrictions.None;
        }

        private void OrgsButton_Click(object sender, EventArgs e)
        {
            new OrganizationView().ShowDialog();
            
        }

        private void ContractsButton_Click(object sender, EventArgs e)
        {
            new Contractview().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new PlanView().ShowDialog();
        }
        private void ActsButton_Click(object sender, EventArgs e)
        {
            new Actview().ShowDialog();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            //new ReportView().ShowDialog();
        }
    }
}
