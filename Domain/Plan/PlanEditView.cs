using ModelLibrary.Model.Act;
using ModelLibrary.Model.Etc;
using ModelLibrary.Model.Plan;
using PetsClient.Etc;
using PetsClient.Services;
using System.Globalization;

namespace PetsClient.Domain.Plan;

public partial class PlanEditView : Form, IView
{
    public PlanEdit PlanEdited { get; set; } = new PlanEdit();
    private readonly APIServiceModel<PlanViewList, PlanEdit, PlanViewOne> _service;
    private readonly int _id;
    private List<LocalityView>? _localities;
    private List<ActViewList>? _acts;

    public PlanEditView(APIServiceModel<PlanViewList, PlanEdit, PlanViewOne> service)
    {
        InitializeComponent();
        FillComboBoxes();
        _service = service;
    }

    public PlanEditView(State state, int id, APIServiceModel<PlanViewList, PlanEdit, PlanViewOne> service)
    {

        InitializeComponent();
        FillComboBoxes();
        if (state == State.Read)
            ChangeEnable();
        _id = id;
        _service = service;
        FillFields();
    }

    private void FillComboBoxes()
    {
        _localities = APIServiceOne.GetAll<LocalityView>("localities");
        _acts = APIServiceOne.GetAllFromPage<ActViewList>("acts");
        var currentYear = DateTime.Now.Year;
        var years = Enumerable.Range(currentYear - 2, 5);
        YearComboBox.DataSource = years.ToList();
        YearComboBox.SelectedItem = currentYear;
        CultureInfo culture = new("ru-RU");
        culture.DateTimeFormat.MonthNames = culture.DateTimeFormat.MonthGenitiveNames;
        culture.DateTimeFormat.AbbreviatedMonthNames = culture.DateTimeFormat.AbbreviatedMonthGenitiveNames;
        MonthComboBox.DataSource = culture.DateTimeFormat.MonthNames.Take(12).ToList();
    }

    private void ChangeEnable()
    {
        YearComboBox.Enabled = false;
        MonthComboBox.Enabled = false;
        OkButton.Visible = false;
        AddDayButton.Visible = false;
        DeleteDayButton.Visible = false;
        CalendarFlowLayoutPanel.Enabled = false;
        ExitButton.Text = "Закрыть";
    }

    private bool CheckFilds()
    {
        var dialogRes = DialogResult.No;
        //if (string.IsNullOrEmpty(NumberTextBox.Text))
        //    dialogRes = IView.ShowErrorMessage("Не заполнен номер контракта.");
        //else if (DateOfConclusionDateTimePicker.Value > DateValidDateTimePicker.Value)
        //    dialogRes = IView.ShowErrorMessage("Дата заключения позже даты действия.");
        //else if (ExecutorComboBox.SelectedItem == null)
        //    dialogRes = IView.ShowErrorMessage("Не выбран исполнитель.");
        //else if (ClientComboBox.SelectedItem == null)
        //    dialogRes = IView.ShowErrorMessage("Не выбран заказчик.");
        //else if (LocalsPricesDataGridView.Rows.Count == 0)
        //    dialogRes = IView.ShowErrorMessage("Не добавлено содержание контракта.");
        //else if (ClientComboBox.SelectedItem == ExecutorComboBox.SelectedItem)
        //    dialogRes = IView.ShowErrorMessage("Организации одинаковые.");
        //else if (LocalsPricesDataGridView.Rows.Count > 0)
        //{
        //    foreach (DataGridViewRow row in LocalsPricesDataGridView.Rows)
        //    {
        //        if (row.Cells[1].Value != null && decimal.TryParse(row.Cells[1].Value.ToString(), out _))
        //            dialogRes = IView.ShowErrorMessage("Значение цены указано некорректно.");
        //        else if (row.Cells[2].Value != null)
        //            dialogRes = IView.ShowErrorMessage("Населенный пункт не указан.");
        //    }
        //}  
        return dialogRes == DialogResult.No;

    }

    private void OkButton_Click(object sender, EventArgs e)
    {
        if (CheckFilds())
        {
            PlanEdited.Year = (int)(YearComboBox.SelectedValue ?? DateTime.Now.Year);
            PlanEdited.Month = MonthComboBox.SelectedIndex + 1;
            PlanEdited.PlanContent = new List<PlanContentEdit>();

            for (var i = 0; i < CalendarFlowLayoutPanel.Controls.Count; i++)
            {
                var groupBox = CalendarFlowLayoutPanel.Controls[i];
                var dayNumeric = (NumericUpDown)groupBox.Controls[1];
                var localityCombobox = (ComboBox)groupBox.Controls[3];
                var addressBox = (TextBox)groupBox.Controls[5];
                var actComboBox = (ComboBox)groupBox.Controls[7];
                var checkedBox = (CheckBox)groupBox.Controls[8];
                var idLabel = (Label)groupBox.Controls[9];
                int.TryParse(idLabel.Text, out int id);
                PlanEdited.PlanContent.Add(new PlanContentEdit()
                {
                    Id = id,
                    Day = (int)dayNumeric.Value,
                    LocalityId = _localities.First(l => l.Name == localityCombobox.SelectedItem.ToString()).Id,
                    Adress = addressBox.Text,
                    Check = checkedBox.Checked,
                    ActId = actComboBox.SelectedIndex != -1 ? _acts[actComboBox.SelectedIndex].Id : null
                });
            }
            Close();
        }
    }

    private void FillFields()
    {
        var plan = _service.Get("plans", _id);
        YearComboBox.SelectedItem = plan.Year;
        MonthComboBox.SelectedIndex = plan.Month - 1;
        var content = plan.PlanContent;
        for (int i = 0; i < content.Count; i++)
        {
            CreateGroupBox();
            var groupBox = CalendarFlowLayoutPanel.Controls[i];

            var dayNumeric = (NumericUpDown)groupBox.Controls[1];
            dayNumeric.Value = content[i].Day;

            var localityCombobox = (ComboBox)groupBox.Controls[3];
            localityCombobox.SelectedIndex = content[i].Locality.Id - 1;

            var addressBox = (TextBox)groupBox.Controls[5];
            addressBox.Text = content[i].Adress;

            if (content[i].Act != null)
            {
                var actCombobox = ((ComboBox)groupBox.Controls[7]);
                var item = _acts?.Find(a => a.Id == content[i].Act.Id);
                actCombobox.SelectedIndex = _acts.IndexOf(item);
            }

            var checkedBox = (CheckBox)groupBox.Controls[8];
            checkedBox.Checked = content[i].Check;

            var idLabel = (Label)groupBox.Controls[9];
            idLabel.Text = content[i].Id.ToString();
        }
    }

    private void CancelButton_Click(object sender, EventArgs e) => Close();

    private void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {


    }

    private void AddDayButton_Click(object sender, EventArgs e)
    {
        CreateGroupBox();
    }


    private void CreateGroupBox()
    {
        var days = DateTime.DaysInMonth((int)YearComboBox.SelectedValue, MonthComboBox.SelectedIndex + 1);
        var groupBox = new GroupBox()
        {
            Text = "День",
            Size = new Size(TemplateGroupBox.Width, TemplateGroupBox.Height)
        };

        var dayLabel = new Label
        {
            Text = DayLabel.Text,
            Location = new Point(DayLabel.Location.X, DayLabel.Location.Y),
            Size = new Size(DayLabel.Size.Width, DayLabel.Size.Height)
        };
        groupBox.Controls.Add(dayLabel);

        var dayNumeric = new NumericUpDown
        {
            Maximum = days,
            Minimum = 1,
            Location = new Point(DayNumericUpDown.Location.X, DayNumericUpDown.Location.Y),
            Size = new Size(DayNumericUpDown.Size.Width, DayNumericUpDown.Size.Height)
        };
        groupBox.Controls.Add(dayNumeric);

        var localityLabel = new Label
        {
            Text = LocalityLabel.Text,
            Location = new Point(LocalityLabel.Location.X, LocalityLabel.Location.Y),
            Size = new Size(LocalityLabel.Size.Width, LocalityLabel.Size.Height)
        };
        groupBox.Controls.Add(localityLabel);

        var localityCombobox = new ComboBox
        {
            Size = new Size(LocalityComboBox.Width, LocalityComboBox.Height),
            Location = new Point(LocalityComboBox.Location.X, LocalityComboBox.Location.Y)
        };
        localityCombobox.Items.AddRange(_localities.Select(l => l.Name).ToArray());
        groupBox.Controls.Add(localityCombobox);

        var addressLabel = new Label
        {
            Text = StreetLabel.Text,
            Location = new Point(StreetLabel.Location.X, StreetLabel.Location.Y)
        };
        groupBox.Controls.Add(addressLabel);

        var addressTextBox = new TextBox
        {
            Size = new Size(AddressTextBox.Width, AddressTextBox.Height),
            Location = new Point(AddressTextBox.Location.X, AddressTextBox.Location.Y)
        };
        groupBox.Controls.Add(addressTextBox);

        var actLabel = new Label
        {
            Text = ActLabel.Text,
            Location = new Point(ActLabel.Location.X, ActLabel.Location.Y)
        };
        groupBox.Controls.Add(actLabel);

        var actCombobox = new ComboBox
        {
            Size = new Size(ActComboBox.Width, ActComboBox.Height),
            Location = new Point(ActComboBox.Location.X, ActComboBox.Location.Y)
        };
        actCombobox.Items.AddRange(_acts.Select(l => l.Id.ToString()).ToArray());
        groupBox.Controls.Add(actCombobox);

        var checkBox = new CheckBox
        {
            Location = new Point(CheckedCheckBox.Location.X, CheckedCheckBox.Location.Y),
            Text = CheckedCheckBox.Text
        };

        groupBox.Controls.Add(checkBox);


        var idLabel = new Label
        {
            Visible = false
        };
        groupBox.Controls.Add(idLabel);

        CalendarFlowLayoutPanel.Controls.Add(groupBox);
    }

    private void DeleteDayButton_Click(object sender, EventArgs e)
    {
        if (CalendarFlowLayoutPanel.Controls.Count > 0)
            CalendarFlowLayoutPanel.Controls.RemoveAt(CalendarFlowLayoutPanel.Controls.Count - 1);
    }

    private void PlanEditView_Load(object sender, EventArgs e)
    {
        TemplateGroupBox.Visible = false;

    }
}
