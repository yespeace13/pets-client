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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractEditView));
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LocalsPricesDataGridView = new System.Windows.Forms.DataGridView();
            this.DateOfConclusionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateValidDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ExecutorComboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NextScanButton = new System.Windows.Forms.Button();
            this.PrevScanButton = new System.Windows.Forms.Button();
            this.ScanPictureBox = new System.Windows.Forms.PictureBox();
            this.ImageContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddLocalPriceButton = new System.Windows.Forms.Button();
            this.LocalPriceContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Locality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LocalsPricesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScanPictureBox)).BeginInit();
            this.ImageContextMenuStrip.SuspendLayout();
            this.LocalPriceContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(421, 430);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(340, 430);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 15;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Заказчик";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Исполнитель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата действия";
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(12, 204);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(236, 24);
            this.ClientComboBox.TabIndex = 9;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(12, 28);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(236, 22);
            this.NumberTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата заключения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер";
            // 
            // LocalsPricesDataGridView
            // 
            this.LocalsPricesDataGridView.AllowUserToAddRows = false;
            this.LocalsPricesDataGridView.AllowUserToDeleteRows = false;
            this.LocalsPricesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LocalsPricesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocalsPricesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Locality,
            this.Price});
            this.LocalsPricesDataGridView.ContextMenuStrip = this.LocalPriceContextMenuStrip;
            this.LocalsPricesDataGridView.Location = new System.Drawing.Point(12, 234);
            this.LocalsPricesDataGridView.MultiSelect = false;
            this.LocalsPricesDataGridView.Name = "LocalsPricesDataGridView";
            this.LocalsPricesDataGridView.ReadOnly = true;
            this.LocalsPricesDataGridView.RowHeadersVisible = false;
            this.LocalsPricesDataGridView.RowHeadersWidth = 51;
            this.LocalsPricesDataGridView.RowTemplate.Height = 24;
            this.LocalsPricesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocalsPricesDataGridView.Size = new System.Drawing.Size(484, 190);
            this.LocalsPricesDataGridView.TabIndex = 17;
            this.LocalsPricesDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LocalsPricesDataGridView_MouseDown);
            // 
            // DateOfConclusionDateTimePicker
            // 
            this.DateOfConclusionDateTimePicker.Location = new System.Drawing.Point(12, 72);
            this.DateOfConclusionDateTimePicker.Name = "DateOfConclusionDateTimePicker";
            this.DateOfConclusionDateTimePicker.Size = new System.Drawing.Size(155, 22);
            this.DateOfConclusionDateTimePicker.TabIndex = 18;
            // 
            // DateValidDateTimePicker
            // 
            this.DateValidDateTimePicker.Location = new System.Drawing.Point(12, 116);
            this.DateValidDateTimePicker.Name = "DateValidDateTimePicker";
            this.DateValidDateTimePicker.Size = new System.Drawing.Size(155, 22);
            this.DateValidDateTimePicker.TabIndex = 19;
            // 
            // ExecutorComboBox
            // 
            this.ExecutorComboBox.FormattingEnabled = true;
            this.ExecutorComboBox.Location = new System.Drawing.Point(12, 158);
            this.ExecutorComboBox.Name = "ExecutorComboBox";
            this.ExecutorComboBox.Size = new System.Drawing.Size(236, 24);
            this.ExecutorComboBox.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"png|*.png|*.jpg|\"";
            // 
            // NextScanButton
            // 
            this.NextScanButton.Image = ((System.Drawing.Image)(resources.GetObject("NextScanButton.Image")));
            this.NextScanButton.Location = new System.Drawing.Point(465, 92);
            this.NextScanButton.Name = "NextScanButton";
            this.NextScanButton.Size = new System.Drawing.Size(26, 32);
            this.NextScanButton.TabIndex = 23;
            this.NextScanButton.UseVisualStyleBackColor = true;
            this.NextScanButton.Click += new System.EventHandler(this.NextScanButton_Click);
            // 
            // PrevScanButton
            // 
            this.PrevScanButton.Image = ((System.Drawing.Image)(resources.GetObject("PrevScanButton.Image")));
            this.PrevScanButton.Location = new System.Drawing.Point(253, 92);
            this.PrevScanButton.Name = "PrevScanButton";
            this.PrevScanButton.Size = new System.Drawing.Size(26, 32);
            this.PrevScanButton.TabIndex = 24;
            this.PrevScanButton.UseVisualStyleBackColor = true;
            this.PrevScanButton.Click += new System.EventHandler(this.PrevScanButton_Click);
            // 
            // ScanPictureBox
            // 
            this.ScanPictureBox.ContextMenuStrip = this.ImageContextMenuStrip;
            this.ScanPictureBox.Location = new System.Drawing.Point(285, 12);
            this.ScanPictureBox.Name = "ScanPictureBox";
            this.ScanPictureBox.Size = new System.Drawing.Size(174, 189);
            this.ScanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ScanPictureBox.TabIndex = 22;
            this.ScanPictureBox.TabStop = false;
            this.ScanPictureBox.DoubleClick += new System.EventHandler(this.ScanPictureBox_DoubleClick);
            // 
            // ImageContextMenuStrip
            // 
            this.ImageContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ImageContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteImageToolStripMenuItem});
            this.ImageContextMenuStrip.Name = "ImageContextMenuStrip";
            this.ImageContextMenuStrip.Size = new System.Drawing.Size(135, 28);
            // 
            // DeleteImageToolStripMenuItem
            // 
            this.DeleteImageToolStripMenuItem.Name = "DeleteImageToolStripMenuItem";
            this.DeleteImageToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.DeleteImageToolStripMenuItem.Text = "Удалить";
            this.DeleteImageToolStripMenuItem.Click += new System.EventHandler(this.DeleteImageToolStripMenuItem_Click);
            // 
            // AddLocalPriceButton
            // 
            this.AddLocalPriceButton.Location = new System.Drawing.Point(421, 207);
            this.AddLocalPriceButton.Name = "AddLocalPriceButton";
            this.AddLocalPriceButton.Size = new System.Drawing.Size(75, 23);
            this.AddLocalPriceButton.TabIndex = 25;
            this.AddLocalPriceButton.Text = "Добавить";
            this.AddLocalPriceButton.UseVisualStyleBackColor = true;
            this.AddLocalPriceButton.Click += new System.EventHandler(this.AddLocalPriceButton_Click);
            // 
            // LocalPriceContextMenuStrip
            // 
            this.LocalPriceContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LocalPriceContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.LocalPriceContextMenuStrip.Name = "contextMenuStrip1";
            this.LocalPriceContextMenuStrip.Size = new System.Drawing.Size(148, 52);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.UpdateToolStripMenuItem.Text = "Изменить";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // Locality
            // 
            this.Locality.FillWeight = 61.94443F;
            this.Locality.HeaderText = "Муниципальный район";
            this.Locality.MinimumWidth = 6;
            this.Locality.Name = "Locality";
            this.Locality.ReadOnly = true;
            this.Locality.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Price
            // 
            this.Price.FillWeight = 67.36925F;
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(290, 207);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(125, 23);
            this.AddFileButton.TabIndex = 26;
            this.AddFileButton.Text = "Загрузить файл";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // ContractEditView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(503, 465);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.AddLocalPriceButton);
            this.Controls.Add(this.PrevScanButton);
            this.Controls.Add(this.NextScanButton);
            this.Controls.Add(this.ScanPictureBox);
            this.Controls.Add(this.ExecutorComboBox);
            this.Controls.Add(this.DateValidDateTimePicker);
            this.Controls.Add(this.DateOfConclusionDateTimePicker);
            this.Controls.Add(this.LocalsPricesDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClientComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ContractEditView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контракт";
            ((System.ComponentModel.ISupportInitialize)(this.LocalsPricesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScanPictureBox)).EndInit();
            this.ImageContextMenuStrip.ResumeLayout(false);
            this.LocalPriceContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ClientComboBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView LocalsPricesDataGridView;
        private System.Windows.Forms.DateTimePicker DateOfConclusionDateTimePicker;
        private System.Windows.Forms.DateTimePicker DateValidDateTimePicker;
        private System.Windows.Forms.ComboBox ExecutorComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox ScanPictureBox;
        private System.Windows.Forms.Button NextScanButton;
        private System.Windows.Forms.Button PrevScanButton;
        private System.Windows.Forms.Button AddLocalPriceButton;
        private System.Windows.Forms.ContextMenuStrip ImageContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteImageToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip LocalPriceContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button AddFileButton;
    }
}