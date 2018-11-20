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

        internal void UserHinzuf�gen()
        {
            DBController DBC = new DBController();
            DBC.InsertInToKunde(Name, TelefonNr, EMail, Adresse, Geburtsdatum, Passwort);
            MessageBox.Show("Kunde zur Datenbank hinzugef�gt");

        }
    }
}

