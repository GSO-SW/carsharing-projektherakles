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

        // set connection string to my local sql server database
        // can be retrieved from the database connection properties in the Server-Explorer
        string connectionString = @"host=localhost;user=root;database=carsharingdb";
        string sql = "SELECT * FROM Kunde WHERE KundenNr = 1";
        
        internal void ConnectToLocalDb()
        {
            // create SqlConnection object
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    // open connection to database
                    con.Open();
                    MessageBox.Show("Verbindung Hergestellt");
                    // INTERACTION WITH DATABASE COMES HERE
                    
                    
daCountry = new MySqlDataAdapter (sql, conn);
                    using (MySqlDataAdapter test = new MySqlDataAdapter (sql, conn))
{
 // Use DataAdapter to fill Dataset
                    DataSet t = new DataSet();
                    test.Fill(t, /*Tabelle(z.b.)*/ Kunde);
}
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    // close connection to database
                    con.Close();
                }

            }
        }
    }
}
        
