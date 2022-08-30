using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvpKnjizara
{
    class Knjiga
    {
        private int id_knjige, broj_strana, cena, kolicina, popust;
        private string autor, naziv;
        public Knjiga()
        {
            
        }

        public int Id_knjige { get => id_knjige; set => id_knjige = value; }
        public int Broj_strana { get => broj_strana; set => broj_strana = value; }
        public int Cena { get => cena; set => cena = value; }
        public int Popust { get => popust; set => popust = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }

        public override string ToString()
        {
            return id_knjige + autor + naziv + cena + popust + broj_strana;
        }
    }
}
