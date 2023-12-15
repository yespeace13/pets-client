using System;

namespace PetsClient
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            OrganizationsButton = new Button();
            ContractsButton = new Button();
            ActsButton = new Button();
            ReportButton = new Button();
            CactchScheduleButton = new Button();
            ExitButton = new Button();
            LogButton = new Button();
            SuspendLayout();
            // 
            // OrganizationsButton
            // 
            OrganizationsButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            OrganizationsButton.Location = new Point(80, 176);
            OrganizationsButton.Margin = new Padding(3, 4, 3, 4);
            OrganizationsButton.Name = "OrganizationsButton";
            OrganizationsButton.Size = new Size(422, 101);
            OrganizationsButton.TabIndex = 1;
            OrganizationsButton.Text = "Организации";
            OrganizationsButton.UseVisualStyleBackColor = true;
            OrganizationsButton.Click += OrgsButton_Click;
            // 
            // ContractsButton
            // 
            ContractsButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ContractsButton.Location = new Point(508, 67);
            ContractsButton.Margin = new Padding(3, 4, 3, 4);
            ContractsButton.Name = "ContractsButton";
            ContractsButton.Size = new Size(422, 101);
            ContractsButton.TabIndex = 3;
            ContractsButton.Text = "Контракты";
            ContractsButton.UseVisualStyleBackColor = true;
            ContractsButton.Click += ContractsButton_Click;
            // 
            // ActsButton
            // 
            ActsButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ActsButton.Location = new Point(80, 67);
            ActsButton.Margin = new Padding(3, 4, 3, 4);
            ActsButton.Name = "ActsButton";
            ActsButton.Size = new Size(422, 101);
            ActsButton.TabIndex = 0;
            ActsButton.Text = "Акты";
            ActsButton.UseVisualStyleBackColor = true;
            ActsButton.Click += ActsButton_Click;
            // 
            // ReportButton
            // 
            ReportButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ReportButton.Location = new Point(508, 176);
            ReportButton.Margin = new Padding(3, 4, 3, 4);
            ReportButton.Name = "ReportButton";
            ReportButton.Size = new Size(422, 101);
            ReportButton.TabIndex = 4;
            ReportButton.Text = "Отчет";
            ReportButton.UseVisualStyleBackColor = true;
            ReportButton.Click += ReportButton_Click;
            // 
            // CactchScheduleButton
            // 
            CactchScheduleButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            CactchScheduleButton.Location = new Point(80, 285);
            CactchScheduleButton.Margin = new Padding(3, 4, 3, 4);
            CactchScheduleButton.Name = "CactchScheduleButton";
            CactchScheduleButton.Size = new Size(422, 101);
            CactchScheduleButton.TabIndex = 2;
            CactchScheduleButton.Text = "План-графики";
            CactchScheduleButton.UseVisualStyleBackColor = true;
            CactchScheduleButton.Click += CatchScheduleButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitButton.Location = new Point(887, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // LogButton
            // 
            LogButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LogButton.Location = new Point(508, 284);
            LogButton.Name = "LogButton";
            LogButton.Size = new Size(422, 101);
            LogButton.TabIndex = 6;
            LogButton.Text = "Журнал";
            LogButton.UseVisualStyleBackColor = true;
            LogButton.Click += LogButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 531);
            Controls.Add(LogButton);
            Controls.Add(ExitButton);
            Controls.Add(CactchScheduleButton);
            Controls.Add(ActsButton);
            Controls.Add(OrganizationsButton);
            Controls.Add(ReportButton);
            Controls.Add(ContractsButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            ResumeLayout(false);
        }

        #endregion
        private Button OrganizationsButton;
        private Button ContractsButton;
        private Button ActsButton;
        private Button ReportButton;
        private Button CactchScheduleButton;
        private Button ExitButton;
        private Button LogButton;
    }
}