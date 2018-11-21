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
        string Passwort;

        internal void UserHinzuf�gen(string Name, int TelefonNr,string EMail,string Adresse,string Passwort)
        {
            DBController DBC = new DBController();
            DBC.InsertInToKunde(Name, TelefonNr, EMail, Adresse, Passwort);
            MessageBox.Show("Kunde zur Datenbank hinzugef�gt");
        }
        internal void UserBearbeiten(string Spalte,string Name, string NewValue)
        {
            DBController DBC = new DBController();
            DBC.UpdateDB("Kunde",Spalte,Name,NewValue);
            MessageBox.Show("Kunde wurde in der Datenbank aktualisiert");
        }
        internal void UserL�schen(string Name)
        {
            DBController DBC = new DBController();
            DBC.DeleteFromDB("Kunde", "Name", Name);
            MessageBox.Show("Kunde wurde in der Datenbank gel�scht");
        }
    }
}

