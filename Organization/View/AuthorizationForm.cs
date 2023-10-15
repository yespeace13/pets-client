using PetsClient.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsClient.Organization.View
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AuthorizationService.Authorization(textBox1.Text))
                new OrganizationView().ShowDialog();
            else
            {
                label1.Text = "Не правильный логин";
                label1.ForeColor = Color.Red;
            }
        }
    }
}
