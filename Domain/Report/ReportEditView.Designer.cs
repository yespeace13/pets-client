namespace PetsClient.Domain.Report
{
    partial class ReportEditView
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
            CancelButton = new Button();
            label1 = new Label();
            NumberTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ContentDataGridView = new DataGridView();
            FromDateTimePicker = new DateTimePicker();
            ToDateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)ContentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(305, 432);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Закрыть";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = "Номер";
            // 
            // NumberTextBox
            // 
            NumberTextBox.Location = new Point(12, 32);
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.Size = new Size(250, 27);
            NumberTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 4;
            label2.Text = "Начало периода";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 62);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 6;
            label3.Text = "Конец периода";
            // 
            // ContentDataGridView
            // 
            ContentDataGridView.AllowUserToAddRows = false;
            ContentDataGridView.AllowUserToDeleteRows = false;
            ContentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ContentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ContentDataGridView.Location = new Point(11, 117);
            ContentDataGridView.Name = "ContentDataGridView";
            ContentDataGridView.ReadOnly = true;
            ContentDataGridView.RowHeadersVisible = false;
            ContentDataGridView.RowHeadersWidth = 51;
            ContentDataGridView.RowTemplate.Height = 29;
            ContentDataGridView.Size = new Size(682, 299);
            ContentDataGridView.TabIndex = 8;
            // 
            // FromDateTimePicker
            // 
            FromDateTimePicker.Location = new Point(12, 85);
            FromDateTimePicker.Name = "FromDateTimePicker";
            FromDateTimePicker.Size = new Size(250, 27);
            FromDateTimePicker.TabIndex = 9;
            // 
            // ToDateTimePicker
            // 
            ToDateTimePicker.Location = new Point(268, 85);
            ToDateTimePicker.Name = "ToDateTimePicker";
            ToDateTimePicker.Size = new Size(250, 27);
            ToDateTimePicker.TabIndex = 10;
            // 
            // ReportEditView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 473);
            Controls.Add(ToDateTimePicker);
            Controls.Add(FromDateTimePicker);
            Controls.Add(ContentDataGridView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NumberTextBox);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReportEditView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Организация";
            ((System.ComponentModel.ISupportInitialize)ContentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CancelButton;
        private Label label1;
        private TextBox NumberTextBox;
        private TextBox INNTextBox;
        private Label label2;
        private TextBox KPPTextBox;
        private Label label3;
        private DataGridView ContentDataGridView;
        private DateTimePicker FromDateTimePicker;
        private DateTimePicker ToDateTimePicker;
    }
}