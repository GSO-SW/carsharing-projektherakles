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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(15, 92);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(12, 76);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(35, 13);
            this.Namelabel.TabIndex = 1;
            this.Namelabel.Text = "Name";
            // 
            // TelefonNr
            // 
            this.TelefonNr.AutoSize = true;
            this.TelefonNr.Location = new System.Drawing.Point(12, 125);
            this.TelefonNr.Name = "TelefonNr";
            this.TelefonNr.Size = new System.Drawing.Size(80, 13);
            this.TelefonNr.TabIndex = 2;
            this.TelefonNr.Text = "Telefonnummer";
            // 
            // TelefonNrTextBox
            // 
            this.TelefonNrTextBox.Location = new System.Drawing.Point(15, 141);
            this.TelefonNrTextBox.Name = "TelefonNrTextBox";
            this.TelefonNrTextBox.Size = new System.Drawing.Size(100, 20);
            this.TelefonNrTextBox.TabIndex = 3;
            // 
            // EMailLabel
            // 
            this.EMailLabel.AutoSize = true;
            this.EMailLabel.Location = new System.Drawing.Point(163, 76);
            this.EMailLabel.Name = "EMailLabel";
            this.EMailLabel.Size = new System.Drawing.Size(36, 13);
            this.EMailLabel.TabIndex = 4;
            this.EMailLabel.Text = "E-Mail";
            // 
            // EMailTextBox
            // 
            this.EMailTextBox.Location = new System.Drawing.Point(166, 92);
            this.EMailTextBox.Name = "EMailTextBox";
            this.EMailTextBox.Size = new System.Drawing.Size(100, 20);
            this.EMailTextBox.TabIndex = 5;
            // 
            // AdresseLabel
            // 
            this.AdresseLabel.AutoSize = true;
            this.AdresseLabel.Location = new System.Drawing.Point(163, 125);
            this.AdresseLabel.Name = "AdresseLabel";
            this.AdresseLabel.Size = new System.Drawing.Size(45, 13);
            this.AdresseLabel.TabIndex = 6;
            this.AdresseLabel.Text = "Adresse";
            // 
            // AdresseTextBox
            // 
            this.AdresseTextBox.Location = new System.Drawing.Point(166, 141);
            this.AdresseTextBox.Name = "AdresseTextBox";
            this.AdresseTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdresseTextBox.TabIndex = 7;
            // 
            // ZahlungsartLabel
            // 
            this.ZahlungsartLabel.AutoSize = true;
            this.ZahlungsartLabel.Location = new System.Drawing.Point(12, 176);
            this.ZahlungsartLabel.Name = "ZahlungsartLabel";
            this.ZahlungsartLabel.Size = new System.Drawing.Size(63, 13);
            this.ZahlungsartLabel.TabIndex = 8;
            this.ZahlungsartLabel.Text = "Zahlungsart";
            // 
            // ZahlungsartComboBox
            // 
            this.ZahlungsartComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ZahlungsartComboBox.FormattingEnabled = true;
            this.ZahlungsartComboBox.Items.AddRange(new object[] {
            "Bankeinzug",
            "PayPal",
            "Sofortüberweisung"});
            this.ZahlungsartComboBox.Location = new System.Drawing.Point(12, 192);
            this.ZahlungsartComboBox.Name = "ZahlungsartComboBox";
            this.ZahlungsartComboBox.Size = new System.Drawing.Size(121, 21);
            this.ZahlungsartComboBox.TabIndex = 9;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(163, 176);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(50, 13);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Passwort";
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(166, 193);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordtextBox.TabIndex = 11;
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(203, 260);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 12;
            this.FinishButton.Text = "Hinzufügen";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Benutzer hinzufügen";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(290, 295);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}