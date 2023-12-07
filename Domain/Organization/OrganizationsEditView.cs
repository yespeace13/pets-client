using PetsClient.Services;
using ModelLibrary.Model.Etc;
using ModelLibrary.Model.Organization;
using PetsClient.Etc;
using System.Windows.Forms;

namespace PetsClient.Organization.View
{
    public partial class OrganizationEditView : Form, IView
    {
        public OrganizationEdit? OrganizationEdit { get; set; }
        private OrganizationViewList? _viewUpdate;

        public OrganizationEditView(OrganizationViewList view, State status)
        {
            InitializeComponent();
            _viewUpdate = view;
            if (status == State.Read)
                ChangeEnable();
            FillFields();
        }

        public OrganizationEditView()
        {
            InitializeComponent();
            FillFields();
        }

        private void ChangeEnable()
        {
            CancelButton.Left = (ClientSize.Width - CancelButton.Width) / 2;
            NameOrganizationTextBox.Enabled = false;
            INNTextBox.Enabled = false;
            KPPTextBox.Enabled = false;
            AddressTextBox.Enabled = false;
            TypeOrganizationComboBox.Enabled = false;
            LegalTypeComboBox.Enabled = false;
            LocalityComboBox.Enabled = false;
            PhoneTextBox.Enabled = false;
            EmailTextBox.Enabled = false;
            OkButton.Visible = false;
            CancelButton.Text = "Закрыть";
        }

        private bool CheckFilds()
        {
            var dialogRes = DialogResult.No;
            if (string.IsNullOrEmpty(NameOrganizationTextBox.Text))
                dialogRes = IView.ShowErrorMessage("Не заполнено название.");
            else if (string.IsNullOrEmpty(INNTextBox.Text))
                dialogRes = IView.ShowErrorMessage("Не заполнен ИНН.");
            else if (string.IsNullOrEmpty(AddressTextBox.Text))
                dialogRes = IView.ShowErrorMessage("Не заполнен адрес.");
            else if (TypeOrganizationComboBox.SelectedIndex == -1)
                dialogRes = IView.ShowErrorMessage("Не выбран тип организации.");
            else if (LegalTypeComboBox.SelectedIndex == -1)
                dialogRes = IView.ShowErrorMessage("Не выбран вид организации.");
            else if (LocalityComboBox.SelectedIndex == -1)
                dialogRes = IView.ShowErrorMessage("Не выбран муниципалитет.");
            else if (string.IsNullOrEmpty(PhoneTextBox.Text))
                dialogRes = IView.ShowErrorMessage("Не заполнен телефон.");
            else if (string.IsNullOrEmpty(EmailTextBox.Text))
                dialogRes = IView.ShowErrorMessage("Не заполнена почта.");
            return dialogRes == DialogResult.No;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CheckFilds())
            {
                OrganizationEdit = new OrganizationEdit(
                    NameOrganizationTextBox.Text,
                    INNTextBox.Text,
                    KPPTextBox.Text,
                    AddressTextBox.Text,
                    ((TypeOrganizationView)TypeOrganizationComboBox.SelectedItem).Id,
                    ((LegalTypeView)LegalTypeComboBox.SelectedItem).Id,
                    ((LocalityView)LocalityComboBox.SelectedItem).Id,
                    PhoneTextBox.Text,
                    EmailTextBox.Text);
                Close();
            }
        }

        private void FillFields()
        {
            var service = new APIServiceModel<LocalityView, OrganizationEdit, OrganizationEdit>();

            var typeOrg = APIServiceOne.GetAll<TypeOrganizationView>("typeorganization");

            var legalType = APIServiceOne.GetAll<LegalTypeView>("legaltype");

            var localitys = APIServiceOne.GetAll<LocalityView>("localities");

            TypeOrganizationComboBox.DataSource = typeOrg;
            TypeOrganizationComboBox.DisplayMember = "Name";
            TypeOrganizationComboBox.ValueMember = "Id";

            LegalTypeComboBox.DataSource = legalType;
            LegalTypeComboBox.DisplayMember = "Name";
            LegalTypeComboBox.ValueMember = "Id";

            LocalityComboBox.DataSource = localitys;
            LocalityComboBox.DisplayMember = "Name";
            LocalityComboBox.ValueMember = "Id";

            if (_viewUpdate != null)
            {
                NameOrganizationTextBox.Text = _viewUpdate.NameOrganization;
                INNTextBox.Text = _viewUpdate.INN;
                KPPTextBox.Text = _viewUpdate.KPP;
                AddressTextBox.Text = _viewUpdate.Address;
                TypeOrganizationComboBox.SelectedItem = typeOrg.Find(t => t.Name == _viewUpdate.TypeOrganization);
                LegalTypeComboBox.SelectedItem = legalType.Find(t => t.Name == _viewUpdate.LegalType);
                LocalityComboBox.SelectedItem = localitys.Find(l => l.Name == _viewUpdate.Locality);
                PhoneTextBox.Text = _viewUpdate.Phone;
                EmailTextBox.Text = _viewUpdate.Email;
            }

        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
