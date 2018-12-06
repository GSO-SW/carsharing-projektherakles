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
            this.ZahlungsartLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.FinishButton = new System.Windows.Forms.Button();
            this.ZahlungsartlistBox = new System.Windows.Forms.ListBox();
            this.Ortlabel = new System.Windows.Forms.Label();
            this.OrttextBox = new System.Windows.Forms.TextBox();
            this.PLZlabel = new System.Windows.Forms.Label();
            this.PLZtextBox = new System.Windows.Forms.TextBox();
            this.StrasseLabel = new System.Windows.Forms.Label();
            this.StrasseTextBox = new System.Windows.Forms.TextBox();
            this.HausNrLabel = new System.Windows.Forms.Label();
            this.HausNrTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(15, 25);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
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
            this.TelefonNrTextBox.TextChanged += new System.EventHandler(this.TelefonNrTextBox_TextChanged);
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
            this.EMailTextBox.TextChanged += new System.EventHandler(this.EMailTextBox_TextChanged);
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
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(11, 174);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(14, 190);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordtextBox.TabIndex = 11;
            this.PasswordtextBox.TextChanged += new System.EventHandler(this.PasswordtextBox_TextChanged);
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
            // ZahlungsartlistBox
            // 
            this.ZahlungsartlistBox.FormattingEnabled = true;
            this.ZahlungsartlistBox.Items.AddRange(new object[] {
            "PayPal",
            "Kreditkarte"});
            this.ZahlungsartlistBox.Location = new System.Drawing.Point(14, 125);
            this.ZahlungsartlistBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ZahlungsartlistBox.Name = "ZahlungsartlistBox";
            this.ZahlungsartlistBox.Size = new System.Drawing.Size(101, 30);
            this.ZahlungsartlistBox.TabIndex = 13;
            this.ZahlungsartlistBox.SelectedIndexChanged += new System.EventHandler(this.ZahlungsartlistBox_SelectedIndexChanged);
            // 
            // Ortlabel
            // 
            this.Ortlabel.AutoSize = true;
            this.Ortlabel.Location = new System.Drawing.Point(163, 58);
            this.Ortlabel.Name = "Ortlabel";
            this.Ortlabel.Size = new System.Drawing.Size(21, 13);
            this.Ortlabel.TabIndex = 14;
            this.Ortlabel.Text = "Ort";
            // 
            // OrttextBox
            // 
            this.OrttextBox.Location = new System.Drawing.Point(166, 74);
            this.OrttextBox.Name = "OrttextBox";
            this.OrttextBox.Size = new System.Drawing.Size(100, 20);
            this.OrttextBox.TabIndex = 15;
            this.OrttextBox.TextChanged += new System.EventHandler(this.OrttextBox_TextChanged);
            // 
            // PLZlabel
            // 
            this.PLZlabel.AutoSize = true;
            this.PLZlabel.Location = new System.Drawing.Point(163, 109);
            this.PLZlabel.Name = "PLZlabel";
            this.PLZlabel.Size = new System.Drawing.Size(27, 13);
            this.PLZlabel.TabIndex = 16;
            this.PLZlabel.Text = "PLZ";
            // 
            // PLZtextBox
            // 
            this.PLZtextBox.Location = new System.Drawing.Point(166, 125);
            this.PLZtextBox.Name = "PLZtextBox";
            this.PLZtextBox.Size = new System.Drawing.Size(100, 20);
            this.PLZtextBox.TabIndex = 17;
            this.PLZtextBox.TextChanged += new System.EventHandler(this.PLZtextBox_TextChanged);
            // 
            // StrasseLabel
            // 
            this.StrasseLabel.AutoSize = true;
            this.StrasseLabel.Location = new System.Drawing.Point(163, 159);
            this.StrasseLabel.Name = "StrasseLabel";
            this.StrasseLabel.Size = new System.Drawing.Size(42, 13);
            this.StrasseLabel.TabIndex = 18;
            this.StrasseLabel.Text = "Strasse";
            // 
            // StrasseTextBox
            // 
            this.StrasseTextBox.Location = new System.Drawing.Point(166, 175);
            this.StrasseTextBox.Name = "StrasseTextBox";
            this.StrasseTextBox.Size = new System.Drawing.Size(100, 20);
            this.StrasseTextBox.TabIndex = 19;
            this.StrasseTextBox.TextChanged += new System.EventHandler(this.StrasseTextBox_TextChanged);
            // 
            // HausNrLabel
            // 
            this.HausNrLabel.AutoSize = true;
            this.HausNrLabel.Location = new System.Drawing.Point(302, 159);
            this.HausNrLabel.Name = "HausNrLabel";
            this.HausNrLabel.Size = new System.Drawing.Size(43, 13);
            this.HausNrLabel.TabIndex = 20;
            this.HausNrLabel.Text = "HausNr";
            // 
            // HausNrTextBox
            // 
            this.HausNrTextBox.Location = new System.Drawing.Point(305, 174);
            this.HausNrTextBox.Name = "HausNrTextBox";
            this.HausNrTextBox.Size = new System.Drawing.Size(100, 20);
            this.HausNrTextBox.TabIndex = 21;
            this.HausNrTextBox.TextChanged += new System.EventHandler(this.HausNrTextBox_TextChanged);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HausNrTextBox);
            this.Controls.Add(this.HausNrLabel);
            this.Controls.Add(this.StrasseTextBox);
            this.Controls.Add(this.StrasseLabel);
            this.Controls.Add(this.PLZtextBox);
            this.Controls.Add(this.PLZlabel);
            this.Controls.Add(this.OrttextBox);
            this.Controls.Add(this.Ortlabel);
            this.Controls.Add(this.ZahlungsartlistBox);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.ZahlungsartLabel);
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
        private System.Windows.Forms.Label ZahlungsartLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.ListBox ZahlungsartlistBox;
        private System.Windows.Forms.Label Ortlabel;
        private System.Windows.Forms.TextBox OrttextBox;
        private System.Windows.Forms.Label PLZlabel;
        private System.Windows.Forms.TextBox PLZtextBox;
        private System.Windows.Forms.Label StrasseLabel;
        private System.Windows.Forms.TextBox StrasseTextBox;
        private System.Windows.Forms.Label HausNrLabel;
        private System.Windows.Forms.TextBox HausNrTextBox;
    }
}