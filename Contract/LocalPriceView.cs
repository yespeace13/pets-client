namespace PetsClient.Contract
{
    public partial class LocalPriceView : Form
    {
        public string Locality { get; set; }
        public decimal Price { get; set; }
        public LocalPriceView(string name, decimal price)
        {
            InitializeComponent();
            FillLocalitys();
            LocalityComboBox.SelectedItem = name;
            PriceNumericUpDown.Value = price;
            Locality = name;
            Price = price;
        }

        private void FillLocalitys()
        {
        }

        public LocalPriceView()
        {
            InitializeComponent();
            FillLocalitys();
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
                    MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                Locality = LocalityComboBox.SelectedItem.ToString();
                Price = PriceNumericUpDown.Value;
                Close();
            }
        }
    }
}
