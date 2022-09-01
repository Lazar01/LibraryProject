using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvpKnjizara
{
    public partial class Form1 : Form
    {
        KnjizaraDataSet ds;
        OleDbDataAdapter daRacun;
        OleDbDataAdapter daStavkaRacuna;

        BazaKnjige baza;
        Racun noviRacun;
        List<Knjiga> listaSortiranjeKnjige, listaKnjigePoZanrovima, listaIzabraneKnjige;
        List<Zanr> listaZanrovi;
        List<Pripadnost> listaPripadnost;
        List<Racun> listaRacuni;

        int kolicinaKnjiga;
        int ukupnaCena = 0, brojProdajeSvihK=0, brojProdajeIzabraneK=0;
        string biloKojiZanr;

        string connString;
        public Form1()
        {
            InitializeComponent();
            connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Projekti\TvpKnjizara\TvpKnjizara\Knjizara.accdb'";
            //ds = new KnjizaraDataSet();
            //daRacun = new OleDbDataAdapter("SELECT * FROM RACUN", connString);
            //daStavkaRacuna = new OleDbDataAdapter("SELECT * FROM STAVKA_RACUNA", connString);
            baza = new BazaKnjige(connString);
            listaSortiranjeKnjige = new List<Knjiga>();
            listaZanrovi = new List<Zanr>();
            listaPripadnost = new List<Pripadnost>();
            listaKnjigePoZanrovima = new List<Knjiga>();
            listaRacuni = new List<Racun>();
            listaIzabraneKnjige = new List<Knjiga>();
            noviRacun = new Racun();
            biloKojiZanr = "Bilo koji";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


            // Ucitavanje knjiga u listu listaSortiranjeKnjige
            try
            {
                baza.otvoriKonekciju();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM KNJIGA";
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Knjiga k = new Knjiga();
                    k.Id_knjige = int.Parse(reader["id_knjiga"].ToString());
                    k.Autor = (reader["autor"].ToString());
                    k.Naziv = (reader["naziv"].ToString());
                    k.Cena = int.Parse(reader["cena"].ToString());
                    k.Popust = int.Parse(reader["popust"].ToString());
                    k.Broj_strana = int.Parse(reader["broj_strana"].ToString());
                    listaSortiranjeKnjige.Add(k);
                    //lbKnjige.Items.Add(k);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.zatvoriKonekciju();
            }
            /// Ucitavanje zanrova za knjige
            try
            {
                baza.otvoriKonekciju();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM PRIPADNOST";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pripadnost p = new Pripadnost();
                    p.Id_knjige = int.Parse(reader["id_knjiga"].ToString());
                    p.Id_zanr = int.Parse(reader["id_zanr"].ToString());
                    listaPripadnost.Add(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                baza.zatvoriKonekciju();
            }
            // Ucitavanje zanrova u listu, combobox i checkbox
            try
            {
                baza.otvoriKonekciju();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM ZANR";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Zanr z = new Zanr();
                    z.Id = int.Parse(reader["id_zanr"].ToString());
                    z.Naziv = reader["naziv"].ToString();
                    listaZanrovi.Add(z);
                    cmbZanr.Items.Add(z.Naziv);
                    chkListaZanrovi.Items.Add(z.Naziv);
                }
                cmbZanr.Items.Add(biloKojiZanr);               
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                baza.zatvoriKonekciju();
            }



            /// Ucitavanje racuna
            UcitajRacune();
            


            //Sortiranje knjiga po alfabetu
            SortiranjeListeKnjiga(listaSortiranjeKnjige);
            //Ucitavanje sortirane liste u datagridview
            dgvKnjige.DataSource = listaSortiranjeKnjige;
            txtKolicina.KeyPress += TxtKolicina_KeyPress;
            txtAutor.KeyPress += TxtAutor_KeyPress;
            txtNaziv.KeyPress += TxtNaziv_KeyPress;
            txtCena.KeyPress += TxtCena_KeyPress;
            txtPopust.KeyPress += TxtPopust_KeyPress;
            txtBrojStrana.KeyPress += TxtBrojStrana_KeyPress;

            dtpDatumOd.Value = DateTime.Now;
            dtpDatumDo.Value = DateTime.Now;

            dtpDatumOd.MinDate = DateTime.Now.AddYears(-1);
            dtpDatumOd.MaxDate = DateTime.Now;
            dtpDatumDo.MaxDate = DateTime.Now;

        }
        private void TxtKolicina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                if (e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
        }
        private void TxtBrojStrana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                if (e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
        }

        private void TxtPopust_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                if (e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
        }

        private void TxtCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                if (e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
        }

        private void TxtNaziv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                    e.Handled = true;
        }

        private void TxtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                    e.Handled = true;
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (dgvRacun.SelectedRows.Count != 0)
            {
                var izabraniRed = dgvRacun.CurrentRow.DataBoundItem as Knjiga;
                foreach (var idKnjige in listaIzabraneKnjige)
                {
                    if (idKnjige.Id_knjige == izabraniRed.Id_knjige)
                    {
                        listaIzabraneKnjige.Remove(idKnjige);
                        break;
                    }
                }
                ukupnaCena -= int.Parse(txtKolicina.Text) * (izabraniRed.Cena - (int)(izabraniRed.Cena * ((double)izabraniRed.Popust / 100)));
                lblUkupnaCena.Text = "Cena: " + ukupnaCena;
                dgvRacun.DataSource = null;
                dgvRacun.DataSource = listaIzabraneKnjige;
            }
            else MessageBox.Show("Niste izabrali red za brisanje! Molimo vas izaberite red");
        }

        private void btnUkloniSve_Click(object sender, EventArgs e)
        {
            listaIzabraneKnjige.Clear();
            dgvRacun.DataSource = null;
            lblUkupnaCena.Text = "Cena:";
            ukupnaCena = 0;
        }

        private void dgvKnjige_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var izabraniRed = dgvKnjige.SelectedRows[0].DataBoundItem as Knjiga;
            if (cmbMesec.SelectedIndex != -1)
            {
                ProveraDatumaZaCrtanje();
                pnlStatistika.Invalidate();
            }
            //var red = dgvKnjige.SelectedRows[0];
            if (txtKolicina.Text.Trim() != "" && int.Parse(txtKolicina.Text) != 0)
            {
                //Onemogucava kliktanja na nazive i time unosenje u tabelu
                if (e.RowIndex < 0)
                {

                }
                else
                {
                    if (listaIzabraneKnjige.Count != 0)
                    {
                        if (!PoklapanjeKnjigeNaRacunu(izabraniRed))
                        {
                            PodesavanjeStavkiRacuna(izabraniRed);

                        }
                    }
                    else
                    {
                        PodesavanjeStavkiRacuna(izabraniRed);
                    }
                }
            }
        }


        private void btnIzdavanjeRacuna_Click(object sender, EventArgs e)
        {
            if (listaIzabraneKnjige.Count != 0)
            {
                try
                {
                    baza.otvoriKonekciju();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baza.Conn;
                    cmd.CommandText = "INSERT INTO RACUN(datum,ukupna_cena)" + "VALUES(@datum,@cena)";
                    cmd.Parameters.AddWithValue("datum", noviRacun.Datum.Date);
                    cmd.Parameters.AddWithValue("cena", noviRacun.Ukupna_cena);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("UspeŠno ste otkucali račun.");
                    dgvRacun.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    baza.zatvoriKonekciju();
                }
                listaRacuni.Clear();
                UcitajRacune();

                OleDbTransaction transaction = null;
                ///Ucitavanje u stavke racuna
                try
                {
                    baza.otvoriKonekciju();
                    OleDbCommand cmd = new OleDbCommand();

                    transaction = baza.Conn.BeginTransaction(IsolationLevel.ReadCommitted);
                    cmd.Connection = baza.Conn;
                    cmd.Transaction = transaction;
                    string val = "";

                    foreach (var izabranaKnjiga in listaIzabraneKnjige)
                    {
                        //cmd.CommandText = "INSERT INTO STAVKA_RACUNA(id_racun, id_knjiga, cena, popust, kolicina)"
                        //+ "VALUES(@idracun,@idknjiga,@cena,@popust,@kolicina)";
                        //cmd.Parameters.AddWithValue("idracun", listaRacuni[listaRacuni.Count-1].Id_racuna);
                        //cmd.Parameters.AddWithValue("idknjiga", izabranaKnjiga.Id_knjige);
                        //cmd.Parameters.AddWithValue("cena", izabranaKnjiga.Cena);
                        //cmd.Parameters.AddWithValue("popust", izabranaKnjiga.Popust);
                        //cmd.Parameters.AddWithValue("kolicina", izabranaKnjiga.Kolicina);
                        //cmd.ExecuteNonQuery();
                        val = "(" + listaRacuni[listaRacuni.Count - 1].Id_racuna + ", " + izabranaKnjiga.Id_knjige + ", " + izabranaKnjiga.Cena + ", " + izabranaKnjiga.Popust + ", " + izabranaKnjiga.Kolicina + ")";
                        cmd.CommandText = "INSERT INTO Stavka_racuna(id_racun, id_knjiga, cena, popust, kolicina) VALUES " + val + ";";
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    listaIzabraneKnjige.Clear();


                }
                catch (Exception)
                {
                    //transaction.Rollback();
                    throw;
                }
                finally
                {
                    baza.zatvoriKonekciju();
                }


                ukupnaCena = 0;
                lblUkupnaCena.Text = "Cena: ";
                brojProdajeIzabraneK = 0;
                brojProdajeSvihK = 0;
            }
            else
                MessageBox.Show("Morate prvo imati nešto na računu.");
        }

        private void btnSnimiKnjigu_Click(object sender, EventArgs e)
        {
            if (txtAutor.Text.Trim() != "" && txtNaziv.Text.Trim() != "" && txtCena.Text.Trim() != "" && txtPopust.Text.Trim() != "" && txtBrojStrana.Text.Trim() != "" && chkListaZanrovi.CheckedItems.Count != 0)
            {

                string val = "";
                List<Zanr> izabraniZanrovi = new List<Zanr>();

                try
                {
                    baza.otvoriKonekciju();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baza.Conn;
                    cmd.CommandText = "INSERT INTO KNJIGA(autor,naziv,cena,popust,broj_strana)" 
                        + "VALUES(@autor,@naziv,@cena,@popust,@brojstrana)";
                    cmd.Parameters.AddWithValue("autor", txtAutor.Text.Trim());
                    cmd.Parameters.AddWithValue("naziv", txtNaziv.Text.Trim());
                    cmd.Parameters.AddWithValue("cena", int.Parse(txtCena.Text));
                    cmd.Parameters.AddWithValue("popust", int.Parse(txtPopust.Text));
                    cmd.Parameters.AddWithValue("brojstrana", int.Parse(txtBrojStrana.Text));
                    cmd.ExecuteNonQuery();
                    txtAutor.Text = "";
                    txtNaziv.Text = "";
                    txtCena.Text = "";
                    txtPopust.Text = "";
                    txtBrojStrana.Text = "";
                    

                    int idKnjige = -1, idZanra = -1;
                    cmd.CommandText = "SELECT MAX(id_knjiga) FROM KNJIGA";
                    idKnjige = (int)cmd.ExecuteScalar();
                    MessageBox.Show(idKnjige + "");
                    for (int i = 0; i < chkListaZanrovi.CheckedItems.Count; i++)
                    {
                        
                        foreach (var zanr in listaZanrovi)
                        {
                            if (zanr.Naziv.Equals(chkListaZanrovi.CheckedItems[i].ToString()))
                            {
                                idZanra = zanr.Id;
                                val = "(" + idKnjige + ", " + idZanra + ")";
                                cmd.CommandText = "INSERT INTO PRIPADNOST(id_knjiga, id_zanr) VALUES " + val + ";";
                                cmd.ExecuteNonQuery();
                            }
                                
                        }
                        
                    }
                    MessageBox.Show("Uspešno ste uneli novu knjigu!");
                    chkListaZanrovi.Items.Clear();
                    foreach (var zanr in listaZanrovi)
                        chkListaZanrovi.Items.Add(zanr.Naziv);

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    baza.zatvoriKonekciju();
                }
            }
            else
                MessageBox.Show("Niste popunili sve parametre!");
        }

        private void cmbZanr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbZanr.SelectedItem.ToString().Equals(biloKojiZanr)))
            {
                dgvKnjige.DataSource = null;
                listaKnjigePoZanrovima.Clear();
                if (cmbZanr.SelectedItem != null)
                {
                    foreach (var nazivZanra in listaZanrovi)
                        if (cmbZanr.SelectedItem.ToString().Equals(nazivZanra.Naziv))
                            foreach (var idPripadnost in listaPripadnost)
                                if (idPripadnost.Id_zanr == nazivZanra.Id)
                                    foreach (var idKnjiga in listaSortiranjeKnjige)
                                        if (idKnjiga.Id_knjige == idPripadnost.Id_knjige)
                                            listaKnjigePoZanrovima.Add(idKnjiga);


                }
                SortiranjeListeKnjiga(listaKnjigePoZanrovima);
                dgvKnjige.DataSource = listaKnjigePoZanrovima;
            }
            else
            {
                dgvKnjige.DataSource = null;
                dgvKnjige.DataSource = listaSortiranjeKnjige;
            }
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            dtpDatumDo.MinDate = dtpDatumOd.Value.AddYears(-1);
            dtpDatumDo.Value = dtpDatumOd.Value;
            dtpDatumDo.MinDate = dtpDatumOd.Value;
            lbRacuni.Items.Clear();
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            lbRacuni.Items.Clear();
            foreach (var racun in listaRacuni)
            {
                if (racun.Datum.CompareTo(dtpDatumOd.Value) >= 0 && racun.Datum.CompareTo(dtpDatumDo.Value) <=0)
                    lbRacuni.Items.Add(racun);
            }
        }

        private void pnlStatistika_Paint(object sender, PaintEventArgs e)
        {
            if (cmbMesec.SelectedIndex != -1 &&  brojProdajeSvihK!=0)
            {
            int procenatProdaje;
                procenatProdaje = brojProdajeIzabraneK * 100 / brojProdajeSvihK;
                int y2 = pnlStatistika.ClientSize.Height * procenatProdaje / 100;
                Point pocetakLinije = new Point(pnlStatistika.Width/3,pnlStatistika.Height);
                Point krajLinije = new Point(pnlStatistika.Width/3, 0);
                Point pocetakDrugeLinije = new Point(pnlStatistika.Width * 2/3, pnlStatistika.Height);
                Point krajDrugeLinije = new Point(pnlStatistika.Width * 2/3, pnlStatistika.Height - y2);
                Pen greenPen = new Pen(Color.Green, 20);
                Pen blackPen = new Pen(Color.Black, 20); // 3 pixels wide
                base.OnPaint(e);
                Graphics dc = e.Graphics;
                dc.DrawLine(blackPen, pocetakLinije,krajLinije);
                dc.DrawLine(greenPen, pocetakDrugeLinije, krajDrugeLinije);
                dc.Dispose();

                lblSveKnjige.Text = "Sve knjige: " + brojProdajeSvihK;
                lblIzabranaKnjiga.Text = "Izabrana knjiga: " + brojProdajeIzabraneK;
                
                brojProdajeSvihK = 0;
                brojProdajeIzabraneK = 0;
            }
        }

        private void PodesavanjeStavkiRacuna(Knjiga izabraniRed)
        {
            //int noviIdRacuna = 1;
            noviRacun.Datum = DateTime.Now;

            ////Postavljanje id-a racuna
            //if (dgvRacun.DataSource == null)
            //{
            //    if (listaRacuni.Count != 0)
            //    {
            //        foreach (var id in listaRacuni)
            //        {
            //            if (id.Id_racuna == noviIdRacuna)
            //                noviIdRacuna++;
            //        }
            //        noviRacun.Id_racuna = noviIdRacuna;
            //    }
            //    else
            //        noviRacun.Id_racuna = 1;
            //    noviIdRacuna = 1;
            //}
            ///Racunanje ukupne cene racuna
            ukupnaCena += int.Parse(txtKolicina.Text) * (izabraniRed.Cena - (int)(izabraniRed.Cena * ((double)izabraniRed.Popust / 100)));
            noviRacun.Ukupna_cena = ukupnaCena;
            Int32.TryParse(txtKolicina.Text, out kolicinaKnjiga);
            izabraniRed.Kolicina = kolicinaKnjiga;

            listaIzabraneKnjige.Add(izabraniRed);


            lblUkupnaCena.Text = "Cena: " + ukupnaCena;

            dgvRacun.DataSource = null;
            dgvRacun.DataSource = listaIzabraneKnjige;
            //dgvRacun[dgvRacun.Columns.Count - 1, dgvRacun.Rows.Count - 1].Value = kolicinaKnjiga;

        }

        private void UcitajRacune()
        {
            try
            {
                baza.otvoriKonekciju();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM RACUN";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Racun r = new Racun();
                    r.Id_racuna = int.Parse(reader["id_racun"].ToString());
                    r.Ukupna_cena = int.Parse(reader["ukupna_cena"].ToString());
                    r.Datum = DateTime.Parse(reader["datum"].ToString());
                    listaRacuni.Add(r);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.zatvoriKonekciju();
            }
        }
        private void ProveraDatumaZaCrtanje()
        {
            try
            {
                baza.otvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM RACUN";
                OleDbDataReader reader = cmd.ExecuteReader();

                int idracuna = -1;
                DateTime datum;
                while (reader.Read())
                {
                    datum = Convert.ToDateTime(reader["datum"].ToString());
                    if (cmbMesec.SelectedIndex + 1 == datum.Month)
                    {
                        
                        idracuna = int.Parse(reader["id_racun"].ToString());
                    }
                    if(idracuna!=-1)
                        idracuna = StatistikaProdajeKnjiga(idracuna);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.zatvoriKonekciju();
            }
        }
        private int StatistikaProdajeKnjiga(int idRac)
        {
            try
            {
                var izabraniRed = dgvKnjige.CurrentRow.DataBoundItem as Knjiga;
                //baza.otvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;

                var val = "WHERE id_racun = " + idRac; 
                cmd.CommandText = "SELECT * FROM STAVKA_RACUNA " + val;
                OleDbDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    brojProdajeSvihK += int.Parse(reader["kolicina"].ToString());
                    if (izabraniRed.Id_knjige == int.Parse(reader["id_knjiga"].ToString()))
                        brojProdajeIzabraneK+= int.Parse(reader["kolicina"].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return -1;
        }
        private void SortiranjeListeKnjiga(List<Knjiga> lista)
        {
            Knjiga zamenaKnjiga = new Knjiga();
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {

                    if (String.Compare(lista[i].Naziv, lista[j].Naziv) > 0)
                    {
                        zamenaKnjiga = lista[i];
                        lista[i] = lista[j];
                        lista[j] = zamenaKnjiga;
                    }
                }
            }
        }

        private bool PoklapanjeKnjigeNaRacunu(Knjiga knjiga)
        {
            foreach (Knjiga izabranaKnjiga in listaIzabraneKnjige)
            {
                if (izabranaKnjiga.Id_knjige == knjiga.Id_knjige)
                {
                    //MessageBox.Show("Izabrna knjiga već postoji na računu!");
                    return true;
                }
            }
            return false;
        }

    }
}
           
