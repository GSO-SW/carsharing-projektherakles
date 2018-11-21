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
            InitializeComponent();
            Kunde k = new Kunde();
            k.userHinzufügen("Marvin Kutz",01775666,"MK@gmx.de","Am Ring 4","Geheim");
        }
    }
}
