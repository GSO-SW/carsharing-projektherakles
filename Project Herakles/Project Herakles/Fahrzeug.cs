using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_Herakles
{
    class Fahrzeug
    {
        //sollte man den Verbrauch nicht auch lieber als Double speichern?
        int fahrzeugID, tankgroesse, tankstand, verbrauch;
        string modell, hersteller, standort, kennzeichen, kraftstoff;
        double preis;

        internal void fahrzeugHinzufuegen()
        {
            DBController DBC = new DBController();
            DBC.insertToFahrzeug(modell, hersteller, standort, kennzeichen, kraftstoff, preis, tankgroesse, tankstand, verbrauch);
            MessageBox.Show("Fahrzeug erfolgreich hinzugefügt");
        }
    }
}
