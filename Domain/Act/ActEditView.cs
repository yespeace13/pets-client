using ModelLibrary.Model.Act;
using ModelLibrary.Model.Animal;
using ModelLibrary.Model.Contract;
using ModelLibrary.Model.Etc;
using ModelLibrary.Model.Organization;
using PetsClient.Etc;
using PetsClient.Services;

namespace PetsClient.Act;

public partial class ActEditView : Form
{
    public ActEdit ActEdit { get; set; } = new ActEdit();
    public List<ContractContentEdit> ContractContentEdit { get; set; } = new List<ContractContentEdit>();
    private APIServiceConnection<ActViewList, ActEdit, ActViewOne> _service = new APIServiceConnection<ActViewList, ActEdit, ActViewOne>();
    private int _id;
    private List<string> _scans;
    private int _currentScan;
    public ActEditView(State state, int id)
    {
        InitializeComponent();
        PrevScanButton.Enabled = false;
        NextScanButton.Enabled = false;
        FillComboBoxes();
        if (state == State.Read)
            ChangeEnable();
        _id = id;
        FillFields();
    }

    public ActEditView()
    {
        InitializeComponent();
        PrevScanButton.Enabled = false;
        NextScanButton.Enabled = false;
        FillComboBoxes();
        ActEdit.Animal = new List<AnimalEdit>();
        //_scans = new List<string>();
    }

    private void ChangeEnable()
    {
        ContractsComboBox.Enabled = false;
        OrgsComboBox.Enabled = false;
        DateOfCapDateTimePicker.Enabled = false;
        CancelButton.Text = "Закрыть";
        AddAnimalButton.Visible = false;
        AddFileButton.Visible = false;
        OkButton.Visible = false;
    }

    private void FillFields()
    {
        var act = _service.Get("acts", _id);

        var organizations = (List<OrganizationViewList>)OrgsComboBox.DataSource;
        var contracts = (List<ContractViewList>)ContractsComboBox.DataSource;
        var localities = (List<LocalityView>)LocalityComboBox.DataSource;
        OrgsComboBox.SelectedItem = organizations.Find(o => o.Id == act.Executor.Id);
        ContractsComboBox.SelectedItem = contracts.Find(c => c.Id == act.Contract.Id);
        LocalityComboBox.SelectedItem = localities.Find(l => l.Id == act.Locality.Id);

        DateOfCapDateTimePicker.Value = act.DateOfCapture.ToDateTime(TimeOnly.MinValue);
        AnimalsDataGridView.DataSource = act.Animal;
        //ActEdit.Animal = act.Animal.Select(a => new AnimalEdit(,))
        //if (_scans.Count != 0) ChangeScan();
    }

    private void FillComboBoxes()
    {
        var contracts = APIServiceOne.GetAllFromPage<ContractViewList>("contracts");
        var organizations = APIServiceOne.GetAllFromPage<OrganizationViewList>("organizations");
        var localities = APIServiceOne.GetAll<LocalityView>("localities");
        OrgsComboBox.DataSource = organizations;
        OrgsComboBox.ValueMember = "Id";
        OrgsComboBox.DisplayMember = "NameOrganization";

        ContractsComboBox.DataSource = contracts;
        ContractsComboBox.ValueMember = "Id";
        ContractsComboBox.DisplayMember = "Number";

        LocalityComboBox.DataSource = localities;
        LocalityComboBox.ValueMember = "Id";
        LocalityComboBox.DisplayMember = "Name";
    }

    private void PrevScanButton_Click(object sender, EventArgs e)
    {
        if (_currentScan > 0)
        {
            _currentScan--;
            PrevScanButton.Enabled = _currentScan == 0 ? false : true;
            NextScanButton.Enabled = true;
            ChangeScan();
        }
    }

    private void NextScanButton_Click(object sender, EventArgs e)
    {
        if (_currentScan < _scans.Count - 1)
        {
            _currentScan++;
            NextScanButton.Enabled = _currentScan == _scans.Count - 1 ? false : true;
            PrevScanButton.Enabled = true;
            ChangeScan();
        }
    }

    private void AddFileButton_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            _scans.Add(openFileDialog1.FileName);
            _currentScan = _scans.Count - 1;
            if (_currentScan == 0)
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

    private void ChangeScan()
    {
        if (File.Exists(_scans[_currentScan]))
        {
            var bitmap = new Bitmap(_scans[_currentScan]);
            var coef = (int)((double)bitmap.Size.Width / bitmap.Size.Height * 10);
            var i = new Bitmap(bitmap, new Size(ScanPictureBox.Height * coef / 10, ScanPictureBox.Width));
            ScanPictureBox.Image = i;
        }
        else
        {
            ShowErrorMessage("Не все файлы были загружены.");
        }
    }
    private static DialogResult ShowErrorMessage(string error)
    {
        return MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void CancelButton_Click(object sender, EventArgs e) => Close();

    private void AnimalsDataGridView_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            var hti = AnimalsDataGridView.HitTest(e.X, e.Y);
            if (hti.RowIndex != -1)
            {
                AnimalsDataGridView.ClearSelection();
                AnimalsDataGridView.Rows[hti.RowIndex].Selected = true;
                DataContextMenuStrip.Show(AnimalsDataGridView, e.Location);
            }
        }
    }

    private void AddAnimalButton_Click(object sender, EventArgs e)
    {
        var animalView = new AnimalEditView();
        if (animalView.ShowDialog() == DialogResult.OK)
        {

        }
    }

    private void AnimalsDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            var hti = AnimalsDataGridView.HitTest(e.X, e.Y);
            if (hti.RowIndex != -1)
            {
                var selectedRow = AnimalsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                var id = int.Parse(AnimalsDataGridView.Rows[AnimalsDataGridView.RowCount - 1].Cells[0].Value.ToString());
                new AnimalEditView(State.Read, id).ShowDialog();
            }
        }
    }

    private void ChangeAnimalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var selectedRow = AnimalsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
        var id = int.Parse(AnimalsDataGridView.Rows[AnimalsDataGridView.RowCount - 1].Cells[0].Value.ToString());
        //var animal = _animals.Keys.Where(k => int.Parse(k[0]) == id).FirstOrDefault();
        //var animalView = new AnimalView(_controller, State.Update, animal, _animals[animal]);
        //if (animalView.ShowDialog() == DialogResult.OK)
        //{
        //    _animals.Remove(animal);
        //    AddAnimal(animalView, id);
        //    ShowAnimals();
        //}
    }

    private void DeleteAnimalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //var selectedRow = AnimalsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
        //var id = int.Parse(AnimalsDataGridView.Rows[AnimalsDataGridView.RowCount - 1].Cells[0].Value.ToString());
        //var animal = _animals.Keys.Where(k => int.Parse(k[0]) == id).FirstOrDefault();
        //_animals.Remove(animal);
        //ShowAnimals();
    }

    private void DelScanToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (_scans.Count > 0)
        {
            _scans.RemoveAt(_currentScan);
            if (_scans.Count == 0)
            {
                _currentScan = 0;
                ScanPictureBox.Image = null;
            }
            else
            {
                _currentScan = _currentScan == 0 ? 0 : --_currentScan;
                ChangeScan();
            }
        }
        else
        {
            ScanPictureBox.Image = null;
        }
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
        if (ChectFields())
        {
            var act = new string[] {
                        ContractsComboBox.SelectedItem.ToString(),
                        OrgsComboBox.SelectedItem.ToString(),
                        DateOfCapDateTimePicker.Value.ToString()
                    };
            Close();
        }
    }

    private bool ChectFields()
    {
        var dialogRes = DialogResult.No;
        if (ContractsComboBox.SelectedItem == null)
            dialogRes = ShowErrorMessage("Не выбран кнотракт.");
        else if (OrgsComboBox.SelectedItem == null)
            dialogRes = ShowErrorMessage("Не выбрана организация.");
        else if (AnimalsDataGridView.RowCount == 0)
            dialogRes = ShowErrorMessage("Не добавлены животные.");
        return dialogRes == DialogResult.No;
    }
}

