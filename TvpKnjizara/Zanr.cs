using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvpKnjizara
{
    class Zanr
    {
        int id;
        string naziv;
        public Zanr()
        {

        }

        public Zanr(int id, string naziv)
        {
            this.Id = id;
            this.Naziv = naziv;
        }

        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }

        public override string ToString()
        {
            return Id + " | " +Naziv;
        }
    }
}
