using ModelLibrary.Model.Animal;
using PetsClient.Etc;
using PetsClient.Services;

namespace PetsClient.Act;

public partial class AnimalEditView : Form
{
    private int _currentScan;

    public AnimalEdit Animal { get; set; }

    public AnimalEditView(State state, int id)
    {
        InitializeComponent();
        FillData(id);
        PrevScanButton.Enabled = false;
        NextScanButton.Enabled = false;
        if (state == State.Read)
            EnableControls();
    }
    public AnimalEditView()
    {
        //InitializeComponent();
        //_controller = controller;
        //FillComboBoxes();
        //PrevScanButton.Enabled = false;
        //_state = State.Insert;
        //Scans = new List<string>();
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

    private void FillData(int id)
    {
        var animal = APIServiceOne.GetOne<AnimalViewList>("animals", id);
        CategoryTextBox.Text = animal.Category;
        if (animal.Sex == "Самка") FemaleRadioButton.Checked = true;
        else MaleRadioButton.Checked = true;
        BreedTextBox.Text = animal.Breed;
        SizeNumericUpDown.Value = (decimal)animal.Size;
        WoolTextBox.Text = animal.Wool;
        ColorTextBox.Text = animal.Color;
        EarsTextBox.Text = animal.Ears;
        TailTextBox.Text = animal.Tail;
        SpecialSignsTextBox.Text = animal.SpecialSigns;
        IdenLabelTextBox.Text = animal.IdentificationLabel;
        ChipNumTextBox.Text = animal.ChipNumber;
        
        //Scans = scans;
        _currentScan = 0;
        //if (Scans.Count != 0) ChangeScan();
    }

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

    private static DialogResult ShowErrorMessage(string error)
    {
        return MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    private void OkButton_Click(object sender, EventArgs e)
    {
        if (CheckFields())
        {
            //Category =  CategoryTextBox.Text;
            //Sex = FemaleRadioButton.Checked ? "Caмка" : "Самец";
            //Breed =  BreedTextBox.Text;
            //Size = (double)SizeNumericUpDown.Value;
            //Wool = WoolTextBox.Text;
            //Color = ColorTextBox.Text;
            //Ears = EarsTextBox.Text;
            //Tail =  TailTextBox.Text;
            //SpecialSigns = SpecialSignsTextBox.Text;
            //IdentificationLabel = IdenLabelTextBox.Text;
            //ChipNumber =  ChipNumTextBox.Text;
            //Locality =  LocalityComboBox.SelectedItem.ToString();
            //DialogResult = DialogResult.OK;
            Close();
        }
    }

    private bool CheckFields()
    {
        var dialogRes = DialogResult.No;
        return dialogRes == DialogResult.No;
    }

    private void CancelButton_Click(object sender, EventArgs e) => Close();


    private void ScanPictureBox_DoubleClick(object sender, EventArgs e)
    {
        //new ScanView(new Bitmap(Scans[_currentScan])).ShowDialog();
    }
}
