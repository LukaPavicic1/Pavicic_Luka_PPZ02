using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavičić_Luka_PPZ02
{
    internal class Negazirano
    {
        string naziv, pakiranje, kolicina, cijena;
        
        

        public Negazirano(string naziv, string pakiranje, string kolicina, string cijena)
        {
            this.naziv = naziv;
            this.pakiranje = pakiranje;
            this.kolicina = kolicina;
            this.cijena = cijena;
        }


        public override string ToString()
        {
            return "\nNaziv: " + this.naziv + "\nPakiranje: " + this.pakiranje +
                   "\nKolicina: " + this.kolicina + "\nCijena: " + this.cijena + " kn";
                   
        }




        public string Naziv { get => naziv; set => naziv = value; }
        public string Pakiranje { get => pakiranje; set => pakiranje = value; }
        public string Kolicina { get => kolicina; set => kolicina = value; }
        public string Cijena { get => cijena; set => cijena = value; }
       
    }
}

    

