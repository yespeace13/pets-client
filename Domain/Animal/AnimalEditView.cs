using ModelLibrary.Model.Animal;
using PetsClient.Etc;

namespace PetsClient.Act;

public partial class AnimalEditView : Form
{
    public AnimalViewList Animal { get; set; }

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

        //Scans = scans;
        //if (Scans.Count != 0) ChangeScan();
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
        //if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //{
        //    Scans.Add(openFileDialog1.FileName);
        //    _currentScan = Scans.Count - 1;
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

    private void ScanPictureBox_DoubleClick(object sender, EventArgs e)
    {
        //new ScanView(new Bitmap(Scans[_currentScan])).ShowDialog();
    }

    private void ChangeScan()
    {
        //if (File.Exists(Scans[_currentScan]))
        //{
        //    var bitmap = new Bitmap(Scans[_currentScan]);
        //    var coef = (int)((double)bitmap.Size.Width / bitmap.Size.Height * 10);
        //    var i = new Bitmap(bitmap, new Size(ScanPictureBox.Height * coef / 10, ScanPictureBox.Width));
        //    ScanPictureBox.Image = i;
        //}
        //else
        //{
        //    ShowErrorMessage("Не все файлы были загружены.");
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
        //if (_currentScan < Scans.Count - 1)
        //{
        //    _currentScan++;
        //    NextScanButton.Enabled = _currentScan == Scans.Count - 1 ? false : true;
        //    PrevScanButton.Enabled = true;
        //    ChangeScan();
        //}
    }
}
