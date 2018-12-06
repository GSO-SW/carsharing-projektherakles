using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_Herakles
{
    class Kunde
    {
        internal void UserHinzufuegen(string name, int telefonNr, string email, string Strasse, int Hausnummer, string Ort, int PLZ, string passwort,string LoginName, int RechteID)

        {
            DBController DBC = new DBController();
            DBC.insertInToKunde(name, telefonNr, email, Strasse, Hausnummer, Ort, PLZ, passwort,LoginName, RechteID);
            MessageBox.Show("Kunde zur Datenbank hinzugefügt");
        }
        internal void userBearbeiten(string spalte, string name, string newValue)
        {
            DBController DBC = new DBController();
            DBC.updateDB("Kunde", spalte, name, newValue);
            MessageBox.Show("Kunde wurde in der Datenbank aktualisiert");
        }

        internal void UserLoeschen(string loginName)

        {
            DBController DBC = new DBController();
            DBC.deleteFromDB("user", "LoginName", loginName);
            MessageBox.Show("Kunde wurde in der Datenbank gelöscht");
        }
    }
}
