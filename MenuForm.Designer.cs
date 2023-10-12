using System;

namespace IS_5
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
            this.PlanButton = new System.Windows.Forms.Button();
            this.OrgsButton = new System.Windows.Forms.Button();
            this.ContractsButton = new System.Windows.Forms.Button();
            this.ActsButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlanButton
            // 
            this.PlanButton.Location = new System.Drawing.Point(197, 269);
            this.PlanButton.Name = "PlanButton";
            this.PlanButton.Size = new System.Drawing.Size(319, 33);
            this.PlanButton.TabIndex = 2;
            this.PlanButton.Text = "План";
            this.PlanButton.UseVisualStyleBackColor = true;
            this.PlanButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // OrgsButton
            // 
            this.OrgsButton.Location = new System.Drawing.Point(197, 152);
            this.OrgsButton.Name = "OrgsButton";
            this.OrgsButton.Size = new System.Drawing.Size(319, 33);
            this.OrgsButton.TabIndex = 0;
            this.OrgsButton.Text = "Организации";
            this.OrgsButton.UseVisualStyleBackColor = true;
            this.OrgsButton.Click += new System.EventHandler(this.OrgsButton_Click);
            // 
            // ContractsButton
            // 
            this.ContractsButton.Location = new System.Drawing.Point(197, 191);
            this.ContractsButton.Name = "ContractsButton";
            this.ContractsButton.Size = new System.Drawing.Size(319, 33);
            this.ContractsButton.TabIndex = 1;
            this.ContractsButton.Text = "Контракты";
            this.ContractsButton.UseVisualStyleBackColor = true;
            this.ContractsButton.Click += new System.EventHandler(this.ContractsButton_Click);
            // 
            // ActsButton
            // 
            this.ActsButton.Location = new System.Drawing.Point(197, 230);
            this.ActsButton.Name = "ActsButton";
            this.ActsButton.Size = new System.Drawing.Size(319, 33);
            this.ActsButton.TabIndex = 2;
            this.ActsButton.Text = "Акты";
            this.ActsButton.UseVisualStyleBackColor = true;
            this.ActsButton.Click += new System.EventHandler(this.ActsButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(197, 308);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(319, 33);
            this.ReportButton.TabIndex = 3;
            this.ReportButton.Text = "Отчет";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.PlanButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.ActsButton);
            this.Controls.Add(this.ContractsButton);
            this.Controls.Add(this.OrgsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PlanButton;
        private System.Windows.Forms.Button OrgsButton;
        private System.Windows.Forms.Button ContractsButton;
        private System.Windows.Forms.Button ActsButton;
        private System.Windows.Forms.Button ReportButton;
    }
}