using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project_Herakles
{
    class DBController
    {

        // set connection string to my local sql server database
        // can be retrieved from the database connection properties in the Server-Explorer
        string connectionString = @"host=localhost;user=root;database=carsharingdb";
        internal void ConnectToLocalDb()
        {
            // create SqlConnection object
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    // open connection to database
                    con.Open();
                    // INTERACTION WITH DATABASE COMES HERE
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
        
