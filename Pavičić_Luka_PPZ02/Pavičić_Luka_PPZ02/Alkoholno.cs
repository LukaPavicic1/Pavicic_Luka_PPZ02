using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavičić_Luka_PPZ02
{
    internal class Alkoholno
    {
        string naziv, pakiranje, kolicina, cijena;
        int postotak;

        public Alkoholno(string naziv, string pakiranje, string kolicina, string cijena, int postotak)
        {
            this.naziv = naziv;
            this.pakiranje = pakiranje;
            this.kolicina = kolicina;
            this.cijena = cijena;
            this.postotak = postotak;
        }


        public override string ToString()
        {
            return "\nNaziv: " + this.naziv + "\nPakiranje: " + this.pakiranje +
                   "\nKolicina: " + this.kolicina + "\nCijena: " + this.cijena + " kn" +
                   "\nPostotak: " + this.postotak;
        }




        public string Naziv { get => naziv; set => naziv = value; }
        public string Pakiranje { get => pakiranje; set => pakiranje = value; }
        public string Kolicina { get => kolicina; set => kolicina = value; }
        public string Cijena { get => cijena; set => cijena = value; }
        public int Postotak { get => postotak; set => postotak = value; }
    }
}


