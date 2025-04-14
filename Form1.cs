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
            // TODO: FileHandler učitava sve učenike
            // List<Ucenik> ucenici = FileHandler.ReadAll();
            FileHandler.Write("jesu dva reda", "test.txt");


            List<string> list = FileHandler.ReadAll("test.txt");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }


            List<Ucenik> ucenici = new List<Ucenik>();
            Ucenik a = new Ucenik("12524612334", "Pero", "Peric", 3);
            Ucenik b = new Ucenik("5734523451", "Hulio", "De la vega", 2);
            Ucenik c = new Ucenik("124574241", "Dzontra", "Volta", 3);
            ucenici.Add(a);
            ucenici.Add(b);
            ucenici.Add(c);

            foreach(Ucenik u in ucenici)
            {
                lbUcenici.Items.Add(u);
            }
        }
    }
}
