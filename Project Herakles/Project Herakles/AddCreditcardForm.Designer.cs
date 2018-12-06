namespace Project_Herakles
{
    partial class AddCreditcardForm
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
            this.KontoinhaberLabel = new System.Windows.Forms.Label();
            this.KontoinhaberTextBox = new System.Windows.Forms.TextBox();
            this.KartenNrlabel = new System.Windows.Forms.Label();
            this.KartenNrlTextBox = new System.Windows.Forms.TextBox();
            this.KreditkarteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KontoinhaberLabel
            // 
            this.KontoinhaberLabel.AutoSize = true;
            this.KontoinhaberLabel.Location = new System.Drawing.Point(12, 18);
            this.KontoinhaberLabel.Name = "KontoinhaberLabel";
            this.KontoinhaberLabel.Size = new System.Drawing.Size(70, 13);
            this.KontoinhaberLabel.TabIndex = 0;
            this.KontoinhaberLabel.Text = "Kontoinhaber";
            // 
            // KontoinhaberTextBox
            // 
            this.KontoinhaberTextBox.Location = new System.Drawing.Point(12, 34);
            this.KontoinhaberTextBox.Name = "KontoinhaberTextBox";
            this.KontoinhaberTextBox.Size = new System.Drawing.Size(100, 20);
            this.KontoinhaberTextBox.TabIndex = 1;
            this.KontoinhaberTextBox.TextChanged += new System.EventHandler(this.KontoinhaberTextBox_TextChanged);
            // 
            // KartenNrlabel
            // 
            this.KartenNrlabel.AutoSize = true;
            this.KartenNrlabel.Location = new System.Drawing.Point(9, 77);
            this.KartenNrlabel.Name = "KartenNrlabel";
            this.KartenNrlabel.Size = new System.Drawing.Size(80, 13);
            this.KartenNrlabel.TabIndex = 2;
            this.KartenNrlabel.Text = "Karten Nummer";
            // 
            // KartenNrlTextBox
            // 
            this.KartenNrlTextBox.Location = new System.Drawing.Point(12, 93);
            this.KartenNrlTextBox.Name = "KartenNrlTextBox";
            this.KartenNrlTextBox.Size = new System.Drawing.Size(100, 20);
            this.KartenNrlTextBox.TabIndex = 3;
            this.KartenNrlTextBox.TextChanged += new System.EventHandler(this.KartenNrlTextBox_TextChanged);
            // 
            // KreditkarteButton
            // 
            this.KreditkarteButton.Location = new System.Drawing.Point(7, 133);
            this.KreditkarteButton.Name = "KreditkarteButton";
            this.KreditkarteButton.Size = new System.Drawing.Size(131, 23);
            this.KreditkarteButton.TabIndex = 4;
            this.KreditkarteButton.Text = "Kreditkarte hinzufügen";
            this.KreditkarteButton.UseVisualStyleBackColor = true;
            // 
            // AddCreditcardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 168);
            this.Controls.Add(this.KreditkarteButton);
            this.Controls.Add(this.KartenNrlTextBox);
            this.Controls.Add(this.KartenNrlabel);
            this.Controls.Add(this.KontoinhaberTextBox);
            this.Controls.Add(this.KontoinhaberLabel);
            this.Name = "AddCreditcardForm";
            this.Text = "AddCreditcardForm";
            this.Load += new System.EventHandler(this.AddCreditcardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KontoinhaberLabel;
        private System.Windows.Forms.TextBox KontoinhaberTextBox;
        private System.Windows.Forms.Label KartenNrlabel;
        private System.Windows.Forms.TextBox KartenNrlTextBox;
        private System.Windows.Forms.Button KreditkarteButton;
    }
}