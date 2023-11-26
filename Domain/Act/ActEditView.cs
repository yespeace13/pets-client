using ModelLibrary.Model.Act;
using ModelLibrary.Model.Animal;
using ModelLibrary.Model.Contract;
using ModelLibrary.Model.Etc;
using ModelLibrary.Model.Organization;
using PetsClient.Etc;
using PetsClient.Services;
using System.Diagnostics.Contracts;

namespace PetsClient.Act;

public partial class ActEditView : Form, IView
{
    public ActEdit Act { get; set; } = new ActEdit();
    private APIServiceConnection<ActViewList, ActEdit, ActViewOne> _service = new APIServiceConnection<ActViewList, ActEdit, ActViewOne>();
    private int _id;
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
        Act.Animal = new List<AnimalEdit>();
        //_scans = new List<string>();
    }

    private void ChangeEnable()
    {
        ContractsComboBox.Enabled = false;
        ExecutorComboBox.Enabled = false;
        DateOfCapDateTimePicker.Enabled = false;
        CancelButton.Text = "Закрыть";
        AddAnimalButton.Visible = false;
        AddFileButton.Visible = false;
        OkButton.Visible = false;
        LocalityComboBox.Enabled = false;
        DataContextMenuStrip.Enabled = false;

    }

    private void FillFields()
    {
        var act = _service.Get("acts", _id);

        var organizations = (List<OrganizationViewList>)ExecutorComboBox.DataSource;
        var contracts = (List<ContractViewList>)ContractsComboBox.DataSource;
        var localities = (List<LocalityView>)LocalityComboBox.DataSource;
        ExecutorComboBox.SelectedItem = organizations.Find(o => o.Id == act.Executor.Id);
        ContractsComboBox.SelectedItem = contracts.Find(c => c.Id == act.Contract.Id);
        LocalityComboBox.SelectedItem = localities.Find(l => l.Id == act.Locality.Id);

        DateOfCapDateTimePicker.Value = act.DateOfCapture.ToDateTime(TimeOnly.MinValue);
        AnimalsDataGridView.DataSource = act.Animal;
        Act.Animal = new List<AnimalEdit>();
        //if (_scans.Count != 0) ChangeScan();
    }

    private void FillComboBoxes()
    {
        var contracts = APIServiceOne.GetAllFromPage<ContractViewList>("contracts");
        var organizations = APIServiceOne.GetAllFromPage<OrganizationViewList>("organizations");
        //var localities = APIServiceOne.GetAll<LocalityView>("localities");
        ExecutorComboBox.DataSource = organizations;
        ExecutorComboBox.ValueMember = "Id";
        ExecutorComboBox.DisplayMember = "NameOrganization";

        ContractsComboBox.DataSource = contracts;
        ContractsComboBox.ValueMember = "Id";
        ContractsComboBox.DisplayMember = "Number";

        //LocalityComboBox.DataSource = localities;
        //LocalityComboBox.ValueMember = "Id";
        //LocalityComboBox.DisplayMember = "Name";
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

    private void AnimalsDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            var hti = AnimalsDataGridView.HitTest(e.X, e.Y);
            if (hti.RowIndex != -1)
            {
                var selectedRow = AnimalsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                var animal = (AnimalViewList)AnimalsDataGridView.Rows[selectedRow].DataBoundItem;
                new AnimalEditView(State.Read, animal).ShowDialog();
            }
        }
    }
    private void AddAnimalButton_Click(object sender, EventArgs e)
    {
        var animalView = new AnimalEditView();
        if (animalView.ShowDialog() == DialogResult.OK)
        {
            var animals = (List<AnimalViewList>)AnimalsDataGridView.DataSource;
            if (animals == null)
                animals = new List<AnimalViewList>();
            animals.Add(animalView.Animal);
            AnimalsDataGridView.DataSource = null;
            AnimalsDataGridView.DataSource = animals;
        }
    }

    private void ChangeAnimalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var selectedRow = AnimalsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
        var animal = (AnimalViewList)AnimalsDataGridView.Rows[selectedRow].DataBoundItem;
        var animalView = new AnimalEditView(State.Update, animal);
        if (animalView.ShowDialog() == DialogResult.OK)
        {
            var animals = (List<AnimalViewList>)AnimalsDataGridView.DataSource;
            var oldAnimal = animals.First(a => a.Id == animalView.Animal.Id);
            oldAnimal = animalView.Animal;
            AnimalsDataGridView.DataSource = null;
            AnimalsDataGridView.DataSource = animals;
        }
    }

    private void DeleteAnimalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var selectedRow = AnimalsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
        var animal = (AnimalViewList)AnimalsDataGridView.Rows[selectedRow].DataBoundItem;
        var animals = (List<AnimalViewList>)AnimalsDataGridView.DataSource;
        animals.Remove(animal);
        AnimalsDataGridView.DataSource = null;
        AnimalsDataGridView.DataSource = animals;
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
        if (ChectFields())
        {
            Act.ExecutorId = ((OrganizationViewList)ExecutorComboBox.SelectedItem).Id;
            Act.ContractId = ((ContractViewList)ContractsComboBox.SelectedItem).Id;
            Act.LocalityId = ((LocalityView)LocalityComboBox.SelectedItem).Id;
            Act.DateOfCapture = DateOnly.Parse(DateOfCapDateTimePicker.Value.ToShortDateString());
            for (int i = 0; i < AnimalsDataGridView.RowCount; i++)
            {
                var animal = (AnimalViewList)AnimalsDataGridView.Rows[i].DataBoundItem;
                Act.Animal.Add(new AnimalEdit
                {
                    Id = animal.Id,
                    Category = animal.Category,
                    Sex = animal.Sex == "Самка" ? true : false,
                    Breed = animal.Breed,
                    Size = animal.Size,
                    Wool = animal.Wool,
                    Color = animal.Color,
                    Ears = animal.Ears,
                    Tail = animal.Tail,
                    SpecialSigns = animal.SpecialSigns,
                    IdentificationLabel = animal.IdentificationLabel,
                    ChipNumber = animal.ChipNumber
                });
            }
            Close();
        }
    }

    private bool ChectFields()
    {
        var dialogRes = DialogResult.No;
        if (ContractsComboBox.SelectedItem == null)
            dialogRes = IView.ShowErrorMessage("Не выбран контракт.");
        else if (ExecutorComboBox.SelectedItem == null)
            dialogRes = IView.ShowErrorMessage("Не выбрана организация.");
        else if (LocalityComboBox.SelectedItem == null)
            dialogRes = IView.ShowErrorMessage("Не выбран населенный пункт.");
        else if (AnimalsDataGridView.RowCount == 0)
            dialogRes = IView.ShowErrorMessage("Не добавлены животные.");
        return dialogRes == DialogResult.No;
    }

    private void AnimalsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
        AnimalsDataGridView.Columns[0].Visible = false;
    }

    private void DelScanToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //if (_scans.Count > 0)
        //{
        //    _scans.RemoveAt(_currentScan);
        //    if (_scans.Count == 0)
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

    private void PrevScanButton_Click(object sender, EventArgs e)
    {
        //if (_currentScan > 0)
        //{
        //    _currentScan--;
        //    PrevScanButton.Enabled = _currentScan == 0 ? false : true;
        //    NextScanButton.Enabled = true;
        //    ChangeScan();
        //}
    }

    private void NextScanButton_Click(object sender, EventArgs e)
    {
        //if (_currentScan < _scans.Count - 1)
        //{
        //    _currentScan++;
        //    NextScanButton.Enabled = _currentScan == _scans.Count - 1 ? false : true;
        //    PrevScanButton.Enabled = true;
        //    ChangeScan();
        //}
    }

    private void AddFileButton_Click(object sender, EventArgs e)
    {
        //if (openFileDialog1.ShowDialog() == DialogResult.OK)
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

    private void ContractsComboBox_SelectedValueChanged(object sender, EventArgs e)
    {
        LocalityComboBox.DataSource = null;
        LocalityComboBox.DataSource = APIServiceOne.GetAll<LocalityView>("contract-contents/" + ((ContractViewList)ContractsComboBox.SelectedItem).Id);
        LocalityComboBox.ValueMember = "Id";
        LocalityComboBox.DisplayMember = "Name";
    }
}

