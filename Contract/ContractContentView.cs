using ModelLibrary.Model.Contract;
using ModelLibrary.Model.Etc;
using PetsClient.Services;

namespace PetsClient.Contract
{
    public partial class ContractContentEditView : Form
    {
        public ContractContentEdit? contentEdit { get; set; }
        public ContractContentEditView(ContractContentView contractContent)
        {
            InitializeComponent();
            FillLocalitys();
            PriceNumericUpDown.Value = contractContent.Price;
            LocalityComboBox.SelectedItem = contractContent.Locality;
        }

        public ContractContentEditView()
        {
            InitializeComponent();
            FillLocalitys();
        }

        private void FillLocalitys()
        {
            var localities = APIServiceOne.GetAll<LocalityView>("localities");
            LocalityComboBox.DataSource = localities;
            LocalityComboBox.ValueMember = "Id";
            LocalityComboBox.DisplayMember = "Name";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (LocalityComboBox.SelectedItem == null)
            {
                MessageBox.Show("Не выбран муниципальный район.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
