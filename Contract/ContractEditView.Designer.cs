namespace PetsClient.Contract
{
    partial class ContractEditView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractEditView));
            CancelButton = new Button();
            OkButton = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            ClientComboBox = new ComboBox();
            NumberTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            LocalsPricesDataGridView = new DataGridView();
            localityViewBindingSource = new BindingSource(components);
            LocalPriceContextMenuStrip = new ContextMenuStrip(components);
            UpdateToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            contractContentViewBindingSource = new BindingSource(components);
            DateOfConclusionDateTimePicker = new DateTimePicker();
            DateValidDateTimePicker = new DateTimePicker();
            ExecutorComboBox = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            NextScanButton = new Button();
            PrevScanButton = new Button();
            ScanPictureBox = new PictureBox();
            ImageContextMenuStrip = new ContextMenuStrip(components);
            DeleteImageToolStripMenuItem = new ToolStripMenuItem();
            AddLocalPriceButton = new Button();
            AddFileButton = new Button();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)LocalsPricesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)localityViewBindingSource).BeginInit();
            LocalPriceContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contractContentViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ScanPictureBox).BeginInit();
            ImageContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(767, 463);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 29);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(686, 463);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 29);
            OkButton.TabIndex = 15;
            OkButton.Text = "Ок";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 222);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 13;
            label7.Text = "Заказчик";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 168);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 12;
            label6.Text = "Исполнитель";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 115);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 11;
            label5.Text = "Дата действия";
            // 
            // ClientComboBox
            // 
            ClientComboBox.FormattingEnabled = true;
            ClientComboBox.Location = new Point(12, 245);
            ClientComboBox.Name = "ClientComboBox";
            ClientComboBox.Size = new Size(309, 28);
            ClientComboBox.TabIndex = 9;
            // 
            // NumberTextBox
            // 
            NumberTextBox.Location = new Point(12, 32);
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.Size = new Size(309, 27);
            NumberTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 62);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 4;
            label4.Text = "Дата заключения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Номер";
            // 
            // LocalsPricesDataGridView
            // 
            LocalsPricesDataGridView.AllowUserToAddRows = false;
            LocalsPricesDataGridView.AllowUserToDeleteRows = false;
            LocalsPricesDataGridView.AutoGenerateColumns = false;
            LocalsPricesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LocalsPricesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LocalsPricesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            LocalsPricesDataGridView.ContextMenuStrip = LocalPriceContextMenuStrip;
            LocalsPricesDataGridView.DataSource = contractContentViewBindingSource;
            LocalsPricesDataGridView.Location = new Point(12, 279);
            LocalsPricesDataGridView.MultiSelect = false;
            LocalsPricesDataGridView.Name = "LocalsPricesDataGridView";
            LocalsPricesDataGridView.ReadOnly = true;
            LocalsPricesDataGridView.RowHeadersVisible = false;
            LocalsPricesDataGridView.RowHeadersWidth = 51;
            LocalsPricesDataGridView.RowTemplate.Height = 24;
            LocalsPricesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LocalsPricesDataGridView.Size = new Size(834, 178);
            LocalsPricesDataGridView.TabIndex = 17;
            LocalsPricesDataGridView.DataError += LocalsPricesDataGridView_DataError;
            LocalsPricesDataGridView.MouseDown += LocalsPricesDataGridView_MouseDown;
            // 
            // localityViewBindingSource
            // 
            localityViewBindingSource.DataSource = typeof(ModelLibrary.Model.Etc.LocalityView);
            // 
            // LocalPriceContextMenuStrip
            // 
            LocalPriceContextMenuStrip.ImageScalingSize = new Size(20, 20);
            LocalPriceContextMenuStrip.Items.AddRange(new ToolStripItem[] { UpdateToolStripMenuItem, DeleteToolStripMenuItem });
            LocalPriceContextMenuStrip.Name = "contextMenuStrip1";
            LocalPriceContextMenuStrip.Size = new Size(148, 52);
            // 
            // UpdateToolStripMenuItem
            // 
            UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            UpdateToolStripMenuItem.Size = new Size(147, 24);
            UpdateToolStripMenuItem.Text = "Изменить";
            UpdateToolStripMenuItem.Click += UpdateToolStripMenuItem_Click;
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new Size(147, 24);
            DeleteToolStripMenuItem.Text = "Удалить";
            DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // contractContentViewBindingSource
            // 
            contractContentViewBindingSource.DataSource = typeof(ModelLibrary.Model.Contract.ContractContentView);
            // 
            // DateOfConclusionDateTimePicker
            // 
            DateOfConclusionDateTimePicker.Location = new Point(12, 85);
            DateOfConclusionDateTimePicker.Name = "DateOfConclusionDateTimePicker";
            DateOfConclusionDateTimePicker.Size = new Size(206, 27);
            DateOfConclusionDateTimePicker.TabIndex = 18;
            // 
            // DateValidDateTimePicker
            // 
            DateValidDateTimePicker.Location = new Point(12, 138);
            DateValidDateTimePicker.Name = "DateValidDateTimePicker";
            DateValidDateTimePicker.Size = new Size(206, 27);
            DateValidDateTimePicker.TabIndex = 19;
            // 
            // ExecutorComboBox
            // 
            ExecutorComboBox.FormattingEnabled = true;
            ExecutorComboBox.Location = new Point(12, 191);
            ExecutorComboBox.Name = "ExecutorComboBox";
            ExecutorComboBox.Size = new Size(309, 28);
            ExecutorComboBox.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "\"png|*.png|*.jpg|\"";
            // 
            // NextScanButton
            // 
            NextScanButton.Image = (Image)resources.GetObject("NextScanButton.Image");
            NextScanButton.Location = new Point(823, 109);
            NextScanButton.Name = "NextScanButton";
            NextScanButton.Size = new Size(26, 32);
            NextScanButton.TabIndex = 23;
            NextScanButton.UseVisualStyleBackColor = true;
            NextScanButton.Click += NextScanButton_Click;
            // 
            // PrevScanButton
            // 
            PrevScanButton.Image = (Image)resources.GetObject("PrevScanButton.Image");
            PrevScanButton.Location = new Point(581, 109);
            PrevScanButton.Name = "PrevScanButton";
            PrevScanButton.Size = new Size(26, 32);
            PrevScanButton.TabIndex = 24;
            PrevScanButton.UseVisualStyleBackColor = true;
            PrevScanButton.Click += PrevScanButton_Click;
            // 
            // ScanPictureBox
            // 
            ScanPictureBox.ContextMenuStrip = ImageContextMenuStrip;
            ScanPictureBox.Location = new Point(613, 12);
            ScanPictureBox.Name = "ScanPictureBox";
            ScanPictureBox.Size = new Size(204, 226);
            ScanPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            ScanPictureBox.TabIndex = 22;
            ScanPictureBox.TabStop = false;
            ScanPictureBox.DoubleClick += ScanPictureBox_DoubleClick;
            // 
            // ImageContextMenuStrip
            // 
            ImageContextMenuStrip.ImageScalingSize = new Size(20, 20);
            ImageContextMenuStrip.Items.AddRange(new ToolStripItem[] { DeleteImageToolStripMenuItem });
            ImageContextMenuStrip.Name = "ImageContextMenuStrip";
            ImageContextMenuStrip.Size = new Size(135, 28);
            // 
            // DeleteImageToolStripMenuItem
            // 
            DeleteImageToolStripMenuItem.Name = "DeleteImageToolStripMenuItem";
            DeleteImageToolStripMenuItem.Size = new Size(134, 24);
            DeleteImageToolStripMenuItem.Text = "Удалить";
            DeleteImageToolStripMenuItem.Click += DeleteImageToolStripMenuItem_Click;
            // 
            // AddLocalPriceButton
            // 
            AddLocalPriceButton.Location = new Point(581, 244);
            AddLocalPriceButton.Name = "AddLocalPriceButton";
            AddLocalPriceButton.Size = new Size(120, 29);
            AddLocalPriceButton.TabIndex = 25;
            AddLocalPriceButton.Text = "Добавить";
            AddLocalPriceButton.UseVisualStyleBackColor = true;
            AddLocalPriceButton.Click += AddLocalPriceButton_Click;
            // 
            // AddFileButton
            // 
            AddFileButton.Location = new Point(707, 245);
            AddFileButton.Name = "AddFileButton";
            AddFileButton.Size = new Size(139, 29);
            AddFileButton.TabIndex = 26;
            AddFileButton.Text = "Загрузить файл";
            AddFileButton.UseVisualStyleBackColor = true;
            AddFileButton.Click += AddFileButton_Click;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            dataGridViewTextBoxColumn4.HeaderText = "Идентификатор";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            dataGridViewTextBoxColumn5.HeaderText = "Цена";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Locality";
            dataGridViewTextBoxColumn6.HeaderText = "Населенный пункт";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Resizable = DataGridViewTriState.True;
            // 
            // ContractEditView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(854, 504);
            Controls.Add(AddFileButton);
            Controls.Add(AddLocalPriceButton);
            Controls.Add(PrevScanButton);
            Controls.Add(NextScanButton);
            Controls.Add(ScanPictureBox);
            Controls.Add(ExecutorComboBox);
            Controls.Add(DateValidDateTimePicker);
            Controls.Add(DateOfConclusionDateTimePicker);
            Controls.Add(LocalsPricesDataGridView);
            Controls.Add(label3);
            Controls.Add(CancelButton);
            Controls.Add(label4);
            Controls.Add(OkButton);
            Controls.Add(NumberTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(ClientComboBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ContractEditView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Контракт";
            ((System.ComponentModel.ISupportInitialize)LocalsPricesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)localityViewBindingSource).EndInit();
            LocalPriceContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)contractContentViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ScanPictureBox).EndInit();
            ImageContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CancelButton;
        private Button OkButton;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox ClientComboBox;
        private TextBox NumberTextBox;
        private Label label4;
        private Label label3;
        private DataGridView LocalsPricesDataGridView;
        private DateTimePicker DateOfConclusionDateTimePicker;
        private DateTimePicker DateValidDateTimePicker;
        private ComboBox ExecutorComboBox;
        private OpenFileDialog openFileDialog1;
        private PictureBox ScanPictureBox;
        private Button NextScanButton;
        private Button PrevScanButton;
        private Button AddLocalPriceButton;
        private ContextMenuStrip ImageContextMenuStrip;
        private ToolStripMenuItem DeleteImageToolStripMenuItem;
        private ContextMenuStrip LocalPriceContextMenuStrip;
        private ToolStripMenuItem UpdateToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private Button AddFileButton;
        private BindingSource contractContentViewBindingSource;
        private BindingSource localityViewBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}