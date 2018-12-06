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
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Kunde kunde = new Kunde();
            kunde.UserHinzufuegen(NameTextBox.Text, Convert.ToInt32(TelefonNrTextBox.Text), EMailTextBox.Text, AdresseTextBox.Text, PasswordtextBox.Text);
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
            {                TelefonNrTextBox.Clear();
                if (TelefonNrTextBox.TextLength > 0)
                {
                    MessageBox.Show("Eingabe kann nicht verarbeitet werden");
                }
            }

        }

        private void AdresseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToString(AdresseTextBox.Text);
            }
            catch (Exception)
            {
                AdresseTextBox.Clear();
                if (AdresseTextBox.TextLength > 0)
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
    }
}
