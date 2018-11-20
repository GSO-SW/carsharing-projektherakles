using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            using (DBController DBC = new DBController())
            {
                DBC.InsertInToKunde(Name, TelefonNr, EMail, Adresse, Geburtsdatum, Passwort);
            }
            
        }
    }
}

