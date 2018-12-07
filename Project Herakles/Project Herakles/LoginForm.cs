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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public bool login { get; set; }
        public string loginName { get; set; }
        private void loginButton_Click(object sender, EventArgs e)
        {
            ControllerClass controllerClass = new ControllerClass();
            if (controllerClass.Login(loginNameTextBox.Text, passwordTextBox.Text) == true)
            {
                loginName = loginNameTextBox.Text;
                this.login = true;
                this.Close();
            }
            else
            {
                this.login = false;
                this.Close();
            }
        }
        private void loginNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToString(loginNameTextBox.Text);
            }
            catch (Exception)
            {
                if (loginNameTextBox.TextLength > 0)
                {
                    MessageBox.Show("Eingabe kann nicht verarbeitet werden");
                }
                loginNameTextBox.Clear();
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToString(passwordTextBox.Text);
            }
            catch (Exception)
            {
                if (passwordTextBox.TextLength > 0)
                {
                    MessageBox.Show("Eingabe kann nicht verarbeitet werden");
                }
                passwordTextBox.Clear();
            }
        }

        
    }
}
