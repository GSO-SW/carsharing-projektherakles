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

       
        internal void InsertInToKunde(string Name, int TelefonNr, string EMail, string Adresse, string Passwort)
        {
            // create SqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Verbindung Hergestellt");

                    using (MySqlCommand command = new MySqlCommand("INSERT INTO user (RechteID,Name,TelefonNr,EMail,Adresse,Passwort,ZahlungsID) " +
                        "VALUES (1, @Name, @TelefonNr, @EMail,@Adresse, @Passwort,1)", connection))
                    {   /*Datenbank Tabellen attribut Name ist das 1. das 2. ist der variablen name*/
                        command.Parameters.Add(new MySqlParameter("Name", Name));
                        command.Parameters.Add(new MySqlParameter("TelefonNr", TelefonNr));
                        command.Parameters.Add(new MySqlParameter("EMail", EMail));
                        command.Parameters.Add(new MySqlParameter("Adresse", Adresse));
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
        internal void UpdateDB(string Table, string Column, string UrsprungsName, string NewValue)
        {
            // create SqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Verbindung Hergestellt");

                    using (MySqlCommand command = new MySqlCommand("UPDATE @Table SET @Column  = @VeränderterWert WHERE Name = @UrsprungsName", connection))
                    {   /*Datenbank Tabellen attribut Name ist das 1. das 2. ist der variablen name*/
                        command.Parameters.Add(new MySqlParameter("Table", Table));
                        command.Parameters.Add(new MySqlParameter("Column", Column));
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

        internal void DeleteFromDB(string Table,string Column,string UniqueValue)
        {
            // create SqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Verbindung Hergestellt");

                    using (MySqlCommand command = new MySqlCommand("DELETE FROM @Table WHERE @Column = @UniqueValue", connection))
                    {   /*Datenbank Tabellen attribut Name ist das 1. das 2. ist der variablen name*/
                        command.Parameters.Add(new MySqlParameter("Table", Table));
                        command.Parameters.Add(new MySqlParameter("Column", Column));
                        command.Parameters.Add(new MySqlParameter("UniqueValue", UniqueValue));
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
