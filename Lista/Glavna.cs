using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista
{
    public partial class Glavna : Form
    {
        List<string> rijeci = new List<string>();
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnDodajNaKraj_Click(object sender, EventArgs e)
        {
            var rijec = txtJednaRijec.Text;
            rijeci.Add(rijec);
            txtJednaRijec.Text = string.Empty;
            AzurirajListbox();
            txtJednaRijec.Focus();
        }

        void AzurirajListbox()
        {
            lstPopis.DataSource = null;
            lstPopis.DataSource = rijeci;
        }

        private void btnDodajNaPoziciju_Click(object sender, EventArgs e)
        {
            var rijec = txtJednaRijec.Text;
            var ok = int.TryParse(txtPozicija.Text, out int pozicija);
            if(!ok)
            {
                MessageBox.Show("Pogrešan format broja");
                return;
            }
            if(pozicija < 0 || pozicija >= rijeci.Count)
            {
                MessageBox.Show("Pozicija je izvan raspona");
                return;
            }
            rijeci.Insert(pozicija, rijec);
            AzurirajListbox();
        }

        private void btnDodajVise_Click(object sender, EventArgs e)
        {
            var poljeRijeci = txtViseRijeci.Text.Split(' ');
            rijeci.AddRange(poljeRijeci);
            AzurirajListbox();
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            var index = lstPopis.SelectedIndex;
            if(index >= 0)
            {
                rijeci.RemoveAt(index);
                AzurirajListbox();
            }
        }

        private void btnIsprazni_Click(object sender, EventArgs e)
        {
            rijeci.Clear();
            AzurirajListbox();
        }
    }
}
