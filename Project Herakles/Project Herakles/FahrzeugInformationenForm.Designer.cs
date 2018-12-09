namespace Project_Herakles
{
    partial class FahrzeugInformationenForm
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
            this.buttonBuchen = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.textBoxPreis = new System.Windows.Forms.TextBox();
            this.labelPreis = new System.Windows.Forms.Label();
            this.labelTankstand = new System.Windows.Forms.Label();
            this.textBoxTankstand = new System.Windows.Forms.TextBox();
            this.labelTankgroesse = new System.Windows.Forms.Label();
            this.textBoxTankgroesse = new System.Windows.Forms.TextBox();
            this.textBoxStandort = new System.Windows.Forms.TextBox();
            this.labelStandort = new System.Windows.Forms.Label();
            this.labelVerbrauch = new System.Windows.Forms.Label();
            this.textBoxVerbrauch = new System.Windows.Forms.TextBox();
            this.labelHeadline = new System.Windows.Forms.Label();
            this.labelKennzeichen = new System.Windows.Forms.Label();
            this.textBoxKennzeichen = new System.Windows.Forms.TextBox();
            this.labelKraftstoff = new System.Windows.Forms.Label();
            this.labelHersteller = new System.Windows.Forms.Label();
            this.textBoxHersteller = new System.Windows.Forms.TextBox();
            this.labelModell = new System.Windows.Forms.Label();
            this.textBoxModell = new System.Windows.Forms.TextBox();
            this.textBoxKraftstoff = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBuchen
            // 
            this.buttonBuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuchen.Location = new System.Drawing.Point(219, 353);
            this.buttonBuchen.Name = "buttonBuchen";
            this.buttonBuchen.Size = new System.Drawing.Size(75, 23);
            this.buttonBuchen.TabIndex = 0;
            this.buttonBuchen.Text = "Buchen";
            this.buttonBuchen.UseVisualStyleBackColor = true;
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbbrechen.Location = new System.Drawing.Point(138, 353);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 1;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // textBoxPreis
            // 
            this.textBoxPreis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxPreis.Enabled = false;
            this.textBoxPreis.Location = new System.Drawing.Point(33, 311);
            this.textBoxPreis.MaxLength = 20;
            this.textBoxPreis.Name = "textBoxPreis";
            this.textBoxPreis.ReadOnly = true;
            this.textBoxPreis.Size = new System.Drawing.Size(110, 20);
            this.textBoxPreis.TabIndex = 39;
            // 
            // labelPreis
            // 
            this.labelPreis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelPreis.AutoSize = true;
            this.labelPreis.Enabled = false;
            this.labelPreis.Location = new System.Drawing.Point(33, 295);
            this.labelPreis.Name = "labelPreis";
            this.labelPreis.Size = new System.Drawing.Size(71, 13);
            this.labelPreis.TabIndex = 38;
            this.labelPreis.Text = "Preis (Einheit)";
            // 
            // labelTankstand
            // 
            this.labelTankstand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTankstand.AutoSize = true;
            this.labelTankstand.Enabled = false;
            this.labelTankstand.Location = new System.Drawing.Point(156, 192);
            this.labelTankstand.Name = "labelTankstand";
            this.labelTankstand.Size = new System.Drawing.Size(98, 13);
            this.labelTankstand.TabIndex = 37;
            this.labelTankstand.Text = "Tankstand (in Liter)";
            // 
            // textBoxTankstand
            // 
            this.textBoxTankstand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxTankstand.Enabled = false;
            this.textBoxTankstand.Location = new System.Drawing.Point(156, 209);
            this.textBoxTankstand.MaxLength = 20;
            this.textBoxTankstand.Name = "textBoxTankstand";
            this.textBoxTankstand.ReadOnly = true;
            this.textBoxTankstand.Size = new System.Drawing.Size(110, 20);
            this.textBoxTankstand.TabIndex = 36;
            // 
            // labelTankgroesse
            // 
            this.labelTankgroesse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTankgroesse.AutoSize = true;
            this.labelTankgroesse.Enabled = false;
            this.labelTankgroesse.Location = new System.Drawing.Point(33, 192);
            this.labelTankgroesse.Name = "labelTankgroesse";
            this.labelTankgroesse.Size = new System.Drawing.Size(109, 13);
            this.labelTankgroesse.TabIndex = 35;
            this.labelTankgroesse.Text = "Tankgroesse (in Liter)";
            // 
            // textBoxTankgroesse
            // 
            this.textBoxTankgroesse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxTankgroesse.Enabled = false;
            this.textBoxTankgroesse.Location = new System.Drawing.Point(33, 209);
            this.textBoxTankgroesse.MaxLength = 20;
            this.textBoxTankgroesse.Name = "textBoxTankgroesse";
            this.textBoxTankgroesse.ReadOnly = true;
            this.textBoxTankgroesse.Size = new System.Drawing.Size(110, 20);
            this.textBoxTankgroesse.TabIndex = 34;
            // 
            // textBoxStandort
            // 
            this.textBoxStandort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxStandort.Enabled = false;
            this.textBoxStandort.Location = new System.Drawing.Point(33, 261);
            this.textBoxStandort.MaxLength = 20;
            this.textBoxStandort.Name = "textBoxStandort";
            this.textBoxStandort.ReadOnly = true;
            this.textBoxStandort.Size = new System.Drawing.Size(110, 20);
            this.textBoxStandort.TabIndex = 33;
            // 
            // labelStandort
            // 
            this.labelStandort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelStandort.AutoSize = true;
            this.labelStandort.Enabled = false;
            this.labelStandort.Location = new System.Drawing.Point(33, 245);
            this.labelStandort.Name = "labelStandort";
            this.labelStandort.Size = new System.Drawing.Size(94, 13);
            this.labelStandort.TabIndex = 32;
            this.labelStandort.Text = "Standort (Adresse)";
            // 
            // labelVerbrauch
            // 
            this.labelVerbrauch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelVerbrauch.AutoSize = true;
            this.labelVerbrauch.Enabled = false;
            this.labelVerbrauch.Location = new System.Drawing.Point(156, 142);
            this.labelVerbrauch.Name = "labelVerbrauch";
            this.labelVerbrauch.Size = new System.Drawing.Size(97, 13);
            this.labelVerbrauch.TabIndex = 31;
            this.labelVerbrauch.Text = "Kraftstoffverbrauch";
            // 
            // textBoxVerbrauch
            // 
            this.textBoxVerbrauch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxVerbrauch.Enabled = false;
            this.textBoxVerbrauch.Location = new System.Drawing.Point(156, 159);
            this.textBoxVerbrauch.MaxLength = 20;
            this.textBoxVerbrauch.Name = "textBoxVerbrauch";
            this.textBoxVerbrauch.ReadOnly = true;
            this.textBoxVerbrauch.Size = new System.Drawing.Size(110, 20);
            this.textBoxVerbrauch.TabIndex = 30;
            // 
            // labelHeadline
            // 
            this.labelHeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelHeadline.AutoSize = true;
            this.labelHeadline.BackColor = System.Drawing.Color.LightYellow;
            this.labelHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadline.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelHeadline.Location = new System.Drawing.Point(48, 16);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(210, 24);
            this.labelHeadline.TabIndex = 28;
            this.labelHeadline.Text = "Fahrzeug Informationen";
            // 
            // labelKennzeichen
            // 
            this.labelKennzeichen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelKennzeichen.AutoSize = true;
            this.labelKennzeichen.Enabled = false;
            this.labelKennzeichen.Location = new System.Drawing.Point(33, 96);
            this.labelKennzeichen.Name = "labelKennzeichen";
            this.labelKennzeichen.Size = new System.Drawing.Size(69, 13);
            this.labelKennzeichen.TabIndex = 27;
            this.labelKennzeichen.Text = "Kennzeichen";
            // 
            // textBoxKennzeichen
            // 
            this.textBoxKennzeichen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxKennzeichen.Enabled = false;
            this.textBoxKennzeichen.Location = new System.Drawing.Point(33, 112);
            this.textBoxKennzeichen.Name = "textBoxKennzeichen";
            this.textBoxKennzeichen.ReadOnly = true;
            this.textBoxKennzeichen.Size = new System.Drawing.Size(110, 20);
            this.textBoxKennzeichen.TabIndex = 26;
            // 
            // labelKraftstoff
            // 
            this.labelKraftstoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelKraftstoff.AutoSize = true;
            this.labelKraftstoff.Enabled = false;
            this.labelKraftstoff.Location = new System.Drawing.Point(33, 142);
            this.labelKraftstoff.Name = "labelKraftstoff";
            this.labelKraftstoff.Size = new System.Drawing.Size(49, 13);
            this.labelKraftstoff.TabIndex = 25;
            this.labelKraftstoff.Text = "Kraftstoff";
            // 
            // labelHersteller
            // 
            this.labelHersteller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelHersteller.AutoSize = true;
            this.labelHersteller.Enabled = false;
            this.labelHersteller.Location = new System.Drawing.Point(33, 49);
            this.labelHersteller.Name = "labelHersteller";
            this.labelHersteller.Size = new System.Drawing.Size(51, 13);
            this.labelHersteller.TabIndex = 24;
            this.labelHersteller.Text = "Hersteller";
            // 
            // textBoxHersteller
            // 
            this.textBoxHersteller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxHersteller.Enabled = false;
            this.textBoxHersteller.Location = new System.Drawing.Point(33, 68);
            this.textBoxHersteller.Name = "textBoxHersteller";
            this.textBoxHersteller.ReadOnly = true;
            this.textBoxHersteller.Size = new System.Drawing.Size(110, 20);
            this.textBoxHersteller.TabIndex = 23;
            // 
            // labelModell
            // 
            this.labelModell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelModell.AutoSize = true;
            this.labelModell.Enabled = false;
            this.labelModell.Location = new System.Drawing.Point(156, 49);
            this.labelModell.Name = "labelModell";
            this.labelModell.Size = new System.Drawing.Size(38, 13);
            this.labelModell.TabIndex = 22;
            this.labelModell.Text = "Modell";
            // 
            // textBoxModell
            // 
            this.textBoxModell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxModell.Enabled = false;
            this.textBoxModell.Location = new System.Drawing.Point(156, 68);
            this.textBoxModell.Name = "textBoxModell";
            this.textBoxModell.ReadOnly = true;
            this.textBoxModell.Size = new System.Drawing.Size(110, 20);
            this.textBoxModell.TabIndex = 21;
            // 
            // textBoxKraftstoff
            // 
            this.textBoxKraftstoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxKraftstoff.Enabled = false;
            this.textBoxKraftstoff.Location = new System.Drawing.Point(33, 159);
            this.textBoxKraftstoff.MaxLength = 20;
            this.textBoxKraftstoff.Name = "textBoxKraftstoff";
            this.textBoxKraftstoff.ReadOnly = true;
            this.textBoxKraftstoff.Size = new System.Drawing.Size(110, 20);
            this.textBoxKraftstoff.TabIndex = 40;
            // 
            // FahrzeugInformationenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(306, 388);
            this.Controls.Add(this.textBoxKraftstoff);
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
            this.Controls.Add(this.labelHeadline);
            this.Controls.Add(this.labelKennzeichen);
            this.Controls.Add(this.textBoxKennzeichen);
            this.Controls.Add(this.labelKraftstoff);
            this.Controls.Add(this.labelHersteller);
            this.Controls.Add(this.textBoxHersteller);
            this.Controls.Add(this.labelModell);
            this.Controls.Add(this.textBoxModell);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonBuchen);
            this.Name = "FahrzeugInformationenForm";
            this.Text = "FahrzeugInformationenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuchen;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.TextBox textBoxPreis;
        private System.Windows.Forms.Label labelPreis;
        private System.Windows.Forms.Label labelTankstand;
        private System.Windows.Forms.TextBox textBoxTankstand;
        private System.Windows.Forms.Label labelTankgroesse;
        private System.Windows.Forms.TextBox textBoxTankgroesse;
        private System.Windows.Forms.TextBox textBoxStandort;
        private System.Windows.Forms.Label labelStandort;
        private System.Windows.Forms.Label labelVerbrauch;
        private System.Windows.Forms.TextBox textBoxVerbrauch;
        private System.Windows.Forms.Label labelHeadline;
        private System.Windows.Forms.Label labelKennzeichen;
        private System.Windows.Forms.TextBox textBoxKennzeichen;
        private System.Windows.Forms.Label labelKraftstoff;
        private System.Windows.Forms.Label labelHersteller;
        private System.Windows.Forms.TextBox textBoxHersteller;
        private System.Windows.Forms.Label labelModell;
        private System.Windows.Forms.TextBox textBoxModell;
        private System.Windows.Forms.TextBox textBoxKraftstoff;
    }
}