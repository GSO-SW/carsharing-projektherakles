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
            this.labelHeadline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KontoinhaberLabel
            // 
            this.KontoinhaberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.KontoinhaberLabel.AutoSize = true;
            this.KontoinhaberLabel.Location = new System.Drawing.Point(27, 43);
            this.KontoinhaberLabel.Name = "KontoinhaberLabel";
            this.KontoinhaberLabel.Size = new System.Drawing.Size(70, 13);
            this.KontoinhaberLabel.TabIndex = 0;
            this.KontoinhaberLabel.Text = "Kontoinhaber";
            // 
            // KontoinhaberTextBox
            // 
            this.KontoinhaberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.KontoinhaberTextBox.Location = new System.Drawing.Point(27, 59);
            this.KontoinhaberTextBox.Name = "KontoinhaberTextBox";
            this.KontoinhaberTextBox.Size = new System.Drawing.Size(100, 20);
            this.KontoinhaberTextBox.TabIndex = 1;
            this.KontoinhaberTextBox.TextChanged += new System.EventHandler(this.KontoinhaberTextBox_TextChanged);
            // 
            // KartenNrlabel
            // 
            this.KartenNrlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.KartenNrlabel.AutoSize = true;
            this.KartenNrlabel.Location = new System.Drawing.Point(149, 43);
            this.KartenNrlabel.Name = "KartenNrlabel";
            this.KartenNrlabel.Size = new System.Drawing.Size(80, 13);
            this.KartenNrlabel.TabIndex = 2;
            this.KartenNrlabel.Text = "Karten Nummer";
            // 
            // KartenNrlTextBox
            // 
            this.KartenNrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.KartenNrlTextBox.Location = new System.Drawing.Point(152, 59);
            this.KartenNrlTextBox.Name = "KartenNrlTextBox";
            this.KartenNrlTextBox.Size = new System.Drawing.Size(100, 20);
            this.KartenNrlTextBox.TabIndex = 3;
            this.KartenNrlTextBox.TextChanged += new System.EventHandler(this.KartenNrlTextBox_TextChanged);
            // 
            // KreditkarteButton
            // 
            this.KreditkarteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KreditkarteButton.Location = new System.Drawing.Point(27, 94);
            this.KreditkarteButton.Name = "KreditkarteButton";
            this.KreditkarteButton.Size = new System.Drawing.Size(132, 24);
            this.KreditkarteButton.TabIndex = 4;
            this.KreditkarteButton.Text = "Kreditkarte hinzufügen";
            this.KreditkarteButton.UseVisualStyleBackColor = true;
            // 
            // labelHeadline
            // 
            this.labelHeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelHeadline.AutoSize = true;
            this.labelHeadline.BackColor = System.Drawing.Color.LightYellow;
            this.labelHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadline.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelHeadline.Location = new System.Drawing.Point(40, 9);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(197, 24);
            this.labelHeadline.TabIndex = 9;
            this.labelHeadline.Text = "Kreditkarte hinzufügen";
            // 
            // AddCreditcardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(275, 146);
            this.Controls.Add(this.labelHeadline);
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
        private System.Windows.Forms.Label labelHeadline;
    }
}