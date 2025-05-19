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
    public partial class DetaljiUcenika : Form
    {
        public static Ucenik Ucenik;
        public DetaljiUcenika()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            this.Dispose();
        }

        private void DetaljiUcenika_Load(object sender, EventArgs e)
        {
            if (Ucenik == null) return;
            tbOIB.Text = Ucenik.OIB;
            tbIme.Text = Ucenik.Ime;
            tbPrezime.Text = Ucenik.Prezime;
            cbRazred.Text = Ucenik.Razred.ToString();
        }
    }
}
