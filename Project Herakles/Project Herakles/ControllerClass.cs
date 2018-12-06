using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Herakles
{
    class ControllerClass
    {
        internal bool Login(string loginName, string password)
        {
            DBController dBController = new DBController();
            if (dBController.checkLoginData(loginName, password) == true)
            {
                MessageBox.Show("Login erfolgreich");
                return true; 
            }
            else
            {
                MessageBox.Show("Login fehlgeschlagen");
                return false;     
            }
            
        }
    }
}
