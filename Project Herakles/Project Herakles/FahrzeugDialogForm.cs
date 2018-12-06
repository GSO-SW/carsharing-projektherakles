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
    public partial class FahrzeugDialogForm : Form
    {
        public FahrzeugDialogForm()
        {
            InitializeComponent();
        }

        private void buttonAddFahrzeug_Click(object sender, EventArgs e)
        {
            Fahrzeug fahrzeug = new Fahrzeug();
            try
            {
                fahrzeug.fahrzeugHinzufuegen(textBoxModell.Text, textBoxHersteller.Text, textBoxStandort.Text, textBoxKennzeichen.Text, comboBoxKraftstoff.Text, Convert.ToDouble(textBoxPreis.Text), Convert.ToInt32(textBoxTankgroesse.Text), Convert.ToInt32(textBoxTankstand.Text), Convert.ToInt32(textBoxVerbrauch.Text));
                MessageBox.Show("Fahrzeug erfolgreich hinzugefügt");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Fahrzeug konnte nicht hinzugefügt werden,\nüberprüfen sie ihre Angaben!");
            }
        }
    }
}
