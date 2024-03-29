﻿using System;
using System.Collections.Generic;
using System.Data;
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

        internal DataSet selectFahrzeuge()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MessageBox.Show("Verbindung Hergestellt");

                try
                {
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM fahrzeug", connection))
                    {
                        // Use DataAdapter to fill DataTable
                        DataSet fahrzeuge = new DataSet();
                        dataAdapter.Fill(fahrzeuge);
                        return fahrzeuge;
                    }
                }
                catch (Exception e)
                {

                    throw e;
                }
                
            }
            //try
            //{
            //    using (MySqlConnection connection = new MySqlConnection(connectionString))
            //    {
            //        connection.Open();
            //        MessageBox.Show("Verbindung Hergestellt");

            //        MySqlCommand command = new MySqlCommand("SELECT hersteller " + "FROM fahrzeug " + "WHERE FahrzeugID = @FahrzeugID ", connection);
            //        /*Datenbank Tabellen attribut Name ist das 1. das 2. ist der variablen name*/
            //        command.Parameters.Add(new MySqlParameter("FahrzeugID", FahrzeugID));
            //        command.ExecuteNonQuery();

            //        object result = command.ExecuteScalar();
            //        if (result != null)
            //        {
            //            connection.Close();
            //            hersteller = Convert.ToString(result);
            //            return hersteller;
            //        }
            //        else
            //        {
            //            connection.Close();
            //            hersteller = null;
            //            return hersteller;
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    hersteller = null;
            //    return hersteller;
            //}
        }

        internal void insertInToKunde(string name, int telefonNr, string email, string Strasse, int Hausnummer, string Ort, int PLZ, string passwort, string LoginName, int RechteID)
        {
            // create SqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Verbindung Hergestellt");

                    using (MySqlCommand command = new MySqlCommand("INSERT INTO user (RechteID,Name,TelefonNr,EMail,Strasse,Hausnummer,Ort,PLZ,Passwort,LoginName) " +
                        "VALUES (@RechteID, @Name, @TelefonNr, @EMail,@Strasse,@Hausnummer,@Ort,@PLZ, @Passwort,@LoginName)", connection))
                    {   /*Datenbank Tabellen attribut Name ist das 1. das 2. ist der variablen name*/
                        command.Parameters.Add(new MySqlParameter("Name", name));
                        command.Parameters.Add(new MySqlParameter("TelefonNr", telefonNr));
                        command.Parameters.Add(new MySqlParameter("EMail", email));
                        command.Parameters.Add(new MySqlParameter("Strasse", Strasse));
                        command.Parameters.Add(new MySqlParameter("Hausnummer", Hausnummer));
                        command.Parameters.Add(new MySqlParameter("Ort", Ort));
                        command.Parameters.Add(new MySqlParameter("PLZ", PLZ));
                        command.Parameters.Add(new MySqlParameter("Passwort", passwort));
                        command.Parameters.Add(new MySqlParameter("LoginName", LoginName));
                        command.Parameters.Add(new MySqlParameter("RechteID", RechteID));
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
        }///hinzufügen eines Fahrzeuges in die Datenbank
        internal void updateDB(string table, string column, string originValue, string newValue)
        {
            // create SqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Verbindung Hergestellt");

                    using (MySqlCommand command = new MySqlCommand("UPDATE @Table SET @Column  = @VeränderterWert WHERE @Column = @originValue", connection))
                    {   /*Datenbank Tabellen attribut Name ist das 1. das 2. ist der variablen name*/
                        command.Parameters.Add(new MySqlParameter("Table", table));
                        command.Parameters.Add(new MySqlParameter("Column", column));
                        command.Parameters.Add(new MySqlParameter("VeränderterWert", newValue));
                        command.Parameters.Add(new MySqlParameter("originValue", originValue));
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
        internal bool checkLoginData(string LoginName, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Verbindung Hergestellt");

                    using (MySqlCommand command = new MySqlCommand("SELECT *" +
                        "FROM user " +
                        "WHERE LoginName = @LoginName " +
                        "AND Passwort = @Password", connection))
                    {   /*Datenbank Tabellen attribut Name ist das 1. das 2. ist der variablen name*/
                        command.Parameters.Add(new MySqlParameter("LoginName", LoginName));
                        command.Parameters.Add(new MySqlParameter("Password", password));
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        internal void deleteKunde(string LoginName)
        {
            // create SqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Verbindung Hergestellt");

                    using (MySqlCommand command = new MySqlCommand("DELETE FROM user WHERE LoginName = @LoginName", connection))
                    {   /*Datenbank Tabellen attribut Name ist das 1. das 2. ist der variablen name*/
                        command.Parameters.Add(new MySqlParameter("LoginName", LoginName));
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
        internal bool checkAdmin(string LoginName)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Verbindung Hergestellt");

                    MySqlCommand command = new MySqlCommand("SELECT RechteID " + "FROM user " + "WHERE LoginName = @LoginName ", connection);
                    /*Datenbank Tabellen attribut Name ist das 1. das 2. ist der variablen name*/
                    command.Parameters.Add(new MySqlParameter("LoginName", LoginName));
                    command.ExecuteNonQuery();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        if (Convert.ToInt32(result) == 2)
                        {
                            connection.Close();
                            return true;
                        }
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        internal void deleteFromDB(string table, string column, string uniqueValue)
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
        }///hinzufügen eines Fahrzeuges in die Datenbank
    }
}
