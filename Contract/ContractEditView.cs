using ModelLibrary.Model.Contract;
using ModelLibrary.Model.Etc;
using ModelLibrary.Model.Organization;
using PetsClient.Etc;
using PetsClient.Services;

namespace PetsClient.Contract
{
    public partial class ContractEditView : Form
    {
        public ContractEdit? ContractEdit { get; set; }
        private APIServiceConnection<ContractViewList, ContractEdit, ContractViewOne> _service;
        private int _id;

        public ContractEditView()
        {
            _service = new APIServiceConnection<ContractViewList, ContractEdit, ContractViewOne>();
            this.ContractEdit = new ContractEdit();
            InitializeComponent();
            FillOrganizations();
        }
        public ContractEditView(State state, int id)
        {
            _service = new APIServiceConnection<ContractViewList, ContractEdit, ContractViewOne>();
            InitializeComponent();
            if (state == State.Read)
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
            AddLocalPriceButton.Visible = false;
            AddFileButton.Visible = false;
        }

        private bool CheckFilds()
        {
            var dialogRes = DialogResult.No;
            if (string.IsNullOrEmpty(NumberTextBox.Text))
                dialogRes = ShowErrorMessage("Не заполнен номер контракта.");
            else if (DateOfConclusionDateTimePicker.Value > DateValidDateTimePicker.Value)
                dialogRes = ShowErrorMessage("Дата заключения позже даты действия");
            else if (ExecutorComboBox.SelectedItem == null)
                dialogRes = ShowErrorMessage("Не выбран исполнитель");
            else if (ClientComboBox.SelectedItem == null)
                dialogRes = ShowErrorMessage("Не выбран заказчик");
            else if (LocalsPricesDataGridView.Rows.Count == 0)
                dialogRes = ShowErrorMessage("Не созданы муниципальные районы");
            else if (ClientComboBox.SelectedItem == ExecutorComboBox.SelectedItem)
                dialogRes = ShowErrorMessage("Организации одинаковые");
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
                foreach (var row in LocalsPricesDataGridView.Rows)
                {
                    this.ContractEdit.ContractContent.Add(new ContractContentEdit());
                }
                Close();
            }
        }

        private void FillFields()
        {
            this.ContractEdit = new ContractEdit();
            var contract = _service.Get("contracts", _id);
            NumberTextBox.Text = contract.Number;
            DateOfConclusionDateTimePicker.Value = contract.DateOfConclusion;
            DateValidDateTimePicker.Value = contract.DateValid;
            var orgs = (List<OrganizationViewList>)ExecutorComboBox.DataSource;
            ExecutorComboBox.SelectedItem = orgs.Find(o => o.Id == contract.Executor.Id);
            ClientComboBox.SelectedItem = orgs.Find(o => o.Id == contract.Client.Id);

            LocalsPricesDataGridView.DataSource = contract.ContractContents.Select(c => new { c.Id, c.Price, c.Locality.Name }).ToList();

            LocalsPricesDataGridView.DataSource = contract.ContractContents;
            LocalsPricesDataGridView.Columns[0].HeaderText = "Идентификатор";
            LocalsPricesDataGridView.Columns[1].HeaderText = "Цена";
            LocalsPricesDataGridView.Columns[2].HeaderText = "Населенный пункт";


            //localityDataGridViewTextBoxColumn.
            //_currentScan = 0;
            //if (_scans.Count > 0)
            //    ChangeScan();
            //else
            //    NextScanButton.Enabled = false;

        }

        private void CancelButton_Click(object sender, EventArgs e) => this.Close();

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

        private void PrevScanButton_Click(object sender, EventArgs e)
        {
            //if(_currentScan > 0)
            //{
            //    _currentScan--;
            //    PrevScanButton.Enabled = _currentScan == 0 ? false : true;
            //    NextScanButton.Enabled = true;
            //    ChangeScan();
            //}
        }

        private void ChangeScan()
        {
            //if (File.Exists(_scans[_currentScan]))
            //{
            //    var bitmap = new Bitmap(_scans[_currentScan]);
            //    var coef = (int)((double)bitmap.Size.Width / bitmap.Size.Height * 10);
            //    var i = new Bitmap(bitmap, new Size(ScanPictureBox.Height * coef / 10, ScanPictureBox.Width));
            //    ScanPictureBox.Image = i;
            //}
            //else
            //{
            //    ShowErrorMessage("Не все файлы были загружены.");
            //}
        }

        private void NextScanButton_Click(object sender, EventArgs e)
        {
            //if(_currentScan < _scans.Count-1)
            //{
            //    _currentScan++;
            //    NextScanButton.Enabled = _currentScan == _scans.Count -1 ? false : true;
            //    PrevScanButton.Enabled = true;
            //    ChangeScan();
            //}
        }

        private void ScanPictureBox_DoubleClick(object sender, EventArgs e)
        {
            //new ScanView(new Bitmap(_scans[_currentScan])).ShowDialog();
        }

        private void DeleteImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(_scans.Count > 0)
            //{
            //    _scans.RemoveAt(_currentScan);
            //    if(_scans.Count == 0)
            //    {
            //        _currentScan = 0;
            //        ScanPictureBox.Image = null;
            //    }
            //    else
            //    {
            //        _currentScan = _currentScan == 0 ? 0 : --_currentScan;
            //        ChangeScan();
            //    }
            //}
            //else
            //{
            //    ScanPictureBox.Image = null;
            //}
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = LocalsPricesDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            var localForm = new ContractContentEditView();
            if (localForm.ShowDialog() == DialogResult.OK)
            {
                //_localprice[selectedRow][0] = localForm.Locality;
                //_localprice[selectedRow][1] = localForm.Price.ToString();
                //ShowLocals();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = LocalsPricesDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            LocalsPricesDataGridView.Rows.Remove(LocalsPricesDataGridView.Rows[selectedRow]);
        }

        private void AddLocalPriceButton_Click(object sender, EventArgs e)
        {
            var localForm = new ContractContentEditView();
            if (localForm.ShowDialog() == DialogResult.OK)
            {
                ContractEdit.ContractContent.Add(localForm.contentEdit);
            };
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            //if(openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    _scans.Add(openFileDialog1.FileName);
            //    _currentScan = _scans.Count - 1;
            //    if (_currentScan == 0)
            //    {
            //        PrevScanButton.Enabled = false;
            //        NextScanButton.Enabled = false;
            //    }
            //    else
            //    {
            //        PrevScanButton.Enabled = true;
            //        NextScanButton.Enabled = false;
            //    }
            //    ChangeScan();
            //}
        }

        private void LocalsPricesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
