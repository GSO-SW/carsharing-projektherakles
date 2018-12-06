﻿using System;
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

        internal void insertInToKunde(string name, int telefonNr, string email, string adresse, string password)
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
                        command.Parameters.Add(new MySqlParameter("Name", name));
                        command.Parameters.Add(new MySqlParameter("TelefonNr", telefonNr));
                        command.Parameters.Add(new MySqlParameter("EMail", email));
                        command.Parameters.Add(new MySqlParameter("Adresse", adresse));
                        command.Parameters.Add(new MySqlParameter("Passwort", password));
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
        internal void updateDB(string table, string column, string ursprungsName, string newValue)
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
                        command.Parameters.Add(new MySqlParameter("Table", table));
                        command.Parameters.Add(new MySqlParameter("Column", column));
                        command.Parameters.Add(new MySqlParameter("VeränderterWert", newValue));
                        command.Parameters.Add(new MySqlParameter("UrsprungsName", ursprungsName));
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
        internal void deleteFromDB(string table,string column,string uniqueValue)
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
                        command.Parameters.Add(new MySqlParameter("Table", table));
                        command.Parameters.Add(new MySqlParameter("Column", column));
                        command.Parameters.Add(new MySqlParameter("UniqueValue", uniqueValue));
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
        internal void insertToFahrzeug(string modell, string hersteller, string standort, string kennzeichen, string kraftstoff, double preis, int tankgroesse, int tankstand, int verbrauch)
        {
            // create SqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("INSERT INTO fahrzeug (Modell,Hersteller,Preis,Standort,Kennzeichen,Tankgröße,Tankstand,Verbrauch,Kraftstoff) " +
                        "VALUES (@Modell,@Hersteller,@Preis,@Standort,@Kennzeichen,@Tankgröße,@Tankstand,@Verbrauch,@Kraftstoff)", connection))
                    {   /*Datenbank Tabellen attribut Name ist das 1. das 2. ist der variablen name*/

                        command.Parameters.Add(new MySqlParameter("Modell", modell));
                        command.Parameters.Add(new MySqlParameter("Hersteller", hersteller));
                        command.Parameters.Add(new MySqlParameter("Preis", preis));
                        command.Parameters.Add(new MySqlParameter("Standort", standort));
                        command.Parameters.Add(new MySqlParameter("Kennzeichen", kennzeichen));
                        command.Parameters.Add(new MySqlParameter("Tankgröße", tankgroesse));
                        command.Parameters.Add(new MySqlParameter("Tankstand", tankstand));
                        command.Parameters.Add(new MySqlParameter("Verbrauch", verbrauch));
                        command.Parameters.Add(new MySqlParameter("Kraftstoff", kraftstoff));
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
