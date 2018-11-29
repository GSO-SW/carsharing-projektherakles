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
        int telefonNr;
        internal void userHinzufügen(string name, int telefonNr,string email,string adresse,string passwort)
        {
            DBController DBC = new DBController();
            DBC.insertInToKunde(name, telefonNr, email, adresse, passwort);
            MessageBox.Show("Kunde zur Datenbank hinzugef�gt");
        }
        internal void userBearbeiten(string spalte,string name, string newValue)
        {
            DBController DBC = new DBController();
            DBC.updateDB("Kunde",spalte,name,newValue);
            MessageBox.Show("Kunde wurde in der Datenbank aktualisiert");
        }
        internal void userLöschen(string name)
        {
            DBController DBC = new DBController();
            DBC.deleteFromDB("Kunde", "Name", name);
            MessageBox.Show("Kunde wurde in der Datenbank gel�scht");
        }
    }
}
