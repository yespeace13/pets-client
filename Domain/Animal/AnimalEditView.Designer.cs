namespace PetsClient.Act
{
    partial class AnimalEditView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalEditView));
            label1 = new Label();
            CategoryTextBox = new TextBox();
            FemaleRadioButton = new RadioButton();
            SexGroupBox = new GroupBox();
            MaleRadioButton = new RadioButton();
            label2 = new Label();
            BreedTextBox = new TextBox();
            WoolTextBox = new TextBox();
            label3 = new Label();
            SizeNumericUpDown = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            ColorTextBox = new TextBox();
            EarsTextBox = new TextBox();
            label6 = new Label();
            TailTextBox = new TextBox();
            label7 = new Label();
            SpecialSignsTextBox = new TextBox();
            label8 = new Label();
            IdenLabelTextBox = new TextBox();
            label9 = new Label();
            PrevScanButton = new Button();
            AddFileButton = new Button();
            NextScanButton = new Button();
            ScanPictureBox = new PictureBox();
            ScanContextMenuStrip = new ContextMenuStrip(components);
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            ChipNumTextBox = new TextBox();
            label10 = new Label();
            OkButton = new Button();
            CancelButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            SexGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SizeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ScanPictureBox).BeginInit();
            ScanContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Категория";
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Location = new Point(12, 32);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(309, 27);
            CategoryTextBox.TabIndex = 1;
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.Checked = true;
            FemaleRadioButton.Location = new Point(6, 21);
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Size = new Size(73, 24);
            FemaleRadioButton.TabIndex = 3;
            FemaleRadioButton.TabStop = true;
            FemaleRadioButton.Text = "Самка";
            FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // SexGroupBox
            // 
            SexGroupBox.Controls.Add(MaleRadioButton);
            SexGroupBox.Controls.Add(FemaleRadioButton);
            SexGroupBox.Location = new Point(12, 65);
            SexGroupBox.Name = "SexGroupBox";
            SexGroupBox.Size = new Size(202, 49);
            SexGroupBox.TabIndex = 4;
            SexGroupBox.TabStop = false;
            SexGroupBox.Text = "Пол";
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Location = new Point(115, 21);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(75, 24);
            MaleRadioButton.TabIndex = 4;
            MaleRadioButton.Text = "Самец";
            MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 5;
            label2.Text = "Порода";
            // 
            // BreedTextBox
            // 
            BreedTextBox.Location = new Point(12, 136);
            BreedTextBox.Name = "BreedTextBox";
            BreedTextBox.Size = new Size(309, 27);
            BreedTextBox.TabIndex = 6;
            // 
            // WoolTextBox
            // 
            WoolTextBox.Location = new Point(12, 242);
            WoolTextBox.Name = "WoolTextBox";
            WoolTextBox.Size = new Size(309, 27);
            WoolTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 219);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 7;
            label3.Text = "Шерсть";
            // 
            // SizeNumericUpDown
            // 
            SizeNumericUpDown.DecimalPlaces = 2;
            SizeNumericUpDown.Location = new Point(12, 189);
            SizeNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            SizeNumericUpDown.Name = "SizeNumericUpDown";
            SizeNumericUpDown.Size = new Size(117, 27);
            SizeNumericUpDown.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 166);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 10;
            label4.Text = "Размер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 272);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 11;
            label5.Text = "Цвет";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(12, 295);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(309, 27);
            ColorTextBox.TabIndex = 12;
            // 
            // EarsTextBox
            // 
            EarsTextBox.Location = new Point(12, 348);
            EarsTextBox.Name = "EarsTextBox";
            EarsTextBox.Size = new Size(309, 27);
            EarsTextBox.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 325);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 13;
            label6.Text = "Уши";
            // 
            // TailTextBox
            // 
            TailTextBox.Location = new Point(12, 401);
            TailTextBox.Name = "TailTextBox";
            TailTextBox.Size = new Size(309, 27);
            TailTextBox.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 378);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 15;
            label7.Text = "Хвост";
            // 
            // SpecialSignsTextBox
            // 
            SpecialSignsTextBox.Location = new Point(12, 450);
            SpecialSignsTextBox.Multiline = true;
            SpecialSignsTextBox.Name = "SpecialSignsTextBox";
            SpecialSignsTextBox.Size = new Size(629, 71);
            SpecialSignsTextBox.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 431);
            label8.Name = "label8";
            label8.Size = new Size(131, 20);
            label8.TabIndex = 17;
            label8.Text = "Особые приметы";
            // 
            // IdenLabelTextBox
            // 
            IdenLabelTextBox.Location = new Point(332, 348);
            IdenLabelTextBox.Name = "IdenLabelTextBox";
            IdenLabelTextBox.Size = new Size(309, 27);
            IdenLabelTextBox.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(332, 325);
            label9.Name = "label9";
            label9.Size = new Size(199, 20);
            label9.TabIndex = 19;
            label9.Text = "Идентификационная метка";
            // 
            // PrevScanButton
            // 
            PrevScanButton.Location = new Point(332, 115);
            PrevScanButton.Name = "PrevScanButton";
            PrevScanButton.Size = new Size(26, 32);
            PrevScanButton.TabIndex = 39;
            PrevScanButton.UseVisualStyleBackColor = true;
            PrevScanButton.Click += PrevScanButton_Click;
            // 
            // AddFileButton
            // 
            AddFileButton.Location = new Point(389, 256);
            AddFileButton.Name = "AddFileButton";
            AddFileButton.Size = new Size(170, 29);
            AddFileButton.TabIndex = 38;
            AddFileButton.Text = "Загрузить файл";
            AddFileButton.UseVisualStyleBackColor = true;
            AddFileButton.Click += AddFileButton_Click;
            // 
            // NextScanButton
            // 
            NextScanButton.Image = (Image)resources.GetObject("NextScanButton.Image");
            NextScanButton.Location = new Point(590, 115);
            NextScanButton.Name = "NextScanButton";
            NextScanButton.Size = new Size(26, 32);
            NextScanButton.TabIndex = 37;
            NextScanButton.UseVisualStyleBackColor = true;
            NextScanButton.Click += NextScanButton_Click;
            // 
            // ScanPictureBox
            // 
            ScanPictureBox.ContextMenuStrip = ScanContextMenuStrip;
            ScanPictureBox.Location = new Point(364, 12);
            ScanPictureBox.Name = "ScanPictureBox";
            ScanPictureBox.Size = new Size(220, 238);
            ScanPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            ScanPictureBox.TabIndex = 36;
            ScanPictureBox.TabStop = false;
            ScanPictureBox.DoubleClick += ScanPictureBox_DoubleClick;
            // 
            // ScanContextMenuStrip
            // 
            ScanContextMenuStrip.ImageScalingSize = new Size(20, 20);
            ScanContextMenuStrip.Items.AddRange(new ToolStripItem[] { DeleteToolStripMenuItem });
            ScanContextMenuStrip.Name = "ScanContextMenuStrip";
            ScanContextMenuStrip.Size = new Size(135, 28);
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new Size(134, 24);
            DeleteToolStripMenuItem.Text = "Удалить";
            // 
            // ChipNumTextBox
            // 
            ChipNumTextBox.Location = new Point(332, 401);
            ChipNumTextBox.Name = "ChipNumTextBox";
            ChipNumTextBox.Size = new Size(309, 27);
            ChipNumTextBox.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(332, 378);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 40;
            label10.Text = "Номер чипа";
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OkButton.Location = new Point(398, 547);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(118, 29);
            OkButton.TabIndex = 44;
            OkButton.Text = "Ок";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.Location = new Point(522, 547);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(118, 29);
            CancelButton.TabIndex = 45;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AnimalView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(652, 588);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(ChipNumTextBox);
            Controls.Add(label10);
            Controls.Add(PrevScanButton);
            Controls.Add(AddFileButton);
            Controls.Add(NextScanButton);
            Controls.Add(ScanPictureBox);
            Controls.Add(IdenLabelTextBox);
            Controls.Add(label9);
            Controls.Add(SpecialSignsTextBox);
            Controls.Add(label8);
            Controls.Add(TailTextBox);
            Controls.Add(label7);
            Controls.Add(EarsTextBox);
            Controls.Add(label6);
            Controls.Add(ColorTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(SizeNumericUpDown);
            Controls.Add(WoolTextBox);
            Controls.Add(label3);
            Controls.Add(BreedTextBox);
            Controls.Add(label2);
            Controls.Add(SexGroupBox);
            Controls.Add(CategoryTextBox);
            Controls.Add(label1);
            Name = "AnimalView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Животное";
            SexGroupBox.ResumeLayout(false);
            SexGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SizeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ScanPictureBox).EndInit();
            ScanContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox CategoryTextBox;
        private RadioButton FemaleRadioButton;
        private GroupBox SexGroupBox;
        private RadioButton MaleRadioButton;
        private Label label2;
        private TextBox BreedTextBox;
        private TextBox WoolTextBox;
        private Label label3;
        private NumericUpDown SizeNumericUpDown;
        private Label label4;
        private Label label5;
        private TextBox ColorTextBox;
        private TextBox EarsTextBox;
        private Label label6;
        private TextBox TailTextBox;
        private Label label7;
        private TextBox SpecialSignsTextBox;
        private Label label8;
        private TextBox IdenLabelTextBox;
        private Label label9;
        private Button PrevScanButton;
        private Button AddFileButton;
        private Button NextScanButton;
        private PictureBox ScanPictureBox;
        private TextBox ChipNumTextBox;
        private Label label10;
        private Button OkButton;
        private Button CancelButton;
        private OpenFileDialog openFileDialog1;
        private ContextMenuStrip ScanContextMenuStrip;
        private ToolStripMenuItem DeleteToolStripMenuItem;
    }
}