using ModelLibrary.Model.Organization;

namespace PetsClient.Domain.Report
{
    partial class ReportView
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
            ViewDataGridView = new DataGridView();
            label1 = new Label();
            ExportButton = new Button();
            FiltrGroupBox = new GroupBox();
            ClearFiltrsButton = new Button();
            AcceptFiltrButton = new Button();
            FiltrTextBox = new TextBox();
            ReportContextMenuStrip = new ContextMenuStrip(components);
            ChangeToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)NumberOfPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PagesSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewDataGridView).BeginInit();
            FiltrGroupBox.SuspendLayout();
            ReportContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // CreateButton
            // 
            CreateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateButton.Location = new Point(1018, 12);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(90, 29);
            CreateButton.TabIndex = 0;
            CreateButton.Text = "Добавить";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateItemButton_Click;
            // 
            // NextPageButton
            // 
            NextPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NextPageButton.Location = new Point(1114, 600);
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
            PreviousPageButton.Location = new Point(978, 600);
            PreviousPageButton.Name = "PreviousPageButton";
            PreviousPageButton.Size = new Size(130, 29);
            PreviousPageButton.TabIndex = 3;
            PreviousPageButton.Text = "Пред. страница";
            PreviousPageButton.UseVisualStyleBackColor = true;
            PreviousPageButton.Click += PreviousPageButton_Click;
            // 
            // NumberOfPage
            // 
            NumberOfPage.Anchor = AnchorStyles.Bottom;
            NumberOfPage.Location = new Point(660, 602);
            NumberOfPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberOfPage.Name = "NumberOfPage";
            NumberOfPage.Size = new Size(64, 27);
            NumberOfPage.TabIndex = 4;
            NumberOfPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SelectPageButton
            // 
            SelectPageButton.Anchor = AnchorStyles.Bottom;
            SelectPageButton.Location = new Point(730, 600);
            SelectPageButton.Name = "SelectPageButton";
            SelectPageButton.Size = new Size(95, 29);
            SelectPageButton.TabIndex = 5;
            SelectPageButton.Text = "Перейти";
            SelectPageButton.UseVisualStyleBackColor = true;
            SelectPageButton.Click += ForwardToPage_Click;
            // 
            // PagesSize
            // 
            PagesSize.Anchor = AnchorStyles.Bottom;
            PagesSize.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            PagesSize.Location = new Point(490, 602);
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
            NumberPageLabel.Anchor = AnchorStyles.Bottom;
            NumberPageLabel.Location = new Point(577, 594);
            NumberPageLabel.Name = "NumberPageLabel";
            NumberPageLabel.Size = new Size(77, 40);
            NumberPageLabel.TabIndex = 7;
            NumberPageLabel.Text = "Номер\r\nстраницы";
            NumberPageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CountLabel
            // 
            CountLabel.Anchor = AnchorStyles.Bottom;
            CountLabel.Location = new Point(284, 594);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(200, 40);
            CountLabel.TabIndex = 8;
            CountLabel.Text = "Количество отображаемых\r\nэлементов";
            CountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewDataGridView
            // 
            ViewDataGridView.AllowUserToAddRows = false;
            ViewDataGridView.AllowUserToDeleteRows = false;
            ViewDataGridView.AllowUserToOrderColumns = true;
            ViewDataGridView.AllowUserToResizeRows = false;
            ViewDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewDataGridView.Location = new Point(12, 47);
            ViewDataGridView.MultiSelect = false;
            ViewDataGridView.Name = "ViewDataGridView";
            ViewDataGridView.ReadOnly = true;
            ViewDataGridView.RowHeadersVisible = false;
            ViewDataGridView.RowHeadersWidth = 51;
            ViewDataGridView.RowTemplate.Height = 24;
            ViewDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ViewDataGridView.Size = new Size(1232, 547);
            ViewDataGridView.TabIndex = 9;
            ViewDataGridView.ColumnHeaderMouseClick += OrgDataGrid_ColumnHeaderMouseClick;
            ViewDataGridView.MouseDoubleClick += OrgDataGrid_MouseDoubleClick;
            ViewDataGridView.MouseDown += OrgDataGrid_MouseDown;
            // 
            // label1
            // 
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 13;
            label1.Text = "Отчеты";
            // 
            // ExportButton
            // 
            ExportButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExportButton.Location = new Point(1114, 12);
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
            FiltrGroupBox.Location = new Point(12, 96);
            FiltrGroupBox.Name = "FiltrGroupBox";
            FiltrGroupBox.Size = new Size(245, 100);
            FiltrGroupBox.TabIndex = 16;
            FiltrGroupBox.TabStop = false;
            FiltrGroupBox.Text = "Фильтр";
            FiltrGroupBox.Visible = false;
            // 
            // ClearFiltrsButton
            // 
            ClearFiltrsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearFiltrsButton.Location = new Point(52, 65);
            ClearFiltrsButton.Name = "ClearFiltrsButton";
            ClearFiltrsButton.Size = new Size(94, 29);
            ClearFiltrsButton.TabIndex = 3;
            ClearFiltrsButton.Text = "Сбросить";
            ClearFiltrsButton.UseVisualStyleBackColor = true;
            ClearFiltrsButton.Click += ClearFiltrsButton_Click;
            // 
            // AcceptFiltrButton
            // 
            AcceptFiltrButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AcceptFiltrButton.Location = new Point(152, 65);
            AcceptFiltrButton.Name = "AcceptFiltrButton";
            AcceptFiltrButton.Size = new Size(87, 29);
            AcceptFiltrButton.TabIndex = 2;
            AcceptFiltrButton.Text = "Принять";
            AcceptFiltrButton.UseVisualStyleBackColor = true;
            AcceptFiltrButton.Click += AcceptFiltrButton_Click;
            // 
            // FiltrTextBox
            // 
            FiltrTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FiltrTextBox.Location = new Point(6, 26);
            FiltrTextBox.Name = "FiltrTextBox";
            FiltrTextBox.Size = new Size(233, 27);
            FiltrTextBox.TabIndex = 1;
            // 
            // ReportContextMenuStrip
            // 
            ReportContextMenuStrip.ImageScalingSize = new Size(20, 20);
            ReportContextMenuStrip.Items.AddRange(new ToolStripItem[] { ChangeToolStripMenuItem, DeleteToolStripMenuItem });
            ReportContextMenuStrip.Name = "OrganizationContextMenuStrip";
            ReportContextMenuStrip.Size = new Size(211, 80);
            // 
            // ChangeToolStripMenuItem
            // 
            ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem";
            ChangeToolStripMenuItem.Size = new Size(210, 24);
            ChangeToolStripMenuItem.Text = "Изменить";
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new Size(210, 24);
            DeleteToolStripMenuItem.Text = "Удалить";
            DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // ReportView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 641);
            Controls.Add(FiltrGroupBox);
            Controls.Add(ExportButton);
            Controls.Add(label1);
            Controls.Add(ViewDataGridView);
            Controls.Add(CountLabel);
            Controls.Add(NumberPageLabel);
            Controls.Add(PagesSize);
            Controls.Add(SelectPageButton);
            Controls.Add(NumberOfPage);
            Controls.Add(PreviousPageButton);
            Controls.Add(NextPageButton);
            Controls.Add(CreateButton);
            Name = "ReportView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реестр";
            ((System.ComponentModel.ISupportInitialize)NumberOfPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)PagesSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewDataGridView).EndInit();
            FiltrGroupBox.ResumeLayout(false);
            FiltrGroupBox.PerformLayout();
            ReportContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
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
        private DataGridView ViewDataGridView;
        private Label label1;
        private Button ExportButton;
        private GroupBox FiltrGroupBox;
        private TextBox FiltrTextBox;
        private Button AcceptFiltrButton;
        private Button ClearFiltrsButton;
        private ContextMenuStrip ReportContextMenuStrip;
        private ToolStripMenuItem ChangeToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
    }
}

