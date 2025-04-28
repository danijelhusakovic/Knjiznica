using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> uceniciString = FileHandler.ReadAll("ucenici.txt");

            List<Ucenik> ucenici = new List<Ucenik>();

            foreach(string ucenikString in uceniciString)
            {
                Ucenik trenutni = Utility.StringToUcenik(ucenikString,'|');
                ucenici.Add(trenutni);
            }

            foreach(Ucenik u in ucenici)
            {
                lbUcenici.Items.Add(u);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }
    }
}
