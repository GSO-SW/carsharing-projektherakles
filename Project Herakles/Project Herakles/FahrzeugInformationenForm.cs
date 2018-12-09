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
    public partial class FahrzeugInformationenForm : Form
    {
        public FahrzeugInformationenForm()
        {
            InitializeComponent();
        }

        private void FelderAusfüllen(string modell, string hersteller, string standort, string kennzeichen, string kraftstoff, double preis, int tankgroesse, int tankstand, int verbrauch)
        {
            textBoxModell.Text = modell;
            textBoxHersteller.Text = hersteller;
            textBoxStandort.Text = standort;
            textBoxKennzeichen.Text = kennzeichen;
            textBoxKraftstoff.Text = kraftstoff;
            textBoxModell.Text = Convert.ToString(preis);
            textBoxTankgroesse.Text = Convert.ToString(tankgroesse);
            textBoxTankstand.Text = Convert.ToString(tankstand);
            textBoxVerbrauch.Text = Convert.ToString(verbrauch);
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
