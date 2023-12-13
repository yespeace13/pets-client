using ModelLibrary.Model.Organization;

namespace PetsClient.Domain.Log
{
    partial class LogView
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
            LogContextMenuStrip = new ContextMenuStrip(components);
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            FiltrGroupBox = new GroupBox();
            FiltrEndDateTimePicker = new DateTimePicker();
            FiltrStartDateTimePicker = new DateTimePicker();
            ClearFiltrsButton = new Button();
            AcceptFiltrButton = new Button();
            FiltrTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NumberOfPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PagesSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewDataGridView).BeginInit();
            LogContextMenuStrip.SuspendLayout();
            FiltrGroupBox.SuspendLayout();
            SuspendLayout();
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
            // LogContextMenuStrip
            // 
            LogContextMenuStrip.ImageScalingSize = new Size(20, 20);
            LogContextMenuStrip.Items.AddRange(new ToolStripItem[] { DeleteToolStripMenuItem });
            LogContextMenuStrip.Name = "OrganizationContextMenuStrip";
            LogContextMenuStrip.Size = new Size(135, 28);
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new Size(134, 24);
            DeleteToolStripMenuItem.Text = "Удалить";
            DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // FiltrGroupBox
            // 
            FiltrGroupBox.Controls.Add(FiltrEndDateTimePicker);
            FiltrGroupBox.Controls.Add(FiltrStartDateTimePicker);
            FiltrGroupBox.Controls.Add(ClearFiltrsButton);
            FiltrGroupBox.Controls.Add(AcceptFiltrButton);
            FiltrGroupBox.Controls.Add(FiltrTextBox);
            FiltrGroupBox.Location = new Point(181, 144);
            FiltrGroupBox.Name = "FiltrGroupBox";
            FiltrGroupBox.Size = new Size(229, 127);
            FiltrGroupBox.TabIndex = 18;
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
            FiltrStartDateTimePicker.Visible = false;
            // 
            // ClearFiltrsButton
            // 
            ClearFiltrsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ClearFiltrsButton.Location = new Point(40, 92);
            ClearFiltrsButton.Name = "ClearFiltrsButton";
            ClearFiltrsButton.Size = new Size(88, 29);
            ClearFiltrsButton.TabIndex = 3;
            ClearFiltrsButton.Text = "Сбросить";
            ClearFiltrsButton.UseVisualStyleBackColor = true;
            ClearFiltrsButton.Click += ClearFiltrsButton_Click;
            // 
            // AcceptFiltrButton
            // 
            AcceptFiltrButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AcceptFiltrButton.Location = new Point(134, 92);
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
            FiltrTextBox.Size = new Size(246, 27);
            FiltrTextBox.TabIndex = 1;
            // 
            // LogView
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
            Name = "LogView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реестр";
            ((System.ComponentModel.ISupportInitialize)NumberOfPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)PagesSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewDataGridView).EndInit();
            LogContextMenuStrip.ResumeLayout(false);
            FiltrGroupBox.ResumeLayout(false);
            FiltrGroupBox.PerformLayout();
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
        private DataGridView ViewDataGridView;
        private Label label1;
        private Button ExportButton;
        private ContextMenuStrip LogContextMenuStrip;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private DateTimePicker FiltrEndDateTimePicker;
        private DateTimePicker FiltrStartDateTimePicker;
        private Button ClearFiltrsButton;
        private Button AcceptFiltrButton;
        private TextBox FiltrTextBox;
        private GroupBox FiltrGroupBox;
    }
}

