namespace PetsClient.Act
{
    partial class Actview
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
            ActsDataGridView = new DataGridView();
            ContractContextMenuStrip = new ContextMenuStrip(components);
            ChangeToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            ExportButton = new Button();
            FiltrGroupBox = new GroupBox();
            FiltrEndDateTimePicker = new DateTimePicker();
            FiltrStartDateTimePicker = new DateTimePicker();
            ClearFiltrsButton = new Button();
            AcceptFiltrButton = new Button();
            FiltrTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NumberOfPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PagesSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ActsDataGridView).BeginInit();
            ContractContextMenuStrip.SuspendLayout();
            FiltrGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CreateButton
            // 
            CreateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateButton.Location = new Point(827, 12);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(90, 29);
            CreateButton.TabIndex = 0;
            CreateButton.Text = "Добавить";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateActButton_Click;
            // 
            // NextPageButton
            // 
            NextPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NextPageButton.Location = new Point(923, 528);
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
            PreviousPageButton.Location = new Point(787, 528);
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
            NumberOfPage.Location = new Point(589, 530);
            NumberOfPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberOfPage.Name = "NumberOfPage";
            NumberOfPage.Size = new Size(64, 27);
            NumberOfPage.TabIndex = 4;
            NumberOfPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SelectPageButton
            // 
            SelectPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SelectPageButton.Location = new Point(663, 528);
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
            PagesSize.Location = new Point(414, 530);
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
            NumberPageLabel.Location = new Point(506, 522);
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
            CountLabel.Location = new Point(208, 528);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(200, 40);
            CountLabel.TabIndex = 8;
            CountLabel.Text = "Количество отображаемых\r\nэлементов";
            CountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ActDataGridView
            // 
            ActsDataGridView.AllowUserToAddRows = false;
            ActsDataGridView.AllowUserToDeleteRows = false;
            ActsDataGridView.AllowUserToOrderColumns = true;
            ActsDataGridView.AllowUserToResizeRows = false;
            ActsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ActsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ActsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ActsDataGridView.Location = new Point(12, 47);
            ActsDataGridView.MultiSelect = false;
            ActsDataGridView.Name = "ActDataGridView";
            ActsDataGridView.ReadOnly = true;
            ActsDataGridView.RowHeadersVisible = false;
            ActsDataGridView.RowHeadersWidth = 51;
            ActsDataGridView.RowTemplate.Height = 24;
            ActsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ActsDataGridView.Size = new Size(1041, 475);
            ActsDataGridView.TabIndex = 9;
            ActsDataGridView.ColumnHeaderMouseClick += ActsDataGrid_ColumnHeaderMouseClick;
            ActsDataGridView.MouseDoubleClick += ActsDataGrid_MouseDoubleClick;
            ActsDataGridView.MouseDown += ConDataGrid_MouseDown;
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
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 13;
            label1.Text = "Акты";
            // 
            // ExportButton
            // 
            ExportButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExportButton.Location = new Point(923, 12);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(130, 29);
            ExportButton.TabIndex = 15;
            ExportButton.Text = "Экспорт в Excel";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // FiltrGroupBox
            // 
            FiltrGroupBox.Controls.Add(FiltrEndDateTimePicker);
            FiltrGroupBox.Controls.Add(FiltrStartDateTimePicker);
            FiltrGroupBox.Controls.Add(ClearFiltrsButton);
            FiltrGroupBox.Controls.Add(AcceptFiltrButton);
            FiltrGroupBox.Controls.Add(FiltrTextBox);
            FiltrGroupBox.Location = new Point(158, 146);
            FiltrGroupBox.Name = "FiltrGroupBox";
            FiltrGroupBox.Size = new Size(212, 89);
            FiltrGroupBox.TabIndex = 17;
            FiltrGroupBox.TabStop = false;
            FiltrGroupBox.Text = "Фильтр";
            FiltrGroupBox.Visible = false;
            // 
            // FiltrEndDateTimePicker
            // 
            FiltrEndDateTimePicker.Location = new Point(6, 49);
            FiltrEndDateTimePicker.Name = "FiltrEndDateTimePicker";
            FiltrEndDateTimePicker.Size = new Size(200, 27);
            FiltrEndDateTimePicker.TabIndex = 19;
            FiltrEndDateTimePicker.Visible = false;
            // 
            // FiltrStartDateTimePicker
            // 
            FiltrStartDateTimePicker.Location = new Point(6, 32);
            FiltrStartDateTimePicker.Name = "FiltrStartDateTimePicker";
            FiltrStartDateTimePicker.Size = new Size(200, 27);
            FiltrStartDateTimePicker.TabIndex = 18;
            FiltrStartDateTimePicker.Value = new DateTime(2000, 6, 8, 20, 7, 0, 0);
            FiltrStartDateTimePicker.Visible = false;
            // 
            // ClearFiltrsButton
            // 
            ClearFiltrsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ClearFiltrsButton.Location = new Point(49, 60);
            ClearFiltrsButton.Name = "ClearFiltrsButton";
            ClearFiltrsButton.Size = new Size(75, 23);
            ClearFiltrsButton.TabIndex = 3;
            ClearFiltrsButton.Text = "Сбросить";
            ClearFiltrsButton.UseVisualStyleBackColor = true;
            ClearFiltrsButton.Click += ClearFiltrsButton_Click;
            // 
            // AcceptFiltrButton
            // 
            AcceptFiltrButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AcceptFiltrButton.Location = new Point(131, 60);
            AcceptFiltrButton.Name = "AcceptFiltrButton";
            AcceptFiltrButton.Size = new Size(75, 23);
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
            FiltrTextBox.Size = new Size(200, 27);
            FiltrTextBox.TabIndex = 1;
            // 
            // Actview
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1065, 569);
            Controls.Add(FiltrGroupBox);
            Controls.Add(ExportButton);
            Controls.Add(label1);
            Controls.Add(ActsDataGridView);
            Controls.Add(CountLabel);
            Controls.Add(NumberPageLabel);
            Controls.Add(PagesSize);
            Controls.Add(SelectPageButton);
            Controls.Add(NumberOfPage);
            Controls.Add(PreviousPageButton);
            Controls.Add(NextPageButton);
            Controls.Add(CreateButton);
            Name = "Actview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реестр";
            ((System.ComponentModel.ISupportInitialize)NumberOfPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)PagesSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)ActsDataGridView).EndInit();
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
        private DataGridView ActsDataGridView;
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
        private DateTimePicker FiltrEndDateTimePicker;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Organization;
        private DataGridViewTextBoxColumn DateOfCapture;
        private DataGridViewTextBoxColumn Contract;
    }
}

