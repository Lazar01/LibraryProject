using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvpKnjizara
{
    class Racun
    {
        int id_racuna, ukupna_cena;
        DateTime datum;


        public Racun()
        {
        }

        public Racun(int id_racuna, int ukupna_cena, DateTime datum)
        {
            Id_racuna = id_racuna;
            Ukupna_cena = ukupna_cena;
            Datum = datum;
        }

        public int Id_racuna { get => id_racuna; set => id_racuna = value; }
        public int Ukupna_cena { get => ukupna_cena; set => ukupna_cena = value; }
        public DateTime Datum { get => datum; set => datum = value; }

        public override string ToString()
        {
            return Id_racuna + "|" + Ukupna_cena + "|" + Datum;
        }
    }
}
