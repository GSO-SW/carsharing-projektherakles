namespace Project_Herakles
{
    partial class AddUserForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.TelefonNr = new System.Windows.Forms.Label();
            this.TelefonNrTextBox = new System.Windows.Forms.TextBox();
            this.EMailLabel = new System.Windows.Forms.Label();
            this.EMailTextBox = new System.Windows.Forms.TextBox();
            this.AdresseLabel = new System.Windows.Forms.Label();
            this.AdresseTextBox = new System.Windows.Forms.TextBox();
            this.ZahlungsartLabel = new System.Windows.Forms.Label();
            this.ZahlungsartComboBox = new System.Windows.Forms.ComboBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.FinishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(15, 25);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(12, 9);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(35, 13);
            this.Namelabel.TabIndex = 1;
            this.Namelabel.Text = "Name";
            // 
            // TelefonNr
            // 
            this.TelefonNr.AutoSize = true;
            this.TelefonNr.Location = new System.Drawing.Point(12, 58);
            this.TelefonNr.Name = "TelefonNr";
            this.TelefonNr.Size = new System.Drawing.Size(54, 13);
            this.TelefonNr.TabIndex = 2;
            this.TelefonNr.Text = "TelefonNr";
            // 
            // TelefonNrTextBox
            // 
            this.TelefonNrTextBox.Location = new System.Drawing.Point(15, 74);
            this.TelefonNrTextBox.Name = "TelefonNrTextBox";
            this.TelefonNrTextBox.Size = new System.Drawing.Size(100, 20);
            this.TelefonNrTextBox.TabIndex = 3;
            // 
            // EMailLabel
            // 
            this.EMailLabel.AutoSize = true;
            this.EMailLabel.Location = new System.Drawing.Point(163, 9);
            this.EMailLabel.Name = "EMailLabel";
            this.EMailLabel.Size = new System.Drawing.Size(33, 13);
            this.EMailLabel.TabIndex = 4;
            this.EMailLabel.Text = "EMail";
            // 
            // EMailTextBox
            // 
            this.EMailTextBox.Location = new System.Drawing.Point(166, 25);
            this.EMailTextBox.Name = "EMailTextBox";
            this.EMailTextBox.Size = new System.Drawing.Size(100, 20);
            this.EMailTextBox.TabIndex = 5;
            // 
            // AdresseLabel
            // 
            this.AdresseLabel.AutoSize = true;
            this.AdresseLabel.Location = new System.Drawing.Point(163, 58);
            this.AdresseLabel.Name = "AdresseLabel";
            this.AdresseLabel.Size = new System.Drawing.Size(45, 13);
            this.AdresseLabel.TabIndex = 6;
            this.AdresseLabel.Text = "Adresse";
            // 
            // AdresseTextBox
            // 
            this.AdresseTextBox.Location = new System.Drawing.Point(166, 74);
            this.AdresseTextBox.Name = "AdresseTextBox";
            this.AdresseTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdresseTextBox.TabIndex = 7;
            // 
            // ZahlungsartLabel
            // 
            this.ZahlungsartLabel.AutoSize = true;
            this.ZahlungsartLabel.Location = new System.Drawing.Point(12, 109);
            this.ZahlungsartLabel.Name = "ZahlungsartLabel";
            this.ZahlungsartLabel.Size = new System.Drawing.Size(63, 13);
            this.ZahlungsartLabel.TabIndex = 8;
            this.ZahlungsartLabel.Text = "Zahlungsart";
            // 
            // ZahlungsartComboBox
            // 
            this.ZahlungsartComboBox.FormattingEnabled = true;
            this.ZahlungsartComboBox.Location = new System.Drawing.Point(12, 125);
            this.ZahlungsartComboBox.Name = "ZahlungsartComboBox";
            this.ZahlungsartComboBox.Size = new System.Drawing.Size(121, 21);
            this.ZahlungsartComboBox.TabIndex = 9;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(163, 109);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(166, 125);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordtextBox.TabIndex = 11;
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(690, 402);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 12;
            this.FinishButton.Text = "Hinzufügen";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.ZahlungsartComboBox);
            this.Controls.Add(this.ZahlungsartLabel);
            this.Controls.Add(this.AdresseTextBox);
            this.Controls.Add(this.AdresseLabel);
            this.Controls.Add(this.EMailTextBox);
            this.Controls.Add(this.EMailLabel);
            this.Controls.Add(this.TelefonNrTextBox);
            this.Controls.Add(this.TelefonNr);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.NameTextBox);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label TelefonNr;
        private System.Windows.Forms.TextBox TelefonNrTextBox;
        private System.Windows.Forms.Label EMailLabel;
        private System.Windows.Forms.TextBox EMailTextBox;
        private System.Windows.Forms.Label AdresseLabel;
        private System.Windows.Forms.TextBox AdresseTextBox;
        private System.Windows.Forms.Label ZahlungsartLabel;
        private System.Windows.Forms.ComboBox ZahlungsartComboBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Button FinishButton;
    }
}