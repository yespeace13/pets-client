using PetsClient.Services;

namespace PetsClient.Authentication
{
    public partial class AuthenticationView : Form
    {
        public bool UserSuccessfullyAuthenticated { get; private set; }
        public AuthenticationView()
        {
            InitializeComponent();
            OkButton.Click += new EventHandler(OkButton_Click);
            label4.Text = "";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            var login = LogTextBox.Text;
            var password = PassTextBox.Text;
            if (AuthorizationService.IsAuthentication(login, password))
            {
                UserSuccessfullyAuthenticated = true;
                Close();
            }
            else
            {
                label4.Text = "Неправильный логин или/и пароль";
                label4.ForeColor = Color.Red;
            }
        }
    }
}
