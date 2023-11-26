namespace PetsClient.Domain.Plan;

partial class PlanEditView
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        CancelButton = new Button();
        OkButton = new Button();
        YearComboBox = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        MonthComboBox = new ComboBox();
        CalendarFlowLayoutPanel = new FlowLayoutPanel();
        TemplateGroupBox = new GroupBox();
        DayNumericUpDown = new NumericUpDown();
        DayLabel = new Label();
        ActLabel = new Label();
        StreetLabel = new Label();
        LocalityLabel = new Label();
        AddressTextBox = new TextBox();
        CheckedCheckBox = new CheckBox();
        ActComboBox = new ComboBox();
        LocalityComboBox = new ComboBox();
        AddDayButton = new Button();
        DeleteDayButton = new Button();
        TemplateGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)DayNumericUpDown).BeginInit();
        SuspendLayout();
        // 
        // CancelButton
        // 
        CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CancelButton.Location = new Point(770, 593);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(143, 29);
        CancelButton.TabIndex = 16;
        CancelButton.Text = "Отмена";
        CancelButton.UseVisualStyleBackColor = true;
        CancelButton.Click += CancelButton_Click;
        // 
        // OkButton
        // 
        OkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(621, 593);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(143, 29);
        OkButton.TabIndex = 15;
        OkButton.Text = "Ок";
        OkButton.UseVisualStyleBackColor = true;
        OkButton.Click += OkButton_Click;
        // 
        // YearComboBox
        // 
        YearComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        YearComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        YearComboBox.FormattingEnabled = true;
        YearComboBox.Location = new Point(12, 32);
        YearComboBox.Name = "YearComboBox";
        YearComboBox.Size = new Size(151, 28);
        YearComboBox.Sorted = true;
        YearComboBox.TabIndex = 17;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(169, 9);
        label1.Name = "label1";
        label1.Size = new Size(54, 20);
        label1.TabIndex = 18;
        label1.Text = "Месяц";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 9);
        label2.Name = "label2";
        label2.Size = new Size(33, 20);
        label2.TabIndex = 19;
        label2.Text = "Год";
        // 
        // MonthComboBox
        // 
        MonthComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        MonthComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        MonthComboBox.FormattingEnabled = true;
        MonthComboBox.Location = new Point(169, 32);
        MonthComboBox.Name = "MonthComboBox";
        MonthComboBox.Size = new Size(151, 28);
        MonthComboBox.TabIndex = 20;
        MonthComboBox.SelectedIndexChanged += MonthComboBox_SelectedIndexChanged;
        // 
        // CalendarFlowLayoutPanel
        // 
        CalendarFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        CalendarFlowLayoutPanel.AutoScroll = true;
        CalendarFlowLayoutPanel.Location = new Point(12, 66);
        CalendarFlowLayoutPanel.Name = "CalendarFlowLayoutPanel";
        CalendarFlowLayoutPanel.Size = new Size(901, 521);
        CalendarFlowLayoutPanel.TabIndex = 21;
        // 
        // TemplateGroupBox
        // 
        TemplateGroupBox.Controls.Add(DayNumericUpDown);
        TemplateGroupBox.Controls.Add(DayLabel);
        TemplateGroupBox.Controls.Add(ActLabel);
        TemplateGroupBox.Controls.Add(StreetLabel);
        TemplateGroupBox.Controls.Add(LocalityLabel);
        TemplateGroupBox.Controls.Add(AddressTextBox);
        TemplateGroupBox.Controls.Add(CheckedCheckBox);
        TemplateGroupBox.Controls.Add(ActComboBox);
        TemplateGroupBox.Controls.Add(LocalityComboBox);
        TemplateGroupBox.Location = new Point(469, 55);
        TemplateGroupBox.Name = "TemplateGroupBox";
        TemplateGroupBox.Size = new Size(277, 292);
        TemplateGroupBox.TabIndex = 0;
        TemplateGroupBox.TabStop = false;
        TemplateGroupBox.Text = "groupBox2";
        // 
        // DayNumericUpDown
        // 
        DayNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        DayNumericUpDown.Location = new Point(6, 46);
        DayNumericUpDown.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        DayNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        DayNumericUpDown.Name = "DayNumericUpDown";
        DayNumericUpDown.Size = new Size(166, 27);
        DayNumericUpDown.TabIndex = 8;
        DayNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // DayLabel
        // 
        DayLabel.AutoSize = true;
        DayLabel.Location = new Point(6, 23);
        DayLabel.Name = "DayLabel";
        DayLabel.Size = new Size(44, 20);
        DayLabel.TabIndex = 7;
        DayLabel.Text = "День";
        // 
        // ActLabel
        // 
        ActLabel.AutoSize = true;
        ActLabel.Location = new Point(6, 183);
        ActLabel.Name = "ActLabel";
        ActLabel.Size = new Size(43, 20);
        ActLabel.TabIndex = 6;
        ActLabel.Text = "Акты";
        // 
        // StreetLabel
        // 
        StreetLabel.AutoSize = true;
        StreetLabel.Location = new Point(6, 130);
        StreetLabel.Name = "StreetLabel";
        StreetLabel.Size = new Size(55, 20);
        StreetLabel.TabIndex = 5;
        StreetLabel.Text = "Улицы";
        // 
        // LocalityLabel
        // 
        LocalityLabel.AutoSize = true;
        LocalityLabel.Location = new Point(6, 76);
        LocalityLabel.Name = "LocalityLabel";
        LocalityLabel.Size = new Size(139, 20);
        LocalityLabel.TabIndex = 4;
        LocalityLabel.Text = "Населенный пункт";
        // 
        // AddressTextBox
        // 
        AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        AddressTextBox.Location = new Point(6, 153);
        AddressTextBox.Name = "AddressTextBox";
        AddressTextBox.Size = new Size(265, 27);
        AddressTextBox.TabIndex = 3;
        // 
        // CheckedCheckBox
        // 
        CheckedCheckBox.AutoSize = true;
        CheckedCheckBox.Location = new Point(82, 260);
        CheckedCheckBox.Name = "CheckedCheckBox";
        CheckedCheckBox.Size = new Size(112, 24);
        CheckedCheckBox.TabIndex = 2;
        CheckedCheckBox.Text = "Выполнено";
        CheckedCheckBox.UseVisualStyleBackColor = true;
        // 
        // ActComboBox
        // 
        ActComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        ActComboBox.FormattingEnabled = true;
        ActComboBox.Location = new Point(6, 206);
        ActComboBox.Name = "ActComboBox";
        ActComboBox.Size = new Size(265, 28);
        ActComboBox.TabIndex = 1;
        // 
        // LocalityComboBox
        // 
        LocalityComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LocalityComboBox.FormattingEnabled = true;
        LocalityComboBox.Location = new Point(6, 99);
        LocalityComboBox.Name = "LocalityComboBox";
        LocalityComboBox.Size = new Size(265, 28);
        LocalityComboBox.TabIndex = 0;
        // 
        // AddDayButton
        // 
        AddDayButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        AddDayButton.Location = new Point(621, 32);
        AddDayButton.Name = "AddDayButton";
        AddDayButton.Size = new Size(143, 29);
        AddDayButton.TabIndex = 22;
        AddDayButton.Text = "Добавить день";
        AddDayButton.UseVisualStyleBackColor = true;
        AddDayButton.Click += AddDayButton_Click;
        // 
        // DeleteDayButton
        // 
        DeleteDayButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        DeleteDayButton.Location = new Point(770, 31);
        DeleteDayButton.Name = "DeleteDayButton";
        DeleteDayButton.Size = new Size(143, 29);
        DeleteDayButton.TabIndex = 23;
        DeleteDayButton.Text = "Удалить день";
        DeleteDayButton.UseVisualStyleBackColor = true;
        DeleteDayButton.Click += DeleteDayButton_Click;
        // 
        // PlanEditView
        // 
        AutoScaleMode = AutoScaleMode.None;
        ClientSize = new Size(925, 634);
        Controls.Add(DeleteDayButton);
        Controls.Add(AddDayButton);
        Controls.Add(TemplateGroupBox);
        Controls.Add(CalendarFlowLayoutPanel);
        Controls.Add(MonthComboBox);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(YearComboBox);
        Controls.Add(CancelButton);
        Controls.Add(OkButton);
        Name = "PlanEditView";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "План-график";
        Load += PlanEditView_Load;
        TemplateGroupBox.ResumeLayout(false);
        TemplateGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)DayNumericUpDown).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button CancelButton;
    private Button OkButton;
    private BindingSource contractContentViewBindingSource;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    private DataGridViewComboBoxColumn localityDataGridViewTextBoxColumn;
    private ComboBox YearComboBox;
    private Label label1;
    private Label label2;
    private ComboBox MonthComboBox;
    private FlowLayoutPanel CalendarFlowLayoutPanel;
    private GroupBox TemplateGroupBox;
    private CheckBox CheckedCheckBox;
    private ComboBox ActComboBox;
    private ComboBox LocalityComboBox;
    private Label LocalityLabel;
    private TextBox AddressTextBox;
    private Label ActLabel;
    private Label StreetLabel;
    private Label DayLabel;
    private NumericUpDown DayNumericUpDown;
    private Button AddDayButton;
    private Button DeleteDayButton;
}