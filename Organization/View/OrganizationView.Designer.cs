using ModelLibrary.Model.Organization;

namespace IS_5
{
    partial class OrganizationView
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
            CreateOrgButton = new Button();
            NextPageButton = new Button();
            PreviousPageButton = new Button();
            NumberOfPage = new NumericUpDown();
            SelectPageButton = new Button();
            PagesSize = new NumericUpDown();
            NumberPageLabel = new Label();
            CountLabel = new Label();
            OrgDataGrid = new DataGridView();
            organizationViewEditBindingSource = new BindingSource(components);
            OrganizationContextMenuStrip = new ContextMenuStrip(components);
            ChangeToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            ExportButton = new Button();
            FiltrGroupBox = new GroupBox();
            ClearFiltrsButton = new Button();
            AcceptFiltrButton = new Button();
            FiltrTextBox = new TextBox();
            organizationViewOneBindingSource = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)NumberOfPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PagesSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrgDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)organizationViewEditBindingSource).BeginInit();
            OrganizationContextMenuStrip.SuspendLayout();
            FiltrGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)organizationViewOneBindingSource).BeginInit();
            SuspendLayout();
            // 
            // CreateOrgButton
            // 
            CreateOrgButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateOrgButton.Location = new Point(975, 12);
            CreateOrgButton.Name = "CreateOrgButton";
            CreateOrgButton.Size = new Size(90, 29);
            CreateOrgButton.TabIndex = 0;
            CreateOrgButton.Text = "Добавить";
            CreateOrgButton.UseVisualStyleBackColor = true;
            CreateOrgButton.Click += CreateOrgButton_Click;
            // 
            // NextPageButton
            // 
            NextPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NextPageButton.Location = new Point(1071, 475);
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
            PreviousPageButton.Location = new Point(935, 475);
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
            NumberOfPage.Location = new Point(638, 477);
            NumberOfPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberOfPage.Name = "NumberOfPage";
            NumberOfPage.Size = new Size(64, 27);
            NumberOfPage.TabIndex = 4;
            NumberOfPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SelectPageButton
            // 
            SelectPageButton.Anchor = AnchorStyles.Bottom;
            SelectPageButton.Location = new Point(708, 475);
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
            PagesSize.Location = new Point(468, 477);
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
            NumberPageLabel.Location = new Point(555, 469);
            NumberPageLabel.Name = "NumberPageLabel";
            NumberPageLabel.Size = new Size(77, 40);
            NumberPageLabel.TabIndex = 7;
            NumberPageLabel.Text = "Номер\r\nстраницы";
            NumberPageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CountLabel
            // 
            CountLabel.Anchor = AnchorStyles.Bottom;
            CountLabel.Location = new Point(262, 469);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(200, 40);
            CountLabel.TabIndex = 8;
            CountLabel.Text = "Количество отображаемых\r\nэлементов";
            CountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrgDataGrid
            // 
            OrgDataGrid.AllowUserToAddRows = false;
            OrgDataGrid.AllowUserToDeleteRows = false;
            OrgDataGrid.AllowUserToOrderColumns = true;
            OrgDataGrid.AllowUserToResizeRows = false;
            OrgDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrgDataGrid.AutoGenerateColumns = false;
            OrgDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrgDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrgDataGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            OrgDataGrid.DataSource = organizationViewOneBindingSource;
            OrgDataGrid.Location = new Point(12, 47);
            OrgDataGrid.MultiSelect = false;
            OrgDataGrid.Name = "OrgDataGrid";
            OrgDataGrid.ReadOnly = true;
            OrgDataGrid.RowHeadersVisible = false;
            OrgDataGrid.RowHeadersWidth = 51;
            OrgDataGrid.RowTemplate.Height = 24;
            OrgDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrgDataGrid.Size = new Size(1189, 422);
            OrgDataGrid.TabIndex = 9;
            OrgDataGrid.ColumnHeaderMouseClick += OrgDataGrid_ColumnHeaderMouseClick;
            OrgDataGrid.MouseDoubleClick += OrgDataGrid_MouseDoubleClick;
            OrgDataGrid.MouseDown += OrgDataGrid_MouseDown;
            // 
            // OrganizationContextMenuStrip
            // 
            OrganizationContextMenuStrip.ImageScalingSize = new Size(20, 20);
            OrganizationContextMenuStrip.Items.AddRange(new ToolStripItem[] { ChangeToolStripMenuItem, DeleteToolStripMenuItem });
            OrganizationContextMenuStrip.Name = "OrganizationContextMenuStrip";
            OrganizationContextMenuStrip.Size = new Size(148, 52);
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
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 13;
            label1.Text = "Организации";
            // 
            // ExportButton
            // 
            ExportButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExportButton.Location = new Point(1071, 12);
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
            // organizationViewOneBindingSource
            // 
            organizationViewOneBindingSource.DataSource = typeof(OrganizationViewList);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Код";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "NameOrganization";
            dataGridViewTextBoxColumn2.HeaderText = "Название организации";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "INN";
            dataGridViewTextBoxColumn3.HeaderText = "ИНН";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "KPP";
            dataGridViewTextBoxColumn4.HeaderText = "КПП";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Address";
            dataGridViewTextBoxColumn5.HeaderText = "Адрес";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "TypeOrganization";
            dataGridViewTextBoxColumn6.HeaderText = "Тип организации";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "LegalType";
            dataGridViewTextBoxColumn7.HeaderText = "Юридический тип";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Locality";
            dataGridViewTextBoxColumn8.HeaderText = "Муниципалитет";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // OrganizationView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 516);
            Controls.Add(FiltrGroupBox);
            Controls.Add(ExportButton);
            Controls.Add(label1);
            Controls.Add(OrgDataGrid);
            Controls.Add(CountLabel);
            Controls.Add(NumberPageLabel);
            Controls.Add(PagesSize);
            Controls.Add(SelectPageButton);
            Controls.Add(NumberOfPage);
            Controls.Add(PreviousPageButton);
            Controls.Add(NextPageButton);
            Controls.Add(CreateOrgButton);
            Name = "OrganizationView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реестр";
            ((System.ComponentModel.ISupportInitialize)NumberOfPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)PagesSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrgDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)organizationViewEditBindingSource).EndInit();
            OrganizationContextMenuStrip.ResumeLayout(false);
            FiltrGroupBox.ResumeLayout(false);
            FiltrGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)organizationViewOneBindingSource).EndInit();
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
        private Button CreateOrgButton;
        private DataGridView OrgDataGrid;
        private Label label1;
        private Button ExportButton;
        private ContextMenuStrip OrganizationContextMenuStrip;
        private ToolStripMenuItem ChangeToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private GroupBox FiltrGroupBox;
        private TextBox FiltrTextBox;
        private Button AcceptFiltrButton;
        private Button ClearFiltrsButton;
        private BindingSource organizationViewEditBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameOrganizationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kPPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeOrganizationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn legalTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn localityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private BindingSource organizationViewOneBindingSource;
    }
}

