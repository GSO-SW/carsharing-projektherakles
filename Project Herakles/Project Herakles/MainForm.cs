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
            FahrzeugDialogForm AddFahrzeug = new FahrzeugDialogForm();
            AddFahrzeug.ShowDialog();
        }

        private void buttonFahrzeugInformationen_Click(object sender, EventArgs e)
        {
            FahrzeugInformationenForm FahrzeugInfo = new FahrzeugInformationenForm();
            FahrzeugInfo.ShowDialog();
        }
    }
}
