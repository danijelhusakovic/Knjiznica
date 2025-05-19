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
            DialogResult dialogResult = detaljiUcenika.ShowDialog();
            switch(dialogResult)
            {
                case DialogResult.OK:
                    MessageBox.Show("OK");
                    break;
                    case DialogResult.Cancel:
                    MessageBox.Show("OK");
                    break;
                default:
                    break;
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (lbUcenici.SelectedItem == null)
            {
                MessageBox.Show("Molimo odaberite ucenika");
                return;
            }
            DetaljiUcenika detaljiUcenika = new DetaljiUcenika();

            Ucenik odabraniUcenik = lbUcenici.SelectedItem as Ucenik;

            DetaljiUcenika.Ucenik = odabraniUcenik;
            DialogResult dialogResult = detaljiUcenika.ShowDialog();
            switch (dialogResult)
            {
                case DialogResult.OK:
                    foreach(Ucenik ucenik in Baza.Ucenici)
                    {
                        if (ucenik.OIB != DetaljiUcenika.Ucenik.OIB) continue;
                        Ucenik izmijenjeniUcenik = DetaljiUcenika.Ucenik;
                        ucenik.Ime = izmijenjeniUcenik.Ime;
                        ucenik.Prezime = izmijenjeniUcenik.Prezime;
                        ucenik.Razred = izmijenjeniUcenik.Razred;
                        UpdateUcenici(Baza.Ucenici);
                    }
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (lbUcenici.SelectedItem == null)
            {
                MessageBox.Show("Molimo odaberite ucenika");
                return;
            }
            

        }
    }
}
