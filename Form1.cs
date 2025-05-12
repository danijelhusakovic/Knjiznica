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
            Baza.Initialize();
            List<string> uceniciString = FileHandler.ReadAll("ucenici.txt");

            foreach(string ucenikString in uceniciString)
            {
                Ucenik trenutni = Utility.StringToUcenik(ucenikString,'|');
                Baza.Ucenici.Add(trenutni);
            }

            UpdateUcenici(Baza.Ucenici);
        }

        private void UpdateUcenici(List<Ucenik> ucenici)
        {
            lbUcenici.Items.Clear();
            foreach (Ucenik u in ucenici)
            {
                lbUcenici.Items.Add(u);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DetaljiUcenika detaljiUcenika = new DetaljiUcenika();
            detaljiUcenika.ShowDialog();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (lbUcenici.SelectedItem == null)
            {
                MessageBox.Show("Molimo odaberite ucenika");
                return;
            }
            DetaljiUcenika detaljiUcenika = new DetaljiUcenika();
            detaljiUcenika.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (lbUcenici.SelectedItem == null)
            {
                MessageBox.Show("Molimo odaberite ucenika");
                return;
            }
            // TODO: Obrisati ucenika
        }
    }
}
