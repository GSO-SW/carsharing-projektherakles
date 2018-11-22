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
        string name, email, adresse, passwort;

        internal void UserHinzuf�gen(string name, int telefonNr,string email,string adresse,string passwort)
        {
            DBController dbc = new DBController();
            dbc.InsertInToKunde(name, telefonNr, email, adresse, passwort);
            MessageBox.Show("Kunde zur Datenbank hinzugef�gt");
        }
        internal void UserBearbeiten(string spalte,string name, string newValue)
        {
            DBController dbc = new DBController();
            dbc.UpdateDB("Kunde",spalte,name,newValue);
            MessageBox.Show("Kunde wurde in der Datenbank aktualisiert");
        }
        internal void UserL�schen(string name)
        {
            DBController dbc = new DBController();
            dbc.DeleteFromDB("Kunde", "Name", name);
            MessageBox.Show("Kunde wurde in der Datenbank gel�scht");
        }
    }
}
