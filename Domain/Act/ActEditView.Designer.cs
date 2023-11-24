namespace PetsClient.Act
{
    partial class ActEditView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActEditView));
            OkButton = new Button();
            CancelButton = new Button();
            label1 = new Label();
            DateOfCapDateTimePicker = new DateTimePicker();
            ExecutorComboBox = new ComboBox();
            AnimalsDataGridView = new DataGridView();
            AddAnimalButton = new Button();
            label2 = new Label();
            AddFileButton = new Button();
            ScanContextMenuStrip = new ContextMenuStrip(components);
            DelScanToolStripMenuItem = new ToolStripMenuItem();
            DataContextMenuStrip = new ContextMenuStrip(components);
            ChangeAnimalToolStripMenuItem = new ToolStripMenuItem();
            DeleteAnimalToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            ContractsComboBox = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            PrevScanButton = new Button();
            NextScanButton = new Button();
            ScanPictureBox = new PictureBox();
            LocalityComboBox = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)AnimalsDataGridView).BeginInit();
            ScanContextMenuStrip.SuspendLayout();
            DataContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ScanPictureBox).BeginInit();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OkButton.DialogResult = DialogResult.OK;
            OkButton.Location = new Point(444, 519);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 29);
            OkButton.TabIndex = 0;
            OkButton.Text = "Ок";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.Location = new Point(525, 519);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 29);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 2;
            label1.Text = "Исполнитель";
            // 
            // DateOfCapDateTimePicker
            // 
            DateOfCapDateTimePicker.Location = new Point(12, 210);
            DateOfCapDateTimePicker.Name = "DateOfCapDateTimePicker";
            DateOfCapDateTimePicker.Size = new Size(195, 27);
            DateOfCapDateTimePicker.TabIndex = 3;
            DateOfCapDateTimePicker.Value = new DateTime(2023, 11, 24, 0, 0, 0, 0);
            // 
            // OrgsComboBox
            // 
            ExecutorComboBox.FormattingEnabled = true;
            ExecutorComboBox.Location = new Point(12, 86);
            ExecutorComboBox.Name = "OrgsComboBox";
            ExecutorComboBox.Size = new Size(295, 28);
            ExecutorComboBox.TabIndex = 4;
            // 
            // AnimalsDataGridView
            // 
            AnimalsDataGridView.AllowUserToAddRows = false;
            AnimalsDataGridView.AllowUserToDeleteRows = false;
            AnimalsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AnimalsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AnimalsDataGridView.Location = new Point(12, 302);
            AnimalsDataGridView.MultiSelect = false;
            AnimalsDataGridView.Name = "AnimalsDataGridView";
            AnimalsDataGridView.ReadOnly = true;
            AnimalsDataGridView.RowHeadersVisible = false;
            AnimalsDataGridView.RowHeadersWidth = 51;
            AnimalsDataGridView.RowTemplate.Height = 24;
            AnimalsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AnimalsDataGridView.Size = new Size(588, 211);
            AnimalsDataGridView.TabIndex = 5;
            AnimalsDataGridView.DataBindingComplete += AnimalsDataGridView_DataBindingComplete;
            AnimalsDataGridView.MouseDoubleClick += AnimalsDataGridView_MouseDoubleClick;
            AnimalsDataGridView.MouseDown += AnimalsDataGridView_MouseDown;
            // 
            // AddAnimalButton
            // 
            AddAnimalButton.Location = new Point(475, 267);
            AddAnimalButton.Name = "AddAnimalButton";
            AddAnimalButton.Size = new Size(125, 29);
            AddAnimalButton.TabIndex = 6;
            AddAnimalButton.Text = "Добавить";
            AddAnimalButton.UseVisualStyleBackColor = true;
            AddAnimalButton.Click += AddAnimalButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 187);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 7;
            label2.Text = "Дата отлова";
            // 
            // AddFileButton
            // 
            AddFileButton.Location = new Point(344, 267);
            AddFileButton.Name = "AddFileButton";
            AddFileButton.Size = new Size(125, 29);
            AddFileButton.TabIndex = 30;
            AddFileButton.Text = "Загрузить файл";
            AddFileButton.UseVisualStyleBackColor = true;
            AddFileButton.Click += AddFileButton_Click;
            // 
            // ScanContextMenuStrip
            // 
            ScanContextMenuStrip.ImageScalingSize = new Size(20, 20);
            ScanContextMenuStrip.Items.AddRange(new ToolStripItem[] { DelScanToolStripMenuItem });
            ScanContextMenuStrip.Name = "ScanContextMenuStrip";
            ScanContextMenuStrip.Size = new Size(135, 28);
            // 
            // DelScanToolStripMenuItem
            // 
            DelScanToolStripMenuItem.Name = "DelScanToolStripMenuItem";
            DelScanToolStripMenuItem.Size = new Size(134, 24);
            DelScanToolStripMenuItem.Text = "Удалить";
            DelScanToolStripMenuItem.Click += DelScanToolStripMenuItem_Click;
            // 
            // DataContextMenuStrip
            // 
            DataContextMenuStrip.ImageScalingSize = new Size(20, 20);
            DataContextMenuStrip.Items.AddRange(new ToolStripItem[] { ChangeAnimalToolStripMenuItem, DeleteAnimalToolStripMenuItem });
            DataContextMenuStrip.Name = "DataContextMenuStrip";
            DataContextMenuStrip.Size = new Size(148, 52);
            // 
            // ChangeAnimalToolStripMenuItem
            // 
            ChangeAnimalToolStripMenuItem.Name = "ChangeAnimalToolStripMenuItem";
            ChangeAnimalToolStripMenuItem.Size = new Size(147, 24);
            ChangeAnimalToolStripMenuItem.Text = "Изменить";
            ChangeAnimalToolStripMenuItem.Click += ChangeAnimalToolStripMenuItem_Click;
            // 
            // DeleteAnimalToolStripMenuItem
            // 
            DeleteAnimalToolStripMenuItem.Name = "DeleteAnimalToolStripMenuItem";
            DeleteAnimalToolStripMenuItem.Size = new Size(147, 24);
            DeleteAnimalToolStripMenuItem.Text = "Удалить";
            DeleteAnimalToolStripMenuItem.Click += DeleteAnimalToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 33;
            label3.Text = "Контракт";
            // 
            // ContractsComboBox
            // 
            ContractsComboBox.FormattingEnabled = true;
            ContractsComboBox.Location = new Point(12, 32);
            ContractsComboBox.Name = "ContractsComboBox";
            ContractsComboBox.Size = new Size(295, 28);
            ContractsComboBox.TabIndex = 34;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "\"png|*.png|*.jpg|\"";
            // 
            // PrevScanButton
            // 
            PrevScanButton.Location = new Point(316, 120);
            PrevScanButton.Name = "PrevScanButton";
            PrevScanButton.Size = new Size(26, 32);
            PrevScanButton.TabIndex = 35;
            PrevScanButton.UseVisualStyleBackColor = true;
            PrevScanButton.Click += PrevScanButton_Click;
            // 
            // NextScanButton
            // 
            NextScanButton.Image = (Image)resources.GetObject("NextScanButton.Image");
            NextScanButton.Location = new Point(574, 120);
            NextScanButton.Name = "NextScanButton";
            NextScanButton.Size = new Size(26, 32);
            NextScanButton.TabIndex = 28;
            NextScanButton.UseVisualStyleBackColor = true;
            NextScanButton.Click += NextScanButton_Click;
            // 
            // ScanPictureBox
            // 
            ScanPictureBox.ContextMenuStrip = ScanContextMenuStrip;
            ScanPictureBox.Location = new Point(348, 12);
            ScanPictureBox.Name = "ScanPictureBox";
            ScanPictureBox.Size = new Size(220, 249);
            ScanPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            ScanPictureBox.TabIndex = 27;
            ScanPictureBox.TabStop = false;
            // 
            // LocalityComboBox
            // 
            LocalityComboBox.FormattingEnabled = true;
            LocalityComboBox.Location = new Point(12, 140);
            LocalityComboBox.Name = "LocalityComboBox";
            LocalityComboBox.Size = new Size(295, 28);
            LocalityComboBox.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 36;
            label4.Text = "Населенный пункт";
            // 
            // ActEditView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(612, 560);
            Controls.Add(LocalityComboBox);
            Controls.Add(label4);
            Controls.Add(PrevScanButton);
            Controls.Add(ContractsComboBox);
            Controls.Add(label3);
            Controls.Add(AddFileButton);
            Controls.Add(NextScanButton);
            Controls.Add(ScanPictureBox);
            Controls.Add(label2);
            Controls.Add(AddAnimalButton);
            Controls.Add(AnimalsDataGridView);
            Controls.Add(ExecutorComboBox);
            Controls.Add(DateOfCapDateTimePicker);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Name = "ActEditView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Акт";
            ((System.ComponentModel.ISupportInitialize)AnimalsDataGridView).EndInit();
            ScanContextMenuStrip.ResumeLayout(false);
            DataContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ScanPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OkButton;
        private Button CancelButton;
        private Label label1;
        private DateTimePicker DateOfCapDateTimePicker;
        private ComboBox ExecutorComboBox;
        private DataGridView AnimalsDataGridView;
        private Button AddAnimalButton;
        private Label label2;
        private Button AddFileButton;
        private Button NextScanButton;
        private PictureBox ScanPictureBox;
        private ContextMenuStrip DataContextMenuStrip;
        private ToolStripMenuItem ChangeAnimalToolStripMenuItem;
        private ToolStripMenuItem DeleteAnimalToolStripMenuItem;
        private ContextMenuStrip ScanContextMenuStrip;
        private ToolStripMenuItem DelScanToolStripMenuItem;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdenLabel;
        private DataGridViewTextBoxColumn ChipNumber;
        private DataGridViewTextBoxColumn Locality;
        private Label label3;
        private ComboBox ContractsComboBox;
        private OpenFileDialog openFileDialog1;
        private Button PrevScanButton;
        private ComboBox LocalityComboBox;
        private Label label4;
    }
}