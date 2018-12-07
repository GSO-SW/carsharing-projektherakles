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

        private void buttonAddFahrzeug_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            FahrzeugDialogForm AddFahrzeug = new FahrzeugDialogForm();
            AddFahrzeug.ShowDialog();
=======

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



>>>>>>> parent of 6e199ad... Beim löschen eines users wird überprüft, ob der löscher ein admin ist
        }

        private void buttonFahrzeugInformationen_Click(object sender, EventArgs e)
        {
            FahrzeugInformationenForm FahrzeugInfo = new FahrzeugInformationenForm();
            FahrzeugInfo.ShowDialog();
        }
    }
}
