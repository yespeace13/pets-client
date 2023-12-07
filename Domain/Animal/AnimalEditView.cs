using ModelLibrary.Model.Animal;
using ModelLibrary.Model.Etc;
using PetsClient.Etc;
using PetsClient.Services;

namespace PetsClient.Act;

public partial class AnimalEditView : Form
{
    public AnimalViewList Animal { get; set; }

    public List<FileBaseView> Files { get; set; } = new List<FileBaseView>();

    private int _currentFile = 0;

    public AnimalEditView(State state, AnimalViewList animal)
    {
        Animal = animal;
        InitializeComponent();
        FillData();
        PrevScanButton.Enabled = false;
        NextScanButton.Enabled = false;
        if (state == State.Read)
            EnableControls();
    }
    public AnimalEditView()
    {
        InitializeComponent();
        Animal = new AnimalViewList();
        PrevScanButton.Enabled = false;
        NextScanButton.Enabled = false;
    }

    private void EnableControls()
    {
        CategoryTextBox.Enabled = false;
        SexGroupBox.Enabled = false;
        BreedTextBox.Enabled = false;
        SizeNumericUpDown.Enabled = false;
        WoolTextBox.Enabled = false;
        ColorTextBox.Enabled = false;
        EarsTextBox.Enabled = false;
        TailTextBox.Enabled = false;
        SpecialSignsTextBox.Enabled = false;
        IdenLabelTextBox.Enabled = false;
        ChipNumTextBox.Enabled = false;
        AddFileButton.Enabled = false;
        OkButton.Visible = false;
        CancelButton.Text = "Закрыть";
    }

    private void FillData()
    {
        CategoryTextBox.Text = Animal.Category;
        if (Animal.Sex == "Самка") FemaleRadioButton.Checked = true;
        else MaleRadioButton.Checked = true;
        BreedTextBox.Text = Animal.Breed;
        SizeNumericUpDown.Value = (decimal)Animal.Size;
        WoolTextBox.Text = Animal.Wool;
        ColorTextBox.Text = Animal.Color;
        EarsTextBox.Text = Animal.Ears;
        TailTextBox.Text = Animal.Tail;
        SpecialSignsTextBox.Text = Animal.SpecialSigns;
        IdenLabelTextBox.Text = Animal.IdentificationLabel;
        ChipNumTextBox.Text = Animal.ChipNumber;

        Files = APIServiceOne.GetFiles("animal-photo", Animal.Id);
        ChangeScan();
    }

    

    private void OkButton_Click(object sender, EventArgs e)
    {
        if (CheckFields())
        {
            Animal.Category = CategoryTextBox.Text;
            Animal.Sex = FemaleRadioButton.Checked ? "Caмка" : "Самец";
            Animal.Breed = BreedTextBox.Text;
            Animal.Size = (double)SizeNumericUpDown.Value;
            Animal.Wool = WoolTextBox.Text;
            Animal.Color = ColorTextBox.Text;
            Animal.Ears = EarsTextBox.Text;
            Animal.Tail = TailTextBox.Text;
            Animal.SpecialSigns = SpecialSignsTextBox.Text;
            Animal.IdentificationLabel = IdenLabelTextBox.Text;
            Animal.ChipNumber = ChipNumTextBox.Text;
            
            Close();
        }
    }

    private bool CheckFields()
    {
        var dialogRes = DialogResult.No;
        return dialogRes == DialogResult.No;
    }

    private void CancelButton_Click(object sender, EventArgs e) => Close();

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

    private void ScanPictureBox_DoubleClick(object sender, EventArgs e)
    {
        //new ScanView(new Bitmap(Scans[_currentScan])).ShowDialog();
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
                _currentFile = _currentFile == 0 ? 0 : --_currentFile;
            }
            ChangeScan();
        }
        else
        {
            ScanPictureBox.Image = null;
        }
    }
}
