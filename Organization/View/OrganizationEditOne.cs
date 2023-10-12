using IS_5.Services;
using ModelLibrary.Model.Etc;
using ModelLibrary.Model.Organization;
using PetsClient.Etc;

namespace IS_5.View
{
    public partial class OrganizationEditOne : Form
    {
        private OrganizationViewList? _viewUpdate;
        private State _state;

        public OrganizationEditOne(OrganizationViewList view, State status)
        {
            InitializeComponent();
            _viewUpdate = view;
            if (status == State.Read)
                ChangeEnable();
            FillFields();
        }

        public OrganizationEditOne()
        {
            InitializeComponent();
            _state = State.Create;
            FillFields();
        }

        private void ChangeEnable()
        {
            NameOrgTextBox.Enabled = false;
            TaxIdenNumTextBox.Enabled = false;
            KPPTextBox.Enabled = false;
            AddressTextBox.Enabled = false;
            TypeOrganizationComboBox.Enabled = false;
            TypeOwnerComboBox.Enabled = false;
            LocalityComboBox.Enabled = false;
            OkButton.Visible = false;
            CancelButton.Text = "Закрыть";
        }

        private bool CheckFilds()
        {
            var dialogRes = DialogResult.No;
            if (string.IsNullOrEmpty(NameOrgTextBox.Text)) 
                dialogRes = ShowErrorMessage("Не заполнено название.");
            else if (string.IsNullOrEmpty(TaxIdenNumTextBox.Text))
                dialogRes = ShowErrorMessage("Не заполнен ИНН.");
            else if (string.IsNullOrEmpty(KPPTextBox.Text))
                dialogRes = ShowErrorMessage("Не заполнен КПП.");
            else if (string.IsNullOrEmpty(AddressTextBox.Text))
                dialogRes = ShowErrorMessage("Не заполнен адрес.");
            else if (TypeOrganizationComboBox.SelectedIndex == -1)
                dialogRes = ShowErrorMessage("Не выбран тип организации.");
            else if (TypeOwnerComboBox.SelectedIndex == -1)
                dialogRes = ShowErrorMessage("Не выбран вид организации.");
            else if (LocalityComboBox.SelectedIndex == -1)
                dialogRes = ShowErrorMessage("Не выбран муниципалитет.");
            return dialogRes == DialogResult.No;
        }

        private static DialogResult ShowErrorMessage(string error)
        {
            return MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CheckFilds())
            {
                //new OrganizationViewCreate(
                //    NameOrgTextBox.Text,
                //    TaxIdenNumTextBox.Text,
                //    KPPTextBox.Text,
                //    AddressTextBox.Text,
                //    ((TypeOrganizationModel)TypeOrganizationComboBox.SelectedItem).Id,
                //    ((LegalTypeModel)TypeOwnerComboBox.SelectedItem).Id,
                //    ((LocalityModel)LocalityComboBox.SelectedItem).Id
                //    );
                //Close();
            }
        }

        private void FillFields()
        {
            var service = new APIServiceConnection<LocalityModel>();
            //service.Get()
            //var typeOrg = _controller.ShowTypesOrganizations();
            //var typeOwnOrg = _controller.ShowTypesOwnerOrganizations();
            //var localitys = _controller.ShowLocalitys();
            //TypeOrganizationComboBox.Items.AddRange(typeOrg);
            //TypeOwnerComboBox.Items.AddRange(typeOwnOrg);
            //LocalityComboBox.Items.AddRange(localitys);
            if (_viewUpdate != null)
            {
                NameOrgTextBox.Text = _viewUpdate.NameOrganization;
                TaxIdenNumTextBox.Text = _viewUpdate.INN;
                KPPTextBox.Text = _viewUpdate.KPP;
                AddressTextBox.Text = _viewUpdate.Address;
                TypeOrganizationComboBox.SelectedItem = _viewUpdate.TypeOrganization;
                TypeOwnerComboBox.SelectedItem = _viewUpdate.LegalType;
                LocalityComboBox.SelectedItem = _viewUpdate.Locality;
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();
        
    }
}
