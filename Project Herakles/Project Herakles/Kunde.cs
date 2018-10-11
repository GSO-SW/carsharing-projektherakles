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

       
            void FillDbUser(string name)
            {
            Name = name;
                using (MySqlDataAdapter a = new MySqlDataAdapter(
 "SELECT Name FROM ", Name))
                {
                    // Use DataAdapter to fill DataTable
                    DataTable t = new DataTable();
                    a.Fill(t);
                }

            }
        }
        }
