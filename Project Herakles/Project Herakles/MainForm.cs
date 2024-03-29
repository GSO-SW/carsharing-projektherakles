﻿using System;
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
                if (dBController.checkAdmin(loginForm.loginName) == true)
                {
                    dBController.deleteKunde(loginForm.loginName);
                }
                else
                {
                    MessageBox.Show("Sie haben keine Rechte!");
                }
            }
            else
            {
                MessageBox.Show("User konnte nicht gelöscht werden!");
            }



        }

        private void buttonAddFahrzeug_Click(object sender, EventArgs e)
        {
            FahrzeugDialogForm AddFahrzeug = new FahrzeugDialogForm();
            AddFahrzeug.ShowDialog();
        }

        private void listBoxFahrzeuge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonFahrzeugeausDbinListbox_Click(object sender, EventArgs e)
        {
            DataSet fahrzeugSet;
            DBController dBController = new DBController();
            fahrzeugSet = dBController.selectFahrzeuge();

            DataTable fahrzeuge = fahrzeugSet.Tables[0];
           
            
            listBoxFahrzeuge.DataSource = fahrzeuge;
            listBoxFahrzeuge.ValueMember = "modell";
            listBoxFahrzeuge.DisplayMember = "modell";
        }

        private void buttonFahrzeugDetails_Click(object sender, EventArgs e)
        {

        }
    }

}

