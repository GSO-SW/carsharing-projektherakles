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
        string Name;
        int TelefonNr;
        string EMail;
        string Adresse;
        DateTime Geburtsdatum;
        string Passwort;

        internal void UserHinzufügen()
        {
            DBController DBC = new DBController();
            DBC.InsertInToKunde(Name, TelefonNr, EMail, Adresse, Geburtsdatum, Passwort);
            MessageBox.Show("Kunde zur Datenbank hinzugefügt");
        }
        internal void UserBearbeiten(string Name, string NewValue)
        {
            DBController DBC = new DBController();
            DBC.UpdateToKunde(Name,NewValue);
            MessageBox.Show("Kunde wurde in der Datenbank aktualisiert");
        }
    }
}

