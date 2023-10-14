namespace IS_5.View
{
    partial class OrganizationEditOneView
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
            OkButton = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            LegalTypeComboBox = new ComboBox();
            TypeOrganizationComboBox = new ComboBox();
            AddressTextBox = new TextBox();
            KPPTextBox = new TextBox();
            TaxIdenNumTextBox = new TextBox();
            NameOrgTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            LocalityComboBox = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(321, 392);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(221, 392);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 29);
            OkButton.TabIndex = 15;
            OkButton.Text = "Ок";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 273);
            label8.Name = "label8";
            label8.Size = new Size(152, 20);
            label8.TabIndex = 14;
            label8.Text = "Юридический статус";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 219);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 13;
            label7.Text = "Тип организации";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 166);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 12;
            label6.Text = "Адрес";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 115);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 11;
            label5.Text = "КПП";
            // 
            // LegalTypeComboBox
            // 
            LegalTypeComboBox.FormattingEnabled = true;
            LegalTypeComboBox.Location = new Point(12, 296);
            LegalTypeComboBox.Name = "LegalTypeComboBox";
            LegalTypeComboBox.Size = new Size(403, 28);
            LegalTypeComboBox.TabIndex = 10;
            // 
            // TypeOrganizationComboBox
            // 
            TypeOrganizationComboBox.FormattingEnabled = true;
            TypeOrganizationComboBox.Location = new Point(12, 242);
            TypeOrganizationComboBox.Name = "TypeOrganizationComboBox";
            TypeOrganizationComboBox.Size = new Size(403, 28);
            TypeOrganizationComboBox.TabIndex = 9;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(12, 189);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(403, 27);
            AddressTextBox.TabIndex = 8;
            // 
            // KPPTextBox
            // 
            KPPTextBox.Location = new Point(12, 136);
            KPPTextBox.Name = "KPPTextBox";
            KPPTextBox.Size = new Size(403, 27);
            KPPTextBox.TabIndex = 7;
            // 
            // TaxIdenNumTextBox
            // 
            TaxIdenNumTextBox.Location = new Point(12, 85);
            TaxIdenNumTextBox.Name = "TaxIdenNumTextBox";
            TaxIdenNumTextBox.Size = new Size(403, 27);
            TaxIdenNumTextBox.TabIndex = 6;
            // 
            // NameOrgTextBox
            // 
            NameOrgTextBox.Location = new Point(12, 32);
            NameOrgTextBox.Name = "NameOrgTextBox";
            NameOrgTextBox.Size = new Size(403, 27);
            NameOrgTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 62);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 4;
            label4.Text = "ИНН";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 3;
            label3.Text = "Название";
            // 
            // LocalityComboBox
            // 
            LocalityComboBox.FormattingEnabled = true;
            LocalityComboBox.Location = new Point(12, 350);
            LocalityComboBox.Name = "LocalityComboBox";
            LocalityComboBox.Size = new Size(403, 28);
            LocalityComboBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 327);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 18;
            label1.Text = "Населенный пункт";
            // 
            // OrganizationEditOneView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(427, 433);
            Controls.Add(label1);
            Controls.Add(LocalityComboBox);
            Controls.Add(label3);
            Controls.Add(CancelButton);
            Controls.Add(label4);
            Controls.Add(OkButton);
            Controls.Add(NameOrgTextBox);
            Controls.Add(label8);
            Controls.Add(TaxIdenNumTextBox);
            Controls.Add(label7);
            Controls.Add(KPPTextBox);
            Controls.Add(label6);
            Controls.Add(AddressTextBox);
            Controls.Add(label5);
            Controls.Add(TypeOrganizationComboBox);
            Controls.Add(LegalTypeComboBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "OrganizationEditOneView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Организация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CancelButton;
        private Button OkButton;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox LegalTypeComboBox;
        private ComboBox TypeOrganizationComboBox;
        private TextBox AddressTextBox;
        private TextBox KPPTextBox;
        private TextBox TaxIdenNumTextBox;
        private TextBox NameOrgTextBox;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox LocalityComboBox;
    }
}