namespace PetsClient.Contract
{
    partial class ContractContentEditView
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
            OkButton = new Button();
            CancelButton = new Button();
            label1 = new Label();
            LocalityComboBox = new ComboBox();
            label2 = new Label();
            PriceNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.Location = new Point(95, 178);
            OkButton.Margin = new Padding(3, 4, 3, 4);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 29);
            OkButton.TabIndex = 0;
            OkButton.Text = "Ок";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(176, 178);
            CancelButton.Margin = new Padding(3, 4, 3, 4);
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
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 2;
            label1.Text = "Муниципальный район";
            // 
            // LocalityComboBox
            // 
            LocalityComboBox.FormattingEnabled = true;
            LocalityComboBox.Location = new Point(12, 35);
            LocalityComboBox.Margin = new Padding(3, 4, 3, 4);
            LocalityComboBox.Name = "LocalityComboBox";
            LocalityComboBox.Size = new Size(239, 28);
            LocalityComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Стоимость";
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.DecimalPlaces = 2;
            PriceNumericUpDown.Location = new Point(12, 92);
            PriceNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            PriceNumericUpDown.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(188, 27);
            PriceNumericUpDown.TabIndex = 5;
            // 
            // ContractContentEditView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 220);
            Controls.Add(PriceNumericUpDown);
            Controls.Add(label2);
            Controls.Add(LocalityComboBox);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ContractContentEditView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Населенный район контракта";
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OkButton;
        private Button CancelButton;
        private Label label1;
        private ComboBox LocalityComboBox;
        private Label label2;
        private NumericUpDown PriceNumericUpDown;
    }
}