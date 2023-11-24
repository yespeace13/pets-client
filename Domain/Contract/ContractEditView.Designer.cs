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
            IdDataGridViewColumn = new DataGridViewTextBoxColumn();
            PriceDataGridViewColumn = new DataGridViewTextBoxColumn();
            LocalityDataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
            ContractContentContextMenuStrip = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            DateOfConclusionDateTimePicker = new DateTimePicker();
            DateValidDateTimePicker = new DateTimePicker();
            ExecutorComboBox = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            NextScanButton = new Button();
            PrevScanButton = new Button();
            ScanPictureBox = new PictureBox();
            ImageContextMenuStrip = new ContextMenuStrip(components);
            DeleteImageToolStripMenuItem = new ToolStripMenuItem();
            AddFileButton = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)LocalsPricesDataGridView).BeginInit();
            ContractContentContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ScanPictureBox).BeginInit();
            ImageContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(597, 463);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(143, 29);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(448, 463);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(143, 29);
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
            LocalsPricesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LocalsPricesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LocalsPricesDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdDataGridViewColumn, PriceDataGridViewColumn, LocalityDataGridViewComboBoxColumn });
            LocalsPricesDataGridView.ContextMenuStrip = ContractContentContextMenuStrip;
            LocalsPricesDataGridView.Location = new Point(12, 279);
            LocalsPricesDataGridView.MultiSelect = false;
            LocalsPricesDataGridView.Name = "LocalsPricesDataGridView";
            LocalsPricesDataGridView.RowHeadersVisible = false;
            LocalsPricesDataGridView.RowHeadersWidth = 51;
            LocalsPricesDataGridView.RowTemplate.Height = 24;
            LocalsPricesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LocalsPricesDataGridView.Size = new Size(728, 178);
            LocalsPricesDataGridView.TabIndex = 17;
            LocalsPricesDataGridView.MouseDown += LocalsPricesDataGridView_MouseDown;
            // 
            // IdDataGridViewColumn
            // 
            IdDataGridViewColumn.HeaderText = "Идентификатор";
            IdDataGridViewColumn.MinimumWidth = 6;
            IdDataGridViewColumn.Name = "IdDataGridViewColumn";
            IdDataGridViewColumn.Visible = false;
            // 
            // PriceDataGridViewColumn
            // 
            PriceDataGridViewColumn.HeaderText = "Цена";
            PriceDataGridViewColumn.MinimumWidth = 6;
            PriceDataGridViewColumn.Name = "PriceDataGridViewColumn";
            // 
            // LocalityDataGridViewComboBoxColumn
            // 
            LocalityDataGridViewComboBoxColumn.HeaderText = "Населенный пункт";
            LocalityDataGridViewComboBoxColumn.MinimumWidth = 6;
            LocalityDataGridViewComboBoxColumn.Name = "LocalityDataGridViewComboBoxColumn";
            // 
            // ContractContentContextMenuStrip
            // 
            ContractContentContextMenuStrip.ImageScalingSize = new Size(20, 20);
            ContractContentContextMenuStrip.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem });
            ContractContentContextMenuStrip.Name = "ContractContentContextMenuStrip";
            ContractContentContextMenuStrip.Size = new Size(135, 28);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(134, 24);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
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
            NextScanButton.Location = new Point(714, 109);
            NextScanButton.Name = "NextScanButton";
            NextScanButton.Size = new Size(26, 32);
            NextScanButton.TabIndex = 23;
            NextScanButton.UseVisualStyleBackColor = true;
            NextScanButton.Click += NextScanButton_Click;
            // 
            // PrevScanButton
            // 
            PrevScanButton.Image = (Image)resources.GetObject("PrevScanButton.Image");
            PrevScanButton.Location = new Point(472, 109);
            PrevScanButton.Name = "PrevScanButton";
            PrevScanButton.Size = new Size(26, 32);
            PrevScanButton.TabIndex = 24;
            PrevScanButton.UseVisualStyleBackColor = true;
            PrevScanButton.Click += PrevScanButton_Click;
            // 
            // ScanPictureBox
            // 
            ScanPictureBox.ContextMenuStrip = ImageContextMenuStrip;
            ScanPictureBox.Location = new Point(504, 12);
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
            // AddFileButton
            // 
            AddFileButton.Location = new Point(537, 245);
            AddFileButton.Name = "AddFileButton";
            AddFileButton.Size = new Size(139, 29);
            AddFileButton.TabIndex = 26;
            AddFileButton.Text = "Загрузить файл";
            AddFileButton.UseVisualStyleBackColor = true;
            AddFileButton.Click += AddFileButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(504, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += ScanPictureBox_DoubleClick;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(714, 109);
            button1.Name = "button1";
            button1.Size = new Size(26, 32);
            button1.TabIndex = 23;
            button1.UseVisualStyleBackColor = true;
            button1.Click += NextScanButton_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(472, 109);
            button2.Name = "button2";
            button2.Size = new Size(26, 32);
            button2.TabIndex = 24;
            button2.UseVisualStyleBackColor = true;
            button2.Click += PrevScanButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(537, 245);
            button3.Name = "button3";
            button3.Size = new Size(139, 29);
            button3.TabIndex = 26;
            button3.Text = "Загрузить файл";
            button3.UseVisualStyleBackColor = true;
            button3.Click += AddFileButton_Click;
            // 
            // ContractEditView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(752, 504);
            Controls.Add(button3);
            Controls.Add(AddFileButton);
            Controls.Add(button2);
            Controls.Add(PrevScanButton);
            Controls.Add(button1);
            Controls.Add(NextScanButton);
            Controls.Add(pictureBox1);
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
            ContractContentContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ScanPictureBox).EndInit();
            ImageContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ContextMenuStrip ImageContextMenuStrip;
        private ToolStripMenuItem DeleteImageToolStripMenuItem;
        private Button AddFileButton;
        private BindingSource contractContentViewBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn localityDataGridViewTextBoxColumn;
        private ContextMenuStrip ContractContentContextMenuStrip;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private DataGridViewTextBoxColumn IdDataGridViewColumn;
        private DataGridViewTextBoxColumn PriceDataGridViewColumn;
        private DataGridViewComboBoxColumn LocalityDataGridViewComboBoxColumn;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}