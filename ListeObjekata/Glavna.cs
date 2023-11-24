using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeObjekata
{
    public partial class Glavna : Form
    {
        List<Igra> igre = new List<Igra>();
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            var naziv = txtNaziv.Text;
            var opis = txtOpis.Text;
            var vrsta = txtVrsta.Text;
            var izdavac = txtIzdavac.Text;
            var unos = txtDatum.Text;
            var ok = DateTime.TryParse(unos, out DateTime datum);
            if (!ok)
            {
                MessageBox.Show("Datum je u pogrešnom formatu");
                return;
            }
            unos = txtCijena.Text;
            ok = double.TryParse(unos, out double cijena);
            if (!ok)
            {
                MessageBox.Show("Cijena je u pogrešnom formatu");
                return;
            }
            try
            {
                var igra = new Igra();
                igra.Naziv = naziv;
                igra.Opis = opis;
                igra.Izdavac = izdavac;
                igra.Vrsta = vrsta;
                igra.DatumIzdavanja = datum;
                igra.Cijena = cijena;
                igre.Add(igra);
                AzurirajGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dogodila se pogreška. Tekst: {ex.Message}");
            }
        }

        void AzurirajGrid()
        {
            dgvIgre.DataSource = null;
            dgvIgre.DataSource = igre;
        }
    }
}
