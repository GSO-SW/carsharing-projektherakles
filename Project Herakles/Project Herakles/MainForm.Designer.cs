﻿namespace Project_Herakles
{
    partial class MainForm
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
            this.AddUser = new System.Windows.Forms.Button();
            this.buttonAddFahrzeug = new System.Windows.Forms.Button();
            this.buttonFahrzeugInformationen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(12, 12);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(133, 23);
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "Kunde Hinzufügen";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // buttonAddFahrzeug
            // 
            this.buttonAddFahrzeug.Location = new System.Drawing.Point(12, 41);
            this.buttonAddFahrzeug.Name = "buttonAddFahrzeug";
            this.buttonAddFahrzeug.Size = new System.Drawing.Size(133, 23);
            this.buttonAddFahrzeug.TabIndex = 1;
            this.buttonAddFahrzeug.Text = "Fahrzeug Hinzufügen";
            this.buttonAddFahrzeug.UseVisualStyleBackColor = true;
            this.buttonAddFahrzeug.Click += new System.EventHandler(this.buttonAddFahrzeug_Click);
            // 
            // buttonFahrzeugInformationen
            // 
            this.buttonFahrzeugInformationen.Location = new System.Drawing.Point(12, 70);
            this.buttonFahrzeugInformationen.Name = "buttonFahrzeugInformationen";
            this.buttonFahrzeugInformationen.Size = new System.Drawing.Size(133, 23);
            this.buttonFahrzeugInformationen.TabIndex = 2;
            this.buttonFahrzeugInformationen.Text = "Fahrzeug Informationen";
            this.buttonFahrzeugInformationen.UseVisualStyleBackColor = true;
            this.buttonFahrzeugInformationen.Click += new System.EventHandler(this.buttonFahrzeugInformationen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFahrzeugInformationen);
            this.Controls.Add(this.buttonAddFahrzeug);
            this.Controls.Add(this.AddUser);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button buttonAddFahrzeug;
        private System.Windows.Forms.Button buttonFahrzeugInformationen;
    }
}
