using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igre_Klase
{
    internal class Igra
    {
        private string naziv, opis, vrsta, izdavac;
        private DateTime datumIzdavanja;
        private double cijena;

        //verzija bez get-set
        /*public string ProcitajNaziv() { 
            return naziv; 
        }
        public void UpisiNaziv(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Naziv ne smije biti prazan");
            this.naziv = value;
        }*/
        public string Naziv
        {
            get => naziv;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Naziv ne smije biti prazan");
                naziv = value;
            }
        }

        public string Opis { get => opis; set => opis = value; }
        public string Vrsta 
        { 
            get => vrsta;
            set
            {
                string[] vrste = { "Akcijska", "RPG", "Avantura", "Simulacija", "Sport", "Strategija" };
                if (!vrste.Contains(value))
                    throw new ArgumentException("Nedozvoljena vrsta");
                vrsta = value;
            }
        }
        public string Izdavac { get => izdavac; set => izdavac = value; }
        public DateTime DatumIzdavanja { get => datumIzdavanja; set => datumIzdavanja = value; }
        public double Cijena
        {
            get => cijena;
            set
            {
                if (value < 0 || value > 1000)
                    throw new ArgumentOutOfRangeException("Cijena je izvan raspona");
                cijena = value;
            }
        }
    }
}
