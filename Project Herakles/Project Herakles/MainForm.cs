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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            /*loginDialogForm login = new loginDialogForm
            login.ShowDialog();
            if(login.checkRights())
            {*/
            InitializeComponent();
            //}
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUser = new AddUserForm();
            addUser.ShowDialog();
        }

        private void deleteKundeButton_Click(object sender, EventArgs e)
        {

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            if (loginForm.login == true)
            {
                DBController dBController = new DBController();
                dBController.deleteKunde(loginForm.loginName);
            }
            else
            {
                MessageBox.Show("User konnte nicht gelöscht werden!");
            }



        }
    }
}
