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
        internal void userHinzufuegen(string name, int telefonNr,string email,string adresse,string passwort)
        {
            DBController DBC = new DBController();
            DBC.insertInToKunde(name, telefonNr, email, adresse, passwort);
            MessageBox.Show("Kunde zur Datenbank hinzugefügt");
        }
        internal void userBearbeiten(string spalte,string name, string newValue)
        {
            DBController DBC = new DBController();
            DBC.updateDB("Kunde",spalte,name,newValue);
            MessageBox.Show("Kunde wurde in der Datenbank aktualisiert");
        }
        internal void userLoeschen(string name)
        {
            DBController DBC = new DBController();
            DBC.deleteFromDB("user", "LoginName", loginName);
            MessageBox.Show("Kunde wurde in der Datenbank gelöscht");
        }
    }
}
