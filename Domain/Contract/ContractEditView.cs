using ModelLibrary.Model.Contract;
using ModelLibrary.Model.Etc;
using ModelLibrary.Model.Organization;
using PetsClient.Etc;
using PetsClient.Services;

namespace PetsClient.Contract
{
    public partial class ContractEditView : Form, IView
    {
        public ContractEdit ContractEdit { get; set; } = new ContractEdit();
        public List<ContractContentEdit> ContractContentEdit { get; set; } = new List<ContractContentEdit>();
        private APIServiceModel<ContractViewList, ContractEdit, ContractViewOne> _service;
        private int _id;
        private State _state = State.Create;
        public List<FileBaseView> Files { get; set; } = new List<FileBaseView>();
        private int _currentFile = 0;

        public ContractEditView()
        {
            _service = new APIServiceModel<ContractViewList, ContractEdit, ContractViewOne>();
            InitializeComponent();
            FillOrganizations();
            FillLocalities();
        }
        public ContractEditView(State state, int id)
        {
            _service = new APIServiceModel<ContractViewList, ContractEdit, ContractViewOne>();
            InitializeComponent();
            _state = state;
            if (_state == State.Read)
                ChangeEnable();
            PrevScanButton.Enabled = false;
            NextScanButton.Enabled = false;
            _id = id;
            FillOrganizations();
            FillFields();
        }

        private void FillOrganizations()
        {
            var organizations = APIServiceOne.GetAllFromPage<OrganizationViewList>("organizations");

            ClientComboBox.DataSource = organizations;
            ClientComboBox.DisplayMember = "NameOrganization";
            ClientComboBox.ValueMember = "Id";
            ExecutorComboBox.DataSource = new List<OrganizationViewList>(organizations);
            ExecutorComboBox.DisplayMember = "NameOrganization";
            ExecutorComboBox.ValueMember = "Id";
        }

        private void ChangeEnable()
        {
            NumberTextBox.Enabled = false;
            ClientComboBox.Enabled = false;
            OkButton.Visible = false;
            DateOfConclusionDateTimePicker.Enabled = false;
            DateValidDateTimePicker.Enabled = false;
            ExecutorComboBox.Enabled = false;
            LocalsPricesDataGridView.Enabled = false;
            CancelButton.Text = "Закрыть";
            AddFileButton.Visible = false;
        }

        private bool CheckFilds()
        {
            var dialogRes = DialogResult.No;
            if (string.IsNullOrEmpty(NumberTextBox.Text))
                dialogRes = IView.ShowErrorMessage("Не заполнен номер контракта.");
            else if (DateOfConclusionDateTimePicker.Value > DateValidDateTimePicker.Value)
                dialogRes = IView.ShowErrorMessage("Дата заключения позже даты действия.");
            else if (ExecutorComboBox.SelectedItem == null)
                dialogRes = IView.ShowErrorMessage("Не выбран исполнитель.");
            else if (ClientComboBox.SelectedItem == null)
                dialogRes = IView.ShowErrorMessage("Не выбран заказчик.");
            else if (ClientComboBox.SelectedItem == ExecutorComboBox.SelectedItem)
                dialogRes = IView.ShowErrorMessage("Организации одинаковые.");
            else if (LocalsPricesDataGridView.Rows.Count == 0)
                dialogRes = IView.ShowErrorMessage("Не добавлено содержание контракта.");
            return dialogRes == DialogResult.No;
        }

        private bool CheckGridContent()
        {
            var dialogRes = DialogResult.No;

            foreach (DataGridViewRow row in LocalsPricesDataGridView.Rows)
            {
                var price = row.Cells[1].Value;
                var locality = row.Cells[2].Value;

                if (price == null || price.ToString() == "" || !decimal.TryParse(price.ToString(), out _))
                {
                    dialogRes = IView.ShowErrorMessage("Значение цены указано некорректно.");
                    break;
                }
                else if (locality == null || locality.ToString() == "")
                {
                    dialogRes = IView.ShowErrorMessage("Населенный пункт не указан.");
                    break;
                }
            }
            return dialogRes == DialogResult.No;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CheckFilds() && CheckGridContent())
            {
                ContractEdit.Number = NumberTextBox.Text;
                ContractEdit.ExecutorId = ((OrganizationViewList)ExecutorComboBox.SelectedItem).Id;
                ContractEdit.ClientId = ((OrganizationViewList)ClientComboBox.SelectedItem).Id;
                this.ContractEdit.DateOfConclusion = DateOnly.Parse(DateOfConclusionDateTimePicker.Value.ToShortDateString());
                ContractEdit.DateValid = DateOnly.Parse(DateValidDateTimePicker.Value.ToShortDateString());

                ContractEdit.ContractContent = new List<ContractContentEdit>();
                for (int i = 0; i < LocalsPricesDataGridView.RowCount; i++)
                {
                    var row = LocalsPricesDataGridView.Rows[i];
                    var id = row.Cells[0].Value != null ? (int)row.Cells[0].Value : 0;
                    ContractEdit.ContractContent.Add(new ContractContentEdit(id, decimal.Parse(row.Cells[1].Value.ToString()), (int)row.Cells[2].Value, _id));
                }
                if (!RequestIsSuccess()) return;
                WorkWithFiles();
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void WorkWithFiles()
        {
            foreach (var file in Files)
            {
                if (file.IsDelete && file.Id != 0)
                    APIServiceOne.DeleteFile("contract-photo", file.Id);
                if (file.Id == 0 && !file.IsDelete)
                    APIServiceOne.UploadFile("contract-photo", file.File, _id);
            }
        }

        private bool RequestIsSuccess()
        {
            var messages = default(string);
            if (_state == State.Create) messages = _service.Post("contracts", ContractEdit);
            else if (_state == State.Update) messages = _service.Put("contracts", _id, ContractEdit);
            if (!int.TryParse(messages, out int id) && !String.IsNullOrEmpty(messages))
            {
                IView.ShowErrorMessage(messages);
                return false;
            }
            else if (_state == State.Create)
            {
                _id = id;
            }
            return true;
        }

        private void FillFields()
        {
            FillLocalities();

            var contract = _service.Get("contracts", _id);
            NumberTextBox.Text = contract.Number;
            DateOfConclusionDateTimePicker.Value = DateTime.Parse(contract.DateOfConclusion.ToString());
            DateValidDateTimePicker.Value = DateTime.Parse(contract.DateValid.ToString());
            var orgs = (List<OrganizationViewList>)ExecutorComboBox.DataSource;
            ExecutorComboBox.SelectedItem = orgs.Find(o => o.Id == contract.Executor.Id);
            ClientComboBox.SelectedItem = orgs.Find(o => o.Id == contract.Client.Id);

            var cc = contract.ContractContent;
            for (var i = 0; i < cc.Count; i++)
            {
                LocalsPricesDataGridView.Rows.Add(cc[i].Id, cc[i].Price, cc[i].Locality.Id);
            }

            Files = APIServiceOne.GetFiles("contract-photo", contract.Id);
            ChangeScan();

        }

        private void FillLocalities()
        {
            var localities = APIServiceOne.GetAll<LocalityView>("localities");
            LocalityDataGridViewComboBoxColumn.DataSource = localities;
            LocalityDataGridViewComboBoxColumn.ValueMember = "Id";
            LocalityDataGridViewComboBoxColumn.DisplayMember = "Name";
        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();

        private void LocalsPricesDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = LocalsPricesDataGridView.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    LocalsPricesDataGridView.ClearSelection();
                    LocalsPricesDataGridView.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = LocalsPricesDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (LocalsPricesDataGridView.Rows.Count > 1)
                LocalsPricesDataGridView.Rows.Remove(LocalsPricesDataGridView.Rows[selectedRow]);
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Files|*.jpg;*.jpeg;*.png;";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var file = File.ReadAllBytes(openFileDialog1.FileName);
                Files.Add(new FileBaseView
                {
                    File = file
                });
                _currentFile = Files.Count - 1;
                if (_currentFile == 0)
                {
                    PrevScanButton.Enabled = false;
                    NextScanButton.Enabled = false;
                }
                else
                {
                    PrevScanButton.Enabled = true;
                    NextScanButton.Enabled = false;
                }

                ChangeScan();
            }
        }
        private void PrevScanButton_Click(object sender, EventArgs e)
        {
            if (_currentFile > 0)
            {
                do
                {
                    _currentFile--;
                }
                while (_currentFile > 0 && Files[_currentFile].IsDelete);

                PrevScanButton.Enabled = _currentFile == 0 ? false : true;
                NextScanButton.Enabled = true;
                ChangeScan();
            }
        }

        private void ChangeScan()
        {
            if (Files.Count > 0 && _currentFile < Files.Count && !Files[_currentFile].IsDelete)
            {
                using var ms = new MemoryStream(Files[_currentFile].File);
                var image = Image.FromStream(ms);
                var bitmap = new Bitmap(image);
                var coef = (int)((double)bitmap.Size.Width / bitmap.Size.Height * 10);
                var i = new Bitmap(bitmap, new Size(ScanPictureBox.Height * coef / 10, ScanPictureBox.Width));
                ScanPictureBox.Image = i;
            }
        }

        private void NextScanButton_Click(object sender, EventArgs e)
        {
            if (_currentFile < Files.Count - 1)
            {
                do
                {
                    _currentFile++;
                }
                while (_currentFile < Files.Count - 1 && Files[_currentFile].IsDelete);
                NextScanButton.Enabled = _currentFile == Files.Count - 1 ? false : true;
                PrevScanButton.Enabled = true;
                ChangeScan();
            }
        }

        private void ScanPictureBox_DoubleClick(object sender, EventArgs e)
        {
            //new ScanView(new Bitmap(_scans[_currentScan])).ShowDialog();
        }

        private void DeleteImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Files.Count > 0)
            {
                Files[_currentFile].IsDelete = true;
                ScanPictureBox.Image = null;
                if (Files.Count == 0)
                {
                    _currentFile = 0;
                }
                else
                {
                    _currentFile = _currentFile == 0 ? 0 : --_currentFile;
                }
                ChangeScan();
            }
            else
            {
                ScanPictureBox.Image = null;
            }
        }

        private void AddContentButton_Click(object sender, EventArgs e)
        {
            if (CheckGridContent())
                LocalsPricesDataGridView.Rows.Add();
        }
    }
}
