using PetsClient.Services;
using ModelLibrary.Model.Etc;
using ModelLibrary.Model.Organization;
using PetsClient.Etc;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace PetsClient.Organization.View;

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

    private void CheckFilds()
    {

        //if (string.IsNullOrEmpty(NameOrganizationTextBox.Text))
        //    dialogRes = IView.ShowErrorMessage("Не заполнено название.");
        //if (string.IsNullOrEmpty(INNTextBox.Text))
        //    dialogRes = IView.ShowErrorMessage("Не заполнен ИНН.");
        //else if (string.IsNullOrEmpty(AddressTextBox.Text))
        //    dialogRes = IView.ShowErrorMessage("Не заполнен адрес.");
        //else if (TypeOrganizationComboBox.SelectedIndex == -1)
        //    dialogRes = IView.ShowErrorMessage("Не выбран тип организации.");
        //else if (LegalTypeComboBox.SelectedIndex == -1)
        //    dialogRes = IView.ShowErrorMessage("Не выбран вид организации.");
        //else if (LocalityComboBox.SelectedIndex == -1)
        //    dialogRes = IView.ShowErrorMessage("Не выбран муниципалитет.");
        //else if (string.IsNullOrEmpty(PhoneTextBox.Text))
        //    dialogRes = IView.ShowErrorMessage("Не заполнен телефон.");
        //else if (string.IsNullOrEmpty(EmailTextBox.Text))
        //    dialogRes = IView.ShowErrorMessage("Не заполнена почта.");
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
        if (ValidateChildren())
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
            DialogResult = DialogResult.OK;
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


    string message = "Поле должно быть заполнено.";

    private void NameOrganizationTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        
        if (string.IsNullOrEmpty(NameOrganizationTextBox.Text))
        {
            e.Cancel = true;
            DataErrorProvider.SetError(NameOrganizationTextBox, message);
        }
        else
            DataErrorProvider.SetError(NameOrganizationTextBox, string.Empty);

        
    }

    private void INNTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrEmpty(INNTextBox.Text))
        {
            e.Cancel = true;
            DataErrorProvider.SetError(INNTextBox, message);

        }
        else
            DataErrorProvider.SetError(INNTextBox, string.Empty);

        
    }

    private void KPPTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrEmpty(KPPTextBox.Text))
        {
            e.Cancel = true;
            DataErrorProvider.SetError(KPPTextBox, message);

        }
        else
            DataErrorProvider.SetError(KPPTextBox, string.Empty);
    }

    private void AddressTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrEmpty(AddressTextBox.Text))
        {
            e.Cancel = true;
            DataErrorProvider.SetError(AddressTextBox, message);

        }
        else
            DataErrorProvider.SetError(AddressTextBox, string.Empty);

        
    }

    private void TypeOrganizationComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (TypeOrganizationComboBox.SelectedIndex == -1)
            DataErrorProvider.SetError(TypeOrganizationComboBox, message);
        else
            DataErrorProvider.SetError(TypeOrganizationComboBox, string.Empty);

        
    }

    private void LegalTypeComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (LegalTypeComboBox.SelectedIndex == -1)
            DataErrorProvider.SetError(LegalTypeComboBox, message);
        else
            DataErrorProvider.SetError(LegalTypeComboBox, string.Empty);

        
    }

    private void LocalityComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (LocalityComboBox.SelectedIndex == -1)
            DataErrorProvider.SetError(LocalityComboBox, message);
        else
            DataErrorProvider.SetError(LocalityComboBox, string.Empty);

       
    }

    private void PhoneTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrEmpty(PhoneTextBox.Text))
        {
            e.Cancel = true;
            DataErrorProvider.SetError(PhoneTextBox, message);

        }
        else
            DataErrorProvider.SetError(PhoneTextBox, string.Empty);
        
    }

    private void EmailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrEmpty(EmailTextBox.Text))
        {
            e.Cancel = true;
            DataErrorProvider.SetError(EmailTextBox, message);
        }
        else
            DataErrorProvider.SetError(EmailTextBox, string.Empty);
    }
}
