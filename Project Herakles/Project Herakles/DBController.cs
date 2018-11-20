using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_Herakles
{
    class DBController
    {
        string connectionString = @"host=localhost;user=root;database=carsharingdb";

       
        internal void InsertInToKunde(string Name, int TelefonNr, string EMail, string Adresse, DateTime Geburtsdatum, string Passwort)
        {
            // create SqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Verbindung Hergestellt");

                    using (MySqlCommand command = new MySqlCommand("INSERT INTO Kunde VALUES(@Name, @TelefonNr, @EMail, @Adresse, @Geburtsdatum, @Passwort)", connection))
                    {   /*Datenbank Tabellen attribut Name ist das 1. das 2. ist der variablen name*/
                        command.Parameters.Add(new MySqlParameter("Name", Name));
                        command.Parameters.Add(new MySqlParameter("TelefonNr", TelefonNr));
                        command.Parameters.Add(new MySqlParameter("EMail", EMail));
                        command.Parameters.Add(new MySqlParameter("Adresse", Adresse));
                        command.Parameters.Add(new MySqlParameter("Geburtsdatum", Geburtsdatum));
                        command.Parameters.Add(new MySqlParameter("Passwort", Passwort));
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {

                    // close connection from database
                    connection.Close();
                }

            }
        }
        internal void UpdateToKunde(string UrsprungsName, string NewValue)
        {
            // create SqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Verbindung Hergestellt");

                    using (MySqlCommand command = new MySqlCommand("UPDATE Kunde SET Kunde  = @VeränderterWert WHERE Name = @UrsprungsName", connection))
                    {   /*Datenbank Tabellen attribut Name ist das 1. das 2. ist der variablen name*/
                        command.Parameters.Add(new MySqlParameter("VeränderterWert", NewValue));
                        command.Parameters.Add(new MySqlParameter("UrsprungsName", UrsprungsName));
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {

                    // close connection from database
                    connection.Close();
                }

            }
        }

        internal void DeleteKunde(string UrsprungsName)
        {
            // create SqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Verbindung Hergestellt");

                    using (MySqlCommand command = new MySqlCommand("DELETE FROM Kunde WHERE Name = @UrsprungsName", connection))
                    {   /*Datenbank Tabellen attribut Name ist das 1. das 2. ist der variablen name*/
                        command.Parameters.Add(new MySqlParameter("UrsprungsName", UrsprungsName));
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {

                    // close connection from database
                    connection.Close();
                }

            }
        }
    }
}
