using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Herakles
{
    public partial class AddUserForm : Form
    {
        private int Admin = 1;
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Kunde kunde = new Kunde();
            kunde.UserHinzufuegen(NameTextBox.Text, Convert.ToInt32(TelefonNrTextBox.Text), EMailTextBox.Text, StrasseTextBox.Text, Convert.ToInt32(HausNrTextBox.Text),OrttextBox.Text, Convert.ToInt32(PLZtextBox.Text), PasswordtextBox.Text, LoginNameTextBox.Text, Admin);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToString(NameTextBox.Text);
            }
            catch (Exception)
            {
                NameTextBox.Clear();
                if (NameTextBox.TextLength > 0)
                {
                    MessageBox.Show("Eingabe kann nicht verarbeitet werden");
                }
            }
        }

        private void EMailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToString(EMailTextBox.Text);
            }
            catch (Exception)
            {
                EMailTextBox.Clear();
                if (EMailTextBox.TextLength > 0)
                {
                    MessageBox.Show("Eingabe kann nicht verarbeitet werden");
                }
            }
        }

        private void TelefonNrTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(TelefonNrTextBox.Text);
            }
            catch (Exception)
            {
                TelefonNrTextBox.Clear();
                if (TelefonNrTextBox.TextLength > 0)
                {
                    MessageBox.Show("Eingabe kann nicht verarbeitet werden");
                }
            }

        }
        private void OrttextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToString(OrttextBox.Text);
            }
            catch (Exception)
            {
                OrttextBox.Clear();
                if (OrttextBox.TextLength > 0)
                {
                    MessageBox.Show("Eingabe kann nicht verarbeitet werden");
                }
            }
        }

        private void PLZtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(PLZtextBox.Text);
            }
            catch (Exception)
            {
                PLZtextBox.Clear();
                if (PLZtextBox.TextLength > 0)
                {
                    MessageBox.Show("Eingabe kann nicht verarbeitet werden");
                }
            }
        }

        private void StrasseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToString(StrasseTextBox.Text);
            }
            catch (Exception)
            {
                StrasseTextBox.Clear();
                if (StrasseTextBox.TextLength > 0)
                {
                    MessageBox.Show("Eingabe kann nicht verarbeitet werden");
                }
            }
        }
        private void HausNrTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(HausNrTextBox.Text);
            }
            catch (Exception)
            {
                HausNrTextBox.Clear();
                if (HausNrTextBox.TextLength > 0)
                {
                    MessageBox.Show("Eingabe kann nicht verarbeitet werden");
                }
            }
        }
        private void ZahlungsartlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToString(PasswordtextBox.Text);
            }
            catch (Exception)
            {
                PasswordtextBox.Clear();
                if (PasswordtextBox.TextLength > 0)
                {
                    MessageBox.Show("Eingabe kann nicht verarbeitet werden");
                }
            }
        }

        private void AdminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AdminCheckBox.Checked == true)
            {
                Admin = 2;
            }
            if (AdminCheckBox.Checked == false)
            {
                Admin = 1;
            }
        }
    }
}
