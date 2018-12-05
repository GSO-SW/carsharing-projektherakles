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
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.FinishButton = new System.Windows.Forms.Button();
            this.ZahlungsartlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(20, 31);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(132, 22);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(16, 11);
            this.Namelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(45, 17);
            this.Namelabel.TabIndex = 1;
            this.Namelabel.Text = "Name";
            // 
            // TelefonNr
            // 
            this.TelefonNr.AutoSize = true;
            this.TelefonNr.Location = new System.Drawing.Point(16, 71);
            this.TelefonNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TelefonNr.Name = "TelefonNr";
            this.TelefonNr.Size = new System.Drawing.Size(71, 17);
            this.TelefonNr.TabIndex = 2;
            this.TelefonNr.Text = "TelefonNr";
            // 
            // TelefonNrTextBox
            // 
            this.TelefonNrTextBox.Location = new System.Drawing.Point(20, 91);
            this.TelefonNrTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TelefonNrTextBox.Name = "TelefonNrTextBox";
            this.TelefonNrTextBox.Size = new System.Drawing.Size(132, 22);
            this.TelefonNrTextBox.TabIndex = 3;
            this.TelefonNrTextBox.TextChanged += new System.EventHandler(this.TelefonNrTextBox_TextChanged);
            // 
            // EMailLabel
            // 
            this.EMailLabel.AutoSize = true;
            this.EMailLabel.Location = new System.Drawing.Point(217, 11);
            this.EMailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EMailLabel.Name = "EMailLabel";
            this.EMailLabel.Size = new System.Drawing.Size(42, 17);
            this.EMailLabel.TabIndex = 4;
            this.EMailLabel.Text = "EMail";
            // 
            // EMailTextBox
            // 
            this.EMailTextBox.Location = new System.Drawing.Point(221, 31);
            this.EMailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EMailTextBox.Name = "EMailTextBox";
            this.EMailTextBox.Size = new System.Drawing.Size(132, 22);
            this.EMailTextBox.TabIndex = 5;
            this.EMailTextBox.TextChanged += new System.EventHandler(this.EMailTextBox_TextChanged);
            // 
            // AdresseLabel
            // 
            this.AdresseLabel.AutoSize = true;
            this.AdresseLabel.Location = new System.Drawing.Point(217, 71);
            this.AdresseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdresseLabel.Name = "AdresseLabel";
            this.AdresseLabel.Size = new System.Drawing.Size(60, 17);
            this.AdresseLabel.TabIndex = 6;
            this.AdresseLabel.Text = "Adresse";
            // 
            // AdresseTextBox
            // 
            this.AdresseTextBox.Location = new System.Drawing.Point(221, 91);
            this.AdresseTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdresseTextBox.Name = "AdresseTextBox";
            this.AdresseTextBox.Size = new System.Drawing.Size(132, 22);
            this.AdresseTextBox.TabIndex = 7;
            this.AdresseTextBox.TextChanged += new System.EventHandler(this.AdresseTextBox_TextChanged);
            // 
            // ZahlungsartLabel
            // 
            this.ZahlungsartLabel.AutoSize = true;
            this.ZahlungsartLabel.Location = new System.Drawing.Point(16, 134);
            this.ZahlungsartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZahlungsartLabel.Name = "ZahlungsartLabel";
            this.ZahlungsartLabel.Size = new System.Drawing.Size(84, 17);
            this.ZahlungsartLabel.TabIndex = 8;
            this.ZahlungsartLabel.Text = "Zahlungsart";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(217, 134);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(69, 17);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(221, 154);
            this.PasswordtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(132, 22);
            this.PasswordtextBox.TabIndex = 11;
            this.PasswordtextBox.TextChanged += new System.EventHandler(this.PasswordtextBox_TextChanged);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(920, 495);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(100, 28);
            this.FinishButton.TabIndex = 12;
            this.FinishButton.Text = "Hinzufügen";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // ZahlungsartlistBox
            // 
            this.ZahlungsartlistBox.FormattingEnabled = true;
            this.ZahlungsartlistBox.ItemHeight = 16;
            this.ZahlungsartlistBox.Items.AddRange(new object[] {
            "PayPal",
            "Kreditkarte"});
            this.ZahlungsartlistBox.Location = new System.Drawing.Point(19, 154);
            this.ZahlungsartlistBox.Name = "ZahlungsartlistBox";
            this.ZahlungsartlistBox.Size = new System.Drawing.Size(133, 36);
            this.ZahlungsartlistBox.TabIndex = 13;
            this.ZahlungsartlistBox.SelectedIndexChanged += new System.EventHandler(this.ZahlungsartlistBox_SelectedIndexChanged);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ZahlungsartlistBox);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.ZahlungsartLabel);
            this.Controls.Add(this.AdresseTextBox);
            this.Controls.Add(this.AdresseLabel);
            this.Controls.Add(this.EMailTextBox);
            this.Controls.Add(this.EMailLabel);
            this.Controls.Add(this.TelefonNrTextBox);
            this.Controls.Add(this.TelefonNr);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.NameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.ListBox ZahlungsartlistBox;
    }
}