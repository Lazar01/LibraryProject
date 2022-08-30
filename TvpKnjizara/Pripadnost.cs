using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvpKnjizara
{

    class Pripadnost
    {
        int id_knjige, id_zanr;

        public Pripadnost()
        {

        }

        public int Id_knjige { get => id_knjige; set => id_knjige = value; }
        public int Id_zanr { get => id_zanr; set => id_zanr = value; }

        public override string ToString()
        {
            return id_knjige + "|" +id_zanr;
        }
    }
}
