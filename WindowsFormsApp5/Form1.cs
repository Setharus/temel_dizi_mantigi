using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] ogretmenler = { "Dursun", "Mehmet", "Ayşe", "Ali", "Tarkan", "Bünyamin", "Serhat", "Sibel", "Emir", "Aslı" };

        private void btnDiziYaz_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Add(ogretmenler[0]);
            lstGoster.Items.Add(ogretmenler[1]);
            lstGoster.Items.Add(ogretmenler[2]);
            lstGoster.Items.Add(ogretmenler[3]);
            lstGoster.Items.Add(ogretmenler[4]);
            lstGoster.Items.Add(ogretmenler[5]);
            lstGoster.Items.Add(ogretmenler[6]);
            lstGoster.Items.Add(ogretmenler[7]);
            lstGoster.Items.Add(ogretmenler[8]);
            lstGoster.Items.Add(ogretmenler[9]);
        }

        private void btnForeachYaz_Click(object sender, EventArgs e)
        {
            foreach(string ogretmen in ogretmenler)
            {
                lstGoster.Items.Add(ogretmen);
            }
        }

        private void btnForYaz_Click(object sender, EventArgs e)
        {
            for(int indis = 0; indis < ogretmenler.Length; indis ++)
            {
                lstGoster.Items.Add(ogretmenler[indis]);
            }
        }
    }
}
