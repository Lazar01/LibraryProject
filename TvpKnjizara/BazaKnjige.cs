using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvpKnjizara
{
    class BazaKnjige
    {
        OleDbConnection conn;

        public BazaKnjige(string connString)
        {
            conn = new OleDbConnection();
            conn.ConnectionString = connString;
        }

        public OleDbConnection Conn { get => conn; set => conn = value; }

        public void otvoriKonekciju()
        {
            if (Conn != null)
                Conn.Open();
        }
        public void zatvoriKonekciju()
        {
            if (Conn != null)
                Conn.Close();
        }
    }
}
