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

        internal void ConnectToDb()
        {
            // create SqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Verbindung Hergestellt");
                    // INTERACTION WITH DATABASE COMES HERE
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

