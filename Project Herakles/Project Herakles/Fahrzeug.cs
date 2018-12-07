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



        internal void fahrzeugHinzufuegen(string modell, string hersteller, string standort, string kennzeichen, string kraftstoff, double preis, int tankgroesse, int tankstand, int verbrauch)
        {
            DBController DBC = new DBController();
            DBC.insertToFahrzeug(modell, hersteller, standort, kennzeichen, kraftstoff, preis, tankgroesse, tankstand, verbrauch);
        }

        internal void fahrzeugBearbeiten(string spalte, string uniquekey, string changedValue)
        {
            DBController DBC = new DBController();
            /*DBC.updateFahrzeugDB();*/
            MessageBox.Show("Fahrzeug wurde in der Datenbank aktualisiert");
        }
        internal void fahrzeugLoeschen()
        {
            DBController DBC = new DBController();
            /*DBC.deleteFromDB();*/
            MessageBox.Show("Fahrzeug wurde aus der Datenbank entfernt");
        }
    }
}