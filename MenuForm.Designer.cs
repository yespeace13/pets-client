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
            SuspendLayout();
            // 
            // OrganizationsButton
            // 
            OrganizationsButton.Location = new Point(256, 129);
            OrganizationsButton.Margin = new Padding(3, 4, 3, 4);
            OrganizationsButton.Name = "OrganizationsButton";
            OrganizationsButton.Size = new Size(372, 60);
            OrganizationsButton.TabIndex = 0;
            OrganizationsButton.Text = "Организации";
            OrganizationsButton.UseVisualStyleBackColor = true;
            OrganizationsButton.Click += OrgsButton_Click;
            // 
            // ContractsButton
            // 
            ContractsButton.Location = new Point(256, 265);
            ContractsButton.Margin = new Padding(3, 4, 3, 4);
            ContractsButton.Name = "ContractsButton";
            ContractsButton.Size = new Size(372, 60);
            ContractsButton.TabIndex = 1;
            ContractsButton.Text = "Контракты";
            ContractsButton.UseVisualStyleBackColor = true;
            ContractsButton.Click += ContractsButton_Click;
            // 
            // ActsButton
            // 
            ActsButton.Location = new Point(256, 61);
            ActsButton.Margin = new Padding(3, 4, 3, 4);
            ActsButton.Name = "ActsButton";
            ActsButton.Size = new Size(372, 60);
            ActsButton.TabIndex = 2;
            ActsButton.Text = "Акты";
            ActsButton.UseVisualStyleBackColor = true;
            ActsButton.Click += ActsButton_Click;
            // 
            // ReportButton
            // 
            ReportButton.Location = new Point(256, 333);
            ReportButton.Margin = new Padding(3, 4, 3, 4);
            ReportButton.Name = "ReportButton";
            ReportButton.Size = new Size(372, 60);
            ReportButton.TabIndex = 3;
            ReportButton.Text = "Отчет";
            ReportButton.UseVisualStyleBackColor = true;
            ReportButton.Click += ReportButton_Click;
            // 
            // CactchScheduleButton
            // 
            CactchScheduleButton.Location = new Point(256, 197);
            CactchScheduleButton.Margin = new Padding(3, 4, 3, 4);
            CactchScheduleButton.Name = "CactchScheduleButton";
            CactchScheduleButton.Size = new Size(372, 60);
            CactchScheduleButton.TabIndex = 2;
            CactchScheduleButton.Text = "План-графики";
            CactchScheduleButton.UseVisualStyleBackColor = true;
            CactchScheduleButton.Click += CatchScheduleButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitButton.Location = new Point(768, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 485);
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
        private Label label1;
    }
}