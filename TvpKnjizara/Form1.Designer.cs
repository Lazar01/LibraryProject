
namespace TvpKnjizara
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvKnjige = new System.Windows.Forms.DataGridView();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.pnlRacun = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnIzdavanjeRacuna = new System.Windows.Forms.Button();
            this.lblUkupnaCena = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnUkloniSve = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.lblRacun = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.txtBrojStrana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkListaZanrovi = new System.Windows.Forms.CheckedListBox();
            this.btnSnimiKnjigu = new System.Windows.Forms.Button();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.lbRacuni = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlStatistika = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMesec = new System.Windows.Forms.ComboBox();
            this.lblSveKnjige = new System.Windows.Forms.Label();
            this.lblIzabranaKnjiga = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlNajprodavanijeKnjige = new System.Windows.Forms.Panel();
            this.lblNajprodKnjiga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).BeginInit();
            this.pnlRacun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            this.pnlNajprodavanijeKnjige.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbZanr
            // 
            this.cmbZanr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(130, 61);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(121, 21);
            this.cmbZanr.TabIndex = 1;
            this.cmbZanr.SelectedIndexChanged += new System.EventHandler(this.cmbZanr_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kolicina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Žanrovi";
            // 
            // dgvKnjige
            // 
            this.dgvKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjige.Location = new System.Drawing.Point(12, 88);
            this.dgvKnjige.MultiSelect = false;
            this.dgvKnjige.Name = "dgvKnjige";
            this.dgvKnjige.ReadOnly = true;
            this.dgvKnjige.RowHeadersWidth = 30;
            this.dgvKnjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKnjige.Size = new System.Drawing.Size(387, 192);
            this.dgvKnjige.TabIndex = 8;
            this.dgvKnjige.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKnjige_CellClick);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(20, 61);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 20);
            this.txtKolicina.TabIndex = 9;
            // 
            // pnlRacun
            // 
            this.pnlRacun.Controls.Add(this.label12);
            this.pnlRacun.Controls.Add(this.btnIzdavanjeRacuna);
            this.pnlRacun.Controls.Add(this.lblUkupnaCena);
            this.pnlRacun.Controls.Add(this.lblDatum);
            this.pnlRacun.Controls.Add(this.btnUkloniSve);
            this.pnlRacun.Controls.Add(this.btnUkloni);
            this.pnlRacun.Controls.Add(this.dgvRacun);
            this.pnlRacun.Controls.Add(this.lblRacun);
            this.pnlRacun.Location = new System.Drawing.Point(679, 58);
            this.pnlRacun.Name = "pnlRacun";
            this.pnlRacun.Size = new System.Drawing.Size(262, 302);
            this.pnlRacun.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(259, 137);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "label12";
            // 
            // btnIzdavanjeRacuna
            // 
            this.btnIzdavanjeRacuna.Location = new System.Drawing.Point(73, 264);
            this.btnIzdavanjeRacuna.Name = "btnIzdavanjeRacuna";
            this.btnIzdavanjeRacuna.Size = new System.Drawing.Size(132, 23);
            this.btnIzdavanjeRacuna.TabIndex = 7;
            this.btnIzdavanjeRacuna.Text = "Odštampaj račun";
            this.btnIzdavanjeRacuna.UseVisualStyleBackColor = true;
            this.btnIzdavanjeRacuna.Click += new System.EventHandler(this.btnIzdavanjeRacuna_Click);
            // 
            // lblUkupnaCena
            // 
            this.lblUkupnaCena.AutoSize = true;
            this.lblUkupnaCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupnaCena.Location = new System.Drawing.Point(107, 41);
            this.lblUkupnaCena.Name = "lblUkupnaCena";
            this.lblUkupnaCena.Size = new System.Drawing.Size(51, 20);
            this.lblUkupnaCena.TabIndex = 6;
            this.lblUkupnaCena.Text = "Cena:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(108, 366);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(45, 16);
            this.lblDatum.TabIndex = 4;
            this.lblDatum.Text = "label1";
            // 
            // btnUkloniSve
            // 
            this.btnUkloniSve.Location = new System.Drawing.Point(148, 231);
            this.btnUkloniSve.Name = "btnUkloniSve";
            this.btnUkloniSve.Size = new System.Drawing.Size(101, 21);
            this.btnUkloniSve.TabIndex = 3;
            this.btnUkloniSve.Text = "Ukloni sve";
            this.btnUkloniSve.UseVisualStyleBackColor = true;
            this.btnUkloniSve.Click += new System.EventHandler(this.btnUkloniSve_Click);
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(16, 231);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(103, 21);
            this.btnUkloni.TabIndex = 2;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // dgvRacun
            // 
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Location = new System.Drawing.Point(3, 69);
            this.dgvRacun.MultiSelect = false;
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.ReadOnly = true;
            this.dgvRacun.RowHeadersWidth = 123;
            this.dgvRacun.Size = new System.Drawing.Size(256, 150);
            this.dgvRacun.TabIndex = 1;
            // 
            // lblRacun
            // 
            this.lblRacun.AutoSize = true;
            this.lblRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacun.Location = new System.Drawing.Point(91, 4);
            this.lblRacun.Name = "lblRacun";
            this.lblRacun.Size = new System.Drawing.Size(81, 24);
            this.lblRacun.TabIndex = 0;
            this.lblRacun.Text = "RAČUN";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(64, 318);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 12;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(182, 318);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 13;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(64, 355);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 14;
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(182, 355);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(100, 20);
            this.txtPopust.TabIndex = 15;
            // 
            // txtBrojStrana
            // 
            this.txtBrojStrana.Location = new System.Drawing.Point(64, 391);
            this.txtBrojStrana.Name = "txtBrojStrana";
            this.txtBrojStrana.Size = new System.Drawing.Size(100, 20);
            this.txtBrojStrana.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Naziv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Popust";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Broj strana";
            // 
            // chkListaZanrovi
            // 
            this.chkListaZanrovi.FormattingEnabled = true;
            this.chkListaZanrovi.Location = new System.Drawing.Point(182, 391);
            this.chkListaZanrovi.Name = "chkListaZanrovi";
            this.chkListaZanrovi.Size = new System.Drawing.Size(100, 49);
            this.chkListaZanrovi.TabIndex = 22;
            // 
            // btnSnimiKnjigu
            // 
            this.btnSnimiKnjigu.Location = new System.Drawing.Point(64, 432);
            this.btnSnimiKnjigu.Name = "btnSnimiKnjigu";
            this.btnSnimiKnjigu.Size = new System.Drawing.Size(100, 23);
            this.btnSnimiKnjigu.TabIndex = 23;
            this.btnSnimiKnjigu.Text = "Snimi knjigu";
            this.btnSnimiKnjigu.UseVisualStyleBackColor = true;
            this.btnSnimiKnjigu.Click += new System.EventHandler(this.btnSnimiKnjigu_Click);
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumOd.Location = new System.Drawing.Point(417, 323);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(108, 20);
            this.dtpDatumOd.TabIndex = 24;
            this.dtpDatumOd.ValueChanged += new System.EventHandler(this.dtpDatumOd_ValueChanged);
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumDo.Location = new System.Drawing.Point(551, 323);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(106, 20);
            this.dtpDatumDo.TabIndex = 25;
            this.dtpDatumDo.ValueChanged += new System.EventHandler(this.dtpDatumDo_ValueChanged);
            // 
            // lbRacuni
            // 
            this.lbRacuni.FormattingEnabled = true;
            this.lbRacuni.Location = new System.Drawing.Point(417, 364);
            this.lbRacuni.Name = "lbRacuni";
            this.lbRacuni.Size = new System.Drawing.Size(240, 95);
            this.lbRacuni.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(548, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Datum do:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Datum od:";
            // 
            // pnlStatistika
            // 
            this.pnlStatistika.Location = new System.Drawing.Point(427, 85);
            this.pnlStatistika.Name = "pnlStatistika";
            this.pnlStatistika.Size = new System.Drawing.Size(228, 192);
            this.pnlStatistika.TabIndex = 29;
            this.pnlStatistika.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStatistika_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(447, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Statistika prodaje odabrane knjige";
            // 
            // cmbMesec
            // 
            this.cmbMesec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesec.FormattingEnabled = true;
            this.cmbMesec.Items.AddRange(new object[] {
            "Januar",
            "Februar",
            "Mart",
            "April",
            "Maj",
            "Jun",
            "Jul",
            "Avgust",
            "Septembar",
            "Oktobar",
            "Novembar",
            "Decembar"});
            this.cmbMesec.Location = new System.Drawing.Point(274, 61);
            this.cmbMesec.Name = "cmbMesec";
            this.cmbMesec.Size = new System.Drawing.Size(121, 21);
            this.cmbMesec.TabIndex = 30;
            this.cmbMesec.SelectedValueChanged += new System.EventHandler(this.cmbMesec_SelectedValueChanged);
            // 
            // lblSveKnjige
            // 
            this.lblSveKnjige.AutoSize = true;
            this.lblSveKnjige.Location = new System.Drawing.Point(458, 283);
            this.lblSveKnjige.Name = "lblSveKnjige";
            this.lblSveKnjige.Size = new System.Drawing.Size(60, 13);
            this.lblSveKnjige.TabIndex = 31;
            this.lblSveKnjige.Text = "Sve knjige:";
            // 
            // lblIzabranaKnjiga
            // 
            this.lblIzabranaKnjiga.AutoSize = true;
            this.lblIzabranaKnjiga.Location = new System.Drawing.Point(548, 283);
            this.lblIzabranaKnjiga.Name = "lblIzabranaKnjiga";
            this.lblIzabranaKnjiga.Size = new System.Drawing.Size(82, 13);
            this.lblIzabranaKnjiga.TabIndex = 32;
            this.lblIzabranaKnjiga.Text = "Izabrana knjiga:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(241, 45);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Odaberite mesec kako biste videli statistiku";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(209, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 25);
            this.label13.TabIndex = 34;
            this.label13.Text = "Top 3 knjige dana:";
            // 
            // pnlNajprodavanijeKnjige
            // 
            this.pnlNajprodavanijeKnjige.Controls.Add(this.lblNajprodKnjiga);
            this.pnlNajprodavanijeKnjige.Location = new System.Drawing.Point(405, 9);
            this.pnlNajprodavanijeKnjige.Name = "pnlNajprodavanijeKnjige";
            this.pnlNajprodavanijeKnjige.Size = new System.Drawing.Size(199, 31);
            this.pnlNajprodavanijeKnjige.TabIndex = 35;
            // 
            // lblNajprodKnjiga
            // 
            this.lblNajprodKnjiga.AutoSize = true;
            this.lblNajprodKnjiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNajprodKnjiga.Location = new System.Drawing.Point(3, 7);
            this.lblNajprodKnjiga.Name = "lblNajprodKnjiga";
            this.lblNajprodKnjiga.Size = new System.Drawing.Size(12, 16);
            this.lblNajprodKnjiga.TabIndex = 0;
            this.lblNajprodKnjiga.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 481);
            this.Controls.Add(this.pnlNajprodavanijeKnjige);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblIzabranaKnjiga);
            this.Controls.Add(this.lblSveKnjige);
            this.Controls.Add(this.cmbMesec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnlStatistika);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbRacuni);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.btnSnimiKnjigu);
            this.Controls.Add(this.chkListaZanrovi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojStrana);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.pnlRacun);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.dgvKnjige);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbZanr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).EndInit();
            this.pnlRacun.ResumeLayout(false);
            this.pnlRacun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            this.pnlNajprodavanijeKnjige.ResumeLayout(false);
            this.pnlNajprodavanijeKnjige.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvKnjige;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Panel pnlRacun;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnUkloniSve;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.DataGridView dgvRacun;
        private System.Windows.Forms.Label lblRacun;
        private System.Windows.Forms.Label lblUkupnaCena;
        private System.Windows.Forms.Button btnIzdavanjeRacuna;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.TextBox txtBrojStrana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox chkListaZanrovi;
        private System.Windows.Forms.Button btnSnimiKnjigu;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.ListBox lbRacuni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlStatistika;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMesec;
        private System.Windows.Forms.Label lblSveKnjige;
        private System.Windows.Forms.Label lblIzabranaKnjiga;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlNajprodavanijeKnjige;
        private System.Windows.Forms.Label lblNajprodKnjiga;
    }
}

