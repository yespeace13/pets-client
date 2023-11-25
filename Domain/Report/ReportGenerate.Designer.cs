namespace PetsClient.Domain.Report
{
    partial class ReportGenerate
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
            CreateButton = new Button();
            ExitButton = new Button();
            FromDateTimePicker = new DateTimePicker();
            ToDateTimePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(25, 172);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(139, 29);
            CreateButton.TabIndex = 0;
            CreateButton.Text = "Сформировать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(170, 172);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Отмена";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // FromDateTimePicker
            // 
            FromDateTimePicker.Location = new Point(12, 32);
            FromDateTimePicker.Name = "FromDateTimePicker";
            FromDateTimePicker.Size = new Size(252, 27);
            FromDateTimePicker.TabIndex = 2;
            // 
            // ToDateTimePicker
            // 
            ToDateTimePicker.Location = new Point(12, 85);
            ToDateTimePicker.Name = "ToDateTimePicker";
            ToDateTimePicker.Size = new Size(252, 27);
            ToDateTimePicker.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 4;
            label1.Text = "Начало периода";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 5;
            label2.Text = "Конец периода";
            // 
            // ReportGenerate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 213);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ToDateTimePicker);
            Controls.Add(FromDateTimePicker);
            Controls.Add(ExitButton);
            Controls.Add(CreateButton);
            Name = "ReportGenerate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отчет";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateButton;
        private Button ExitButton;
        private DateTimePicker FromDateTimePicker;
        private DateTimePicker ToDateTimePicker;
        private Label label1;
        private Label label2;
    }
}