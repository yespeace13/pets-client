using ModelLibrary.Model.Act;
using ModelLibrary.Model.Animal;
using ModelLibrary.Model.Contract;
using ModelLibrary.Model.Etc;
using ModelLibrary.Model.Organization;
using PetsClient.Etc;
using PetsClient.Services;

namespace PetsClient.Act;

public partial class ActEditView : Form, IView
{
    public ActEdit Act { get; set; } = new ActEdit();
    private readonly APIServiceModel<ActViewList, ActEdit, ActViewOne> _service = new();
    private readonly int _id;
    public List<FileBaseView> Files { get; set; } = new List<FileBaseView>();
    public List<List<FileBaseView>> AnimalFiles { get; set; } = new List<List<FileBaseView>>();
    private int _currentFile = 0;
    public ActEditView(State state, int id)
    {
        InitializeComponent();
        PrevScanButton.Enabled = false;
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
        FillComboBoxes();
        Act.Animal = new List<AnimalEdit>();
    }

    private void ChangeEnable()
    {
        ContractsComboBox.Enabled = false;
        ExecutorComboBox.Enabled = false;
        DateOfCapDateTimePicker.Enabled = false;
        ExitButton.Text = "Закрыть";
        AddAnimalButton.Visible = false;
        AddFileButton.Visible = false;
        OkButton.Visible = false;
        LocalityComboBox.Enabled = false;
        DataContextMenuStrip.Enabled = false;

    }

    private void FillFields()
    {
        var act = _service.Get("acts", _id);
        Files = APIServiceOne.GetFiles("act-photo", act.Id);
        ChangeScan();

        var organizations = (List<OrganizationViewList>)ExecutorComboBox.DataSource;
        var contracts = (List<ContractViewList>)ContractsComboBox.DataSource;
        var localities = (List<LocalityView>)LocalityComboBox.DataSource;

        ExecutorComboBox.SelectedItem = organizations.Find(o => o.Id == act.Executor.Id);
        ContractsComboBox.SelectedItem = contracts.Find(c => c.Id == act.Contract.Id);
        LocalityComboBox.SelectedItem = localities.Find(l => l.Id == act.Locality.Id);

        DateOfCapDateTimePicker.Value = act.DateOfCapture.ToDateTime(TimeOnly.MinValue);
        AnimalsDataGridView.DataSource = act.Animal;
        Act.Animal = new List<AnimalEdit>();

    }

    private void FillComboBoxes()
    {
        var contracts = APIServiceOne.GetAllFromPage<ContractViewList>("contracts");
        var organizations = APIServiceOne.GetAllFromPage<OrganizationViewList>("organizations");

        ExecutorComboBox.DataSource = organizations;
        ExecutorComboBox.ValueMember = "Id";
        ExecutorComboBox.DisplayMember = "NameOrganization";

        ContractsComboBox.DataSource = contracts;
        ContractsComboBox.ValueMember = "Id";
        ContractsComboBox.DisplayMember = "Number";
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
            animals ??= new List<AnimalViewList>();
            animals.Add(animalView.Animal);
            AnimalsDataGridView.DataSource = null;
            AnimalsDataGridView.DataSource = animals;
            AnimalFiles.Add(animalView.Files);
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
            AnimalFiles.Add(animalView.Files);
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
                    Sex = animal.Sex == "Самка",
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
            DialogResult = DialogResult.OK;
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
                _currentFile = _currentFile  == 0 ? 0 : --_currentFile;
            }
            ChangeScan();
        }
        else
        {
            ScanPictureBox.Image = null;
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

            PrevScanButton.Enabled = _currentFile != 0;
            NextScanButton.Enabled = true;
            ChangeScan();
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
            NextScanButton.Enabled = _currentFile != Files.Count - 1;
            PrevScanButton.Enabled = true;
            ChangeScan();
        }
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

    private void ContractsComboBox_SelectedValueChanged(object sender, EventArgs e)
    {
        LocalityComboBox.DataSource = null;
        LocalityComboBox.DataSource = APIServiceOne.GetAll<LocalityView>("contract-contents/" + ((ContractViewList)ContractsComboBox.SelectedItem).Id);
        LocalityComboBox.ValueMember = "Id";
        LocalityComboBox.DisplayMember = "Name";
    }
}

