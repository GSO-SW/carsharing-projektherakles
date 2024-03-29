﻿namespace Project_Herakles
{
    partial class FahrzeugDialogForm
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
            this.textBoxModell = new System.Windows.Forms.TextBox();
            this.labelModell = new System.Windows.Forms.Label();
            this.labelHersteller = new System.Windows.Forms.Label();
            this.textBoxHersteller = new System.Windows.Forms.TextBox();
            this.labelKraftstoff = new System.Windows.Forms.Label();
            this.labelKennzeichen = new System.Windows.Forms.Label();
            this.textBoxKennzeichen = new System.Windows.Forms.TextBox();
            this.labelHeadline = new System.Windows.Forms.Label();
            this.comboBoxKraftstoff = new System.Windows.Forms.ComboBox();
            this.buttonAddFahrzeug = new System.Windows.Forms.Button();
            this.textBoxVerbrauch = new System.Windows.Forms.TextBox();
            this.labelVerbrauch = new System.Windows.Forms.Label();
            this.labelStandort = new System.Windows.Forms.Label();
            this.textBoxStandort = new System.Windows.Forms.TextBox();
            this.labelTankgroesse = new System.Windows.Forms.Label();
            this.textBoxTankgroesse = new System.Windows.Forms.TextBox();
            this.labelTankstand = new System.Windows.Forms.Label();
            this.textBoxTankstand = new System.Windows.Forms.TextBox();
            this.textBoxPreis = new System.Windows.Forms.TextBox();
            this.labelPreis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxModell
            // 
            this.textBoxModell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxModell.Location = new System.Drawing.Point(182, 70);
            this.textBoxModell.Name = "textBoxModell";
            this.textBoxModell.Size = new System.Drawing.Size(110, 20);
            this.textBoxModell.TabIndex = 0;
            // 
            // labelModell
            // 
            this.labelModell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelModell.AutoSize = true;
            this.labelModell.Location = new System.Drawing.Point(182, 51);
            this.labelModell.Name = "labelModell";
            this.labelModell.Size = new System.Drawing.Size(38, 13);
            this.labelModell.TabIndex = 1;
            this.labelModell.Text = "Modell";
            // 
            // labelHersteller
            // 
            this.labelHersteller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelHersteller.AutoSize = true;
            this.labelHersteller.Location = new System.Drawing.Point(59, 51);
            this.labelHersteller.Name = "labelHersteller";
            this.labelHersteller.Size = new System.Drawing.Size(51, 13);
            this.labelHersteller.TabIndex = 3;
            this.labelHersteller.Text = "Hersteller";
            // 
            // textBoxHersteller
            // 
            this.textBoxHersteller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxHersteller.Location = new System.Drawing.Point(59, 70);
            this.textBoxHersteller.Name = "textBoxHersteller";
            this.textBoxHersteller.Size = new System.Drawing.Size(110, 20);
            this.textBoxHersteller.TabIndex = 2;
            // 
            // labelKraftstoff
            // 
            this.labelKraftstoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelKraftstoff.AutoSize = true;
            this.labelKraftstoff.Location = new System.Drawing.Point(59, 144);
            this.labelKraftstoff.Name = "labelKraftstoff";
            this.labelKraftstoff.Size = new System.Drawing.Size(49, 13);
            this.labelKraftstoff.TabIndex = 5;
            this.labelKraftstoff.Text = "Kraftstoff";
            // 
            // labelKennzeichen
            // 
            this.labelKennzeichen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelKennzeichen.AutoSize = true;
            this.labelKennzeichen.Location = new System.Drawing.Point(59, 98);
            this.labelKennzeichen.Name = "labelKennzeichen";
            this.labelKennzeichen.Size = new System.Drawing.Size(69, 13);
            this.labelKennzeichen.TabIndex = 7;
            this.labelKennzeichen.Text = "Kennzeichen";
            // 
            // textBoxKennzeichen
            // 
            this.textBoxKennzeichen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxKennzeichen.Location = new System.Drawing.Point(59, 114);
            this.textBoxKennzeichen.Name = "textBoxKennzeichen";
            this.textBoxKennzeichen.Size = new System.Drawing.Size(110, 20);
            this.textBoxKennzeichen.TabIndex = 6;
            // 
            // labelHeadline
            // 
            this.labelHeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelHeadline.AutoSize = true;
            this.labelHeadline.BackColor = System.Drawing.Color.LightYellow;
            this.labelHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadline.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelHeadline.Location = new System.Drawing.Point(79, 18);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(190, 24);
            this.labelHeadline.TabIndex = 8;
            this.labelHeadline.Text = "Fahrzeug hinzufügen";
            // 
            // comboBoxKraftstoff
            // 
            this.comboBoxKraftstoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxKraftstoff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKraftstoff.FormattingEnabled = true;
            this.comboBoxKraftstoff.Items.AddRange(new object[] {
            "Benzin",
            "Diesel",
            "Elektro",
            "Gas"});
            this.comboBoxKraftstoff.Location = new System.Drawing.Point(59, 160);
            this.comboBoxKraftstoff.Name = "comboBoxKraftstoff";
            this.comboBoxKraftstoff.Size = new System.Drawing.Size(110, 21);
            this.comboBoxKraftstoff.TabIndex = 9;
            // 
            // buttonAddFahrzeug
            // 
            this.buttonAddFahrzeug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFahrzeug.Location = new System.Drawing.Point(262, 349);
            this.buttonAddFahrzeug.Name = "buttonAddFahrzeug";
            this.buttonAddFahrzeug.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFahrzeug.TabIndex = 10;
            this.buttonAddFahrzeug.Text = "Hinzufügen";
            this.buttonAddFahrzeug.UseVisualStyleBackColor = true;
            this.buttonAddFahrzeug.Click += new System.EventHandler(this.buttonAddFahrzeug_Click_1);
            // 
            // textBoxVerbrauch
            // 
            this.textBoxVerbrauch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxVerbrauch.Location = new System.Drawing.Point(182, 161);
            this.textBoxVerbrauch.MaxLength = 20;
            this.textBoxVerbrauch.Name = "textBoxVerbrauch";
            this.textBoxVerbrauch.Size = new System.Drawing.Size(110, 20);
            this.textBoxVerbrauch.TabIndex = 11;
            // 
            // labelVerbrauch
            // 
            this.labelVerbrauch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelVerbrauch.AutoSize = true;
            this.labelVerbrauch.Location = new System.Drawing.Point(182, 144);
            this.labelVerbrauch.Name = "labelVerbrauch";
            this.labelVerbrauch.Size = new System.Drawing.Size(97, 13);
            this.labelVerbrauch.TabIndex = 12;
            this.labelVerbrauch.Text = "Kraftstoffverbrauch";
            // 
            // labelStandort
            // 
            this.labelStandort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelStandort.AutoSize = true;
            this.labelStandort.Location = new System.Drawing.Point(59, 247);
            this.labelStandort.Name = "labelStandort";
            this.labelStandort.Size = new System.Drawing.Size(94, 13);
            this.labelStandort.TabIndex = 13;
            this.labelStandort.Text = "Standort (Adresse)";
            // 
            // textBoxStandort
            // 
            this.textBoxStandort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxStandort.Location = new System.Drawing.Point(59, 263);
            this.textBoxStandort.MaxLength = 20;
            this.textBoxStandort.Name = "textBoxStandort";
            this.textBoxStandort.Size = new System.Drawing.Size(110, 20);
            this.textBoxStandort.TabIndex = 14;
            // 
            // labelTankgroesse
            // 
            this.labelTankgroesse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTankgroesse.AutoSize = true;
            this.labelTankgroesse.Location = new System.Drawing.Point(59, 194);
            this.labelTankgroesse.Name = "labelTankgroesse";
            this.labelTankgroesse.Size = new System.Drawing.Size(109, 13);
            this.labelTankgroesse.TabIndex = 16;
            this.labelTankgroesse.Text = "Tankgroesse (in Liter)";
            // 
            // textBoxTankgroesse
            // 
            this.textBoxTankgroesse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxTankgroesse.Location = new System.Drawing.Point(59, 211);
            this.textBoxTankgroesse.MaxLength = 20;
            this.textBoxTankgroesse.Name = "textBoxTankgroesse";
            this.textBoxTankgroesse.Size = new System.Drawing.Size(110, 20);
            this.textBoxTankgroesse.TabIndex = 15;
            // 
            // labelTankstand
            // 
            this.labelTankstand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTankstand.AutoSize = true;
            this.labelTankstand.Location = new System.Drawing.Point(182, 194);
            this.labelTankstand.Name = "labelTankstand";
            this.labelTankstand.Size = new System.Drawing.Size(98, 13);
            this.labelTankstand.TabIndex = 18;
            this.labelTankstand.Text = "Tankstand (in Liter)";
            // 
            // textBoxTankstand
            // 
            this.textBoxTankstand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxTankstand.Location = new System.Drawing.Point(182, 211);
            this.textBoxTankstand.MaxLength = 20;
            this.textBoxTankstand.Name = "textBoxTankstand";
            this.textBoxTankstand.Size = new System.Drawing.Size(110, 20);
            this.textBoxTankstand.TabIndex = 17;
            // 
            // textBoxPreis
            // 
            this.textBoxPreis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxPreis.Location = new System.Drawing.Point(59, 313);
            this.textBoxPreis.MaxLength = 20;
            this.textBoxPreis.Name = "textBoxPreis";
            this.textBoxPreis.Size = new System.Drawing.Size(110, 20);
            this.textBoxPreis.TabIndex = 20;
            // 
            // labelPreis
            // 
            this.labelPreis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelPreis.AutoSize = true;
            this.labelPreis.Location = new System.Drawing.Point(59, 297);
            this.labelPreis.Name = "labelPreis";
            this.labelPreis.Size = new System.Drawing.Size(71, 13);
            this.labelPreis.TabIndex = 19;
            this.labelPreis.Text = "Preis (Einheit)";
            // 
            // FahrzeugDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(344, 381);
            this.Controls.Add(this.textBoxPreis);
            this.Controls.Add(this.labelPreis);
            this.Controls.Add(this.labelTankstand);
            this.Controls.Add(this.textBoxTankstand);
            this.Controls.Add(this.labelTankgroesse);
            this.Controls.Add(this.textBoxTankgroesse);
            this.Controls.Add(this.textBoxStandort);
            this.Controls.Add(this.labelStandort);
            this.Controls.Add(this.labelVerbrauch);
            this.Controls.Add(this.textBoxVerbrauch);
            this.Controls.Add(this.buttonAddFahrzeug);
            this.Controls.Add(this.comboBoxKraftstoff);
            this.Controls.Add(this.labelHeadline);
            this.Controls.Add(this.labelKennzeichen);
            this.Controls.Add(this.textBoxKennzeichen);
            this.Controls.Add(this.labelKraftstoff);
            this.Controls.Add(this.labelHersteller);
            this.Controls.Add(this.textBoxHersteller);
            this.Controls.Add(this.labelModell);
            this.Controls.Add(this.textBoxModell);
            this.Name = "FahrzeugDialogForm";
            this.Text = "FahrzeugDialogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxModell;
        private System.Windows.Forms.Label labelModell;
        private System.Windows.Forms.Label labelHersteller;
        private System.Windows.Forms.TextBox textBoxHersteller;
        private System.Windows.Forms.Label labelKraftstoff;
        private System.Windows.Forms.Label labelKennzeichen;
        private System.Windows.Forms.TextBox textBoxKennzeichen;
        private System.Windows.Forms.Label labelHeadline;
        private System.Windows.Forms.ComboBox comboBoxKraftstoff;
        private System.Windows.Forms.Button buttonAddFahrzeug;
        private System.Windows.Forms.TextBox textBoxVerbrauch;
        private System.Windows.Forms.Label labelVerbrauch;
        private System.Windows.Forms.Label labelStandort;
        private System.Windows.Forms.TextBox textBoxStandort;
        private System.Windows.Forms.Label labelTankgroesse;
        private System.Windows.Forms.TextBox textBoxTankgroesse;
        private System.Windows.Forms.Label labelTankstand;
        private System.Windows.Forms.TextBox textBoxTankstand;
        private System.Windows.Forms.TextBox textBoxPreis;
        private System.Windows.Forms.Label labelPreis;
    }
}