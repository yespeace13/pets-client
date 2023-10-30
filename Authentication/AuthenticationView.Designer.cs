namespace PetsClient.Authentication
{
    partial class AuthenticationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticationView));
            OkButton = new Button();
            label1 = new Label();
            label2 = new Label();
            LogTextBox = new TextBox();
            PassTextBox = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.Location = new Point(177, 464);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 29);
            OkButton.TabIndex = 0;
            OkButton.Text = "Войти";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 321);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 374);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // LogTextBox
            // 
            LogTextBox.Location = new Point(112, 344);
            LogTextBox.Name = "LogTextBox";
            LogTextBox.Size = new Size(204, 27);
            LogTextBox.TabIndex = 3;
            LogTextBox.Text = "super";
            // 
            // PassTextBox
            // 
            PassTextBox.Location = new Point(112, 397);
            PassTextBox.Name = "PassTextBox";
            PassTextBox.PasswordChar = '*';
            PassTextBox.Size = new Size(204, 27);
            PassTextBox.TabIndex = 4;
            PassTextBox.Text = "1234";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 508);
            label4.Name = "label4";
            label4.Size = new Size(227, 20);
            label4.TabIndex = 6;
            label4.Text = "Неверный логин и/или пароль";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources._6701277_1_;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(404, 276);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(147, 296);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 8;
            label3.Text = "Авторизация";
            // 
            // AuthenticationView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(428, 537);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(PassTextBox);
            Controls.Add(LogTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OkButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AuthenticationView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OkButton;
        private Label label1;
        private Label label2;
        private TextBox LogTextBox;
        private TextBox PassTextBox;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label3;
    }
}