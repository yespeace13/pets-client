namespace PetsClient.Domain.Plan;

partial class PlanView
{
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        CreateButton = new Button();
        NextPageButton = new Button();
        PreviousPageButton = new Button();
        NumberOfPage = new NumericUpDown();
        SelectPageButton = new Button();
        PagesSize = new NumericUpDown();
        NumberPageLabel = new Label();
        CountLabel = new Label();
        ItemsDataGridView = new DataGridView();
        ContractContextMenuStrip = new ContextMenuStrip(components);
        ChangeToolStripMenuItem = new ToolStripMenuItem();
        DeleteToolStripMenuItem = new ToolStripMenuItem();
        label1 = new Label();
        ExportButton = new Button();
        FiltrGroupBox = new GroupBox();
        ClearFiltrsButton = new Button();
        AcceptFiltrButton = new Button();
        FiltrTextBox = new TextBox();
        ((System.ComponentModel.ISupportInitialize)NumberOfPage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PagesSize).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ItemsDataGridView).BeginInit();
        ContractContextMenuStrip.SuspendLayout();
        FiltrGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // CreateButton
        // 
        CreateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        CreateButton.Location = new Point(970, 12);
        CreateButton.Name = "CreateButton";
        CreateButton.Size = new Size(90, 29);
        CreateButton.TabIndex = 0;
        CreateButton.Text = "Добавить";
        CreateButton.UseVisualStyleBackColor = true;
        CreateButton.Click += CreateContractButton_Click;
        // 
        // NextPageButton
        // 
        NextPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        NextPageButton.Location = new Point(1066, 591);
        NextPageButton.Name = "NextPageButton";
        NextPageButton.Size = new Size(130, 29);
        NextPageButton.TabIndex = 2;
        NextPageButton.Text = "След. страница";
        NextPageButton.UseVisualStyleBackColor = true;
        NextPageButton.Click += NextPageButton_Click;
        // 
        // PreviousPageButton
        // 
        PreviousPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        PreviousPageButton.Location = new Point(930, 591);
        PreviousPageButton.Name = "PreviousPageButton";
        PreviousPageButton.Size = new Size(130, 29);
        PreviousPageButton.TabIndex = 3;
        PreviousPageButton.Text = "Пред. страница";
        PreviousPageButton.UseVisualStyleBackColor = true;
        PreviousPageButton.Click += PreviousPageButton_Click;
        // 
        // NumberOfPage
        // 
        NumberOfPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        NumberOfPage.Location = new Point(744, 593);
        NumberOfPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NumberOfPage.Name = "NumberOfPage";
        NumberOfPage.Size = new Size(64, 27);
        NumberOfPage.TabIndex = 4;
        NumberOfPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // SelectPageButton
        // 
        SelectPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        SelectPageButton.Location = new Point(814, 591);
        SelectPageButton.Name = "SelectPageButton";
        SelectPageButton.Size = new Size(75, 29);
        SelectPageButton.TabIndex = 5;
        SelectPageButton.Text = "Перейти";
        SelectPageButton.UseVisualStyleBackColor = true;
        SelectPageButton.Click += ForwardToPage_Click;
        // 
        // PagesSize
        // 
        PagesSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        PagesSize.Increment = new decimal(new int[] { 5, 0, 0, 0 });
        PagesSize.Location = new Point(564, 593);
        PagesSize.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
        PagesSize.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
        PagesSize.Name = "PagesSize";
        PagesSize.Size = new Size(64, 27);
        PagesSize.TabIndex = 6;
        PagesSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
        PagesSize.ValueChanged += PagesSize_ValueChanged;
        // 
        // NumberPageLabel
        // 
        NumberPageLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        NumberPageLabel.AutoSize = true;
        NumberPageLabel.Location = new Point(661, 585);
        NumberPageLabel.Name = "NumberPageLabel";
        NumberPageLabel.Size = new Size(77, 40);
        NumberPageLabel.TabIndex = 7;
        NumberPageLabel.Text = "Номер\r\nстраницы";
        NumberPageLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // CountLabel
        // 
        CountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CountLabel.AutoSize = true;
        CountLabel.Location = new Point(358, 585);
        CountLabel.Name = "CountLabel";
        CountLabel.Size = new Size(200, 40);
        CountLabel.TabIndex = 8;
        CountLabel.Text = "Количество отображаемых\r\nэлементов";
        CountLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // ItemsDataGridView
        // 
        ItemsDataGridView.AllowUserToAddRows = false;
        ItemsDataGridView.AllowUserToDeleteRows = false;
        ItemsDataGridView.AllowUserToOrderColumns = true;
        ItemsDataGridView.AllowUserToResizeRows = false;
        ItemsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        ItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        ItemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ItemsDataGridView.Location = new Point(12, 47);
        ItemsDataGridView.MultiSelect = false;
        ItemsDataGridView.Name = "ItemsDataGridView";
        ItemsDataGridView.ReadOnly = true;
        ItemsDataGridView.RowHeadersVisible = false;
        ItemsDataGridView.RowHeadersWidth = 51;
        ItemsDataGridView.RowTemplate.Height = 24;
        ItemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        ItemsDataGridView.Size = new Size(1184, 538);
        ItemsDataGridView.TabIndex = 9;
        ItemsDataGridView.ColumnHeaderMouseClick += ConDataGrid_ColumnHeaderMouseClick;
        ItemsDataGridView.MouseDoubleClick += ConDataGrid_MouseDoubleClick;
        ItemsDataGridView.MouseDown += ConDataGrid_MouseDown;
        // 
        // ContractContextMenuStrip
        // 
        ContractContextMenuStrip.ImageScalingSize = new Size(20, 20);
        ContractContextMenuStrip.Items.AddRange(new ToolStripItem[] { ChangeToolStripMenuItem, DeleteToolStripMenuItem });
        ContractContextMenuStrip.Name = "OrganizationContextMenuStrip";
        ContractContextMenuStrip.Size = new Size(148, 52);
        // 
        // ChangeToolStripMenuItem
        // 
        ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem";
        ChangeToolStripMenuItem.Size = new Size(147, 24);
        ChangeToolStripMenuItem.Text = "Изменить";
        ChangeToolStripMenuItem.Click += ChangeToolStripMenuItem_Click;
        // 
        // DeleteToolStripMenuItem
        // 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
        DeleteToolStripMenuItem.Size = new Size(147, 24);
        DeleteToolStripMenuItem.Text = "Удалить";
        DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(172, 20);
        label1.TabIndex = 13;
        label1.Text = "Планы-графики отлова";
        // 
        // ExportButton
        // 
        ExportButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        ExportButton.Location = new Point(1066, 12);
        ExportButton.Name = "ExportButton";
        ExportButton.Size = new Size(130, 29);
        ExportButton.TabIndex = 15;
        ExportButton.Text = "Экспорт в Excel";
        ExportButton.UseVisualStyleBackColor = true;
        ExportButton.Click += ExportButton_Click;
        // 
        // FiltrGroupBox
        // 
        FiltrGroupBox.Controls.Add(ClearFiltrsButton);
        FiltrGroupBox.Controls.Add(AcceptFiltrButton);
        FiltrGroupBox.Controls.Add(FiltrTextBox);
        FiltrGroupBox.Location = new Point(158, 146);
        FiltrGroupBox.Name = "FiltrGroupBox";
        FiltrGroupBox.Size = new Size(229, 99);
        FiltrGroupBox.TabIndex = 17;
        FiltrGroupBox.TabStop = false;
        FiltrGroupBox.Text = "Фильтр";
        FiltrGroupBox.Visible = false;
        // 
        // ClearFiltrsButton
        // 
        ClearFiltrsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        ClearFiltrsButton.Location = new Point(39, 64);
        ClearFiltrsButton.Name = "ClearFiltrsButton";
        ClearFiltrsButton.Size = new Size(89, 29);
        ClearFiltrsButton.TabIndex = 3;
        ClearFiltrsButton.Text = "Сбросить";
        ClearFiltrsButton.UseVisualStyleBackColor = true;
        ClearFiltrsButton.Click += ClearFiltrsButton_Click;
        // 
        // AcceptFiltrButton
        // 
        AcceptFiltrButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        AcceptFiltrButton.Location = new Point(134, 64);
        AcceptFiltrButton.Name = "AcceptFiltrButton";
        AcceptFiltrButton.Size = new Size(89, 29);
        AcceptFiltrButton.TabIndex = 2;
        AcceptFiltrButton.Text = "Принять";
        AcceptFiltrButton.UseVisualStyleBackColor = true;
        AcceptFiltrButton.Click += AcceptFiltrButton_Click;
        // 
        // FiltrTextBox
        // 
        FiltrTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        FiltrTextBox.Location = new Point(6, 21);
        FiltrTextBox.Name = "FiltrTextBox";
        FiltrTextBox.Size = new Size(217, 27);
        FiltrTextBox.TabIndex = 1;
        // 
        // PlanView
        // 
        AutoScaleMode = AutoScaleMode.None;
        ClientSize = new Size(1208, 630);
        Controls.Add(FiltrGroupBox);
        Controls.Add(ExportButton);
        Controls.Add(label1);
        Controls.Add(ItemsDataGridView);
        Controls.Add(CountLabel);
        Controls.Add(NumberPageLabel);
        Controls.Add(PagesSize);
        Controls.Add(SelectPageButton);
        Controls.Add(NumberOfPage);
        Controls.Add(PreviousPageButton);
        Controls.Add(NextPageButton);
        Controls.Add(CreateButton);
        Name = "PlanView";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Реестр";
        ((System.ComponentModel.ISupportInitialize)NumberOfPage).EndInit();
        ((System.ComponentModel.ISupportInitialize)PagesSize).EndInit();
        ((System.ComponentModel.ISupportInitialize)ItemsDataGridView).EndInit();
        ContractContextMenuStrip.ResumeLayout(false);
        FiltrGroupBox.ResumeLayout(false);
        FiltrGroupBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button NextPageButton;
    private Button PreviousPageButton;
    private NumericUpDown NumberOfPage;
    private Button SelectPageButton;
    private NumericUpDown PagesSize;
    private Label NumberPageLabel;
    private Label CountLabel;
    private Button CreateButton;
    private DataGridView ItemsDataGridView;
    private Label label1;
    private Button ExportButton;
    private ContextMenuStrip ContractContextMenuStrip;
    private ToolStripMenuItem ChangeToolStripMenuItem;
    private ToolStripMenuItem DeleteToolStripMenuItem;
    private GroupBox FiltrGroupBox;
    private Button ClearFiltrsButton;
    private Button AcceptFiltrButton;
    private TextBox FiltrTextBox;
    private DateTimePicker FiltrStartDateTimePicker;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn Number;
    private DataGridViewTextBoxColumn DateOfConclusion;
    private DataGridViewTextBoxColumn DateValidation;
    private DataGridViewTextBoxColumn Executor;
    private DataGridViewTextBoxColumn Client;
    private DateTimePicker FiltrEndDateTimePicker;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dateOfConclusionDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dateValidDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn executorDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
    private BindingSource contractViewListBindingSource;
}

