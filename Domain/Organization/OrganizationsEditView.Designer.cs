namespace PetsClient.Organization.View
{
    partial class OrganizationEditView
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
            OkButton = new Button();
            CancelButton = new Button();
            label1 = new Label();
            NameOrganizationTextBox = new TextBox();
            INNTextBox = new TextBox();
            label2 = new Label();
            KPPTextBox = new TextBox();
            label3 = new Label();
            AddressTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            TypeOrganizationComboBox = new ComboBox();
            LegalTypeComboBox = new ComboBox();
            label6 = new Label();
            LocalityComboBox = new ComboBox();
            label7 = new Label();
            phone = new Label();
            label8 = new Label();
            PhoneTextBox = new TextBox();
            EmailTextBox = new TextBox();
            DataErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)DataErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.Location = new Point(159, 518);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 29);
            OkButton.TabIndex = 0;
            OkButton.Text = "Принять";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(259, 518);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Название";
            // 
            // NameOrganizationTextBox
            // 
            DataErrorProvider.SetIconPadding(NameOrganizationTextBox, 10);
            NameOrganizationTextBox.Location = new Point(12, 32);
            NameOrganizationTextBox.Name = "NameOrganizationTextBox";
            NameOrganizationTextBox.Size = new Size(445, 27);
            NameOrganizationTextBox.TabIndex = 3;
            NameOrganizationTextBox.Validating += NameOrganizationTextBox_Validating;
            // 
            // INNTextBox
            // 
            DataErrorProvider.SetIconPadding(INNTextBox, 10);
            INNTextBox.Location = new Point(12, 85);
            INNTextBox.Name = "INNTextBox";
            INNTextBox.Size = new Size(445, 27);
            INNTextBox.TabIndex = 5;
            INNTextBox.Validating += INNTextBox_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "ИНН";
            // 
            // KPPTextBox
            // 
            DataErrorProvider.SetIconPadding(KPPTextBox, 10);
            KPPTextBox.Location = new Point(12, 138);
            KPPTextBox.Name = "KPPTextBox";
            KPPTextBox.Size = new Size(445, 27);
            KPPTextBox.TabIndex = 7;
            KPPTextBox.Validating += KPPTextBox_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 6;
            label3.Text = "КПП";
            // 
            // AddressTextBox
            // 
            DataErrorProvider.SetIconPadding(AddressTextBox, 10);
            AddressTextBox.Location = new Point(12, 191);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(445, 27);
            AddressTextBox.TabIndex = 9;
            AddressTextBox.Validating += AddressTextBox_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 8;
            label4.Text = "Адрес";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 221);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 10;
            label5.Text = "Тип организации";
            // 
            // TypeOrganizationComboBox
            // 
            TypeOrganizationComboBox.FormattingEnabled = true;
            DataErrorProvider.SetIconPadding(TypeOrganizationComboBox, 10);
            TypeOrganizationComboBox.Location = new Point(12, 244);
            TypeOrganizationComboBox.Name = "TypeOrganizationComboBox";
            TypeOrganizationComboBox.Size = new Size(445, 28);
            TypeOrganizationComboBox.TabIndex = 11;
            TypeOrganizationComboBox.Validating += TypeOrganizationComboBox_Validating;
            // 
            // LegalTypeComboBox
            // 
            LegalTypeComboBox.FormattingEnabled = true;
            DataErrorProvider.SetIconPadding(LegalTypeComboBox, 10);
            LegalTypeComboBox.Location = new Point(12, 298);
            LegalTypeComboBox.Name = "LegalTypeComboBox";
            LegalTypeComboBox.Size = new Size(445, 28);
            LegalTypeComboBox.TabIndex = 13;
            LegalTypeComboBox.Validating += LegalTypeComboBox_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 275);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 12;
            label6.Text = "Юридический статус";
            // 
            // LocalityComboBox
            // 
            LocalityComboBox.FormattingEnabled = true;
            DataErrorProvider.SetIconPadding(LocalityComboBox, 10);
            LocalityComboBox.Location = new Point(12, 352);
            LocalityComboBox.Name = "LocalityComboBox";
            LocalityComboBox.Size = new Size(445, 28);
            LocalityComboBox.TabIndex = 15;
            LocalityComboBox.Validating += LocalityComboBox_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 329);
            label7.Name = "label7";
            label7.Size = new Size(139, 20);
            label7.TabIndex = 14;
            label7.Text = "Населенный пункт";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Location = new Point(12, 383);
            phone.Name = "phone";
            phone.Size = new Size(69, 20);
            phone.TabIndex = 16;
            phone.Text = "Телефон";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 437);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 18;
            label8.Text = "Почта";
            // 
            // PhoneTextBox
            // 
            DataErrorProvider.SetIconPadding(PhoneTextBox, 10);
            PhoneTextBox.Location = new Point(12, 406);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(445, 27);
            PhoneTextBox.TabIndex = 19;
            PhoneTextBox.Validating += PhoneTextBox_Validating;
            // 
            // EmailTextBox
            // 
            DataErrorProvider.SetIconPadding(EmailTextBox, 10);
            EmailTextBox.Location = new Point(12, 460);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(445, 27);
            EmailTextBox.TabIndex = 20;
            EmailTextBox.Validating += EmailTextBox_Validating;
            // 
            // DataErrorProvider
            // 
            DataErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            DataErrorProvider.ContainerControl = this;
            // 
            // OrganizationEditView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 563);
            Controls.Add(EmailTextBox);
            Controls.Add(PhoneTextBox);
            Controls.Add(label8);
            Controls.Add(phone);
            Controls.Add(LocalityComboBox);
            Controls.Add(label7);
            Controls.Add(LegalTypeComboBox);
            Controls.Add(label6);
            Controls.Add(TypeOrganizationComboBox);
            Controls.Add(label5);
            Controls.Add(AddressTextBox);
            Controls.Add(label4);
            Controls.Add(KPPTextBox);
            Controls.Add(label3);
            Controls.Add(INNTextBox);
            Controls.Add(label2);
            Controls.Add(NameOrganizationTextBox);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrganizationEditView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Организация";
            ((System.ComponentModel.ISupportInitialize)DataErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OkButton;
        private Button CancelButton;
        private Label label1;
        private TextBox NameOrganizationTextBox;
        private TextBox INNTextBox;
        private Label label2;
        private TextBox KPPTextBox;
        private Label label3;
        private TextBox AddressTextBox;
        private Label label4;
        private Label label5;
        private ComboBox TypeOrganizationComboBox;
        private ComboBox LegalTypeComboBox;
        private Label label6;
        private ComboBox LocalityComboBox;
        private Label label7;
        private Label phone;
        private Label label8;
        private TextBox PhoneTextBox;
        private TextBox EmailTextBox;
        private ErrorProvider DataErrorProvider;
    }
}