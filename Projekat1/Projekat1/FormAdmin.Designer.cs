
namespace Projekat1
{
    partial class FormAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listKategorije = new System.Windows.Forms.ListBox();
            this.buttonKategorijaObrisi = new System.Windows.Forms.Button();
            this.buttonKategorijaIzmeni = new System.Windows.Forms.Button();
            this.buttonKategorijaDodaj = new System.Windows.Forms.Button();
            this.textKategorija = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboKategorija = new System.Windows.Forms.ComboBox();
            this.textArtikalMera = new System.Windows.Forms.TextBox();
            this.labelArtikalMera = new System.Windows.Forms.Label();
            this.textArtikalCena = new System.Windows.Forms.TextBox();
            this.labelArtikalCena = new System.Windows.Forms.Label();
            this.listArtikli = new System.Windows.Forms.ListBox();
            this.buttonArtikalObrisi = new System.Windows.Forms.Button();
            this.buttonArtikalIzmeni = new System.Windows.Forms.Button();
            this.buttonArtikalDodaj = new System.Windows.Forms.Button();
            this.textArtikal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowStat = new System.Windows.Forms.FlowLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(21, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1195, 730);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listKategorije);
            this.tabPage1.Controls.Add(this.buttonKategorijaObrisi);
            this.tabPage1.Controls.Add(this.buttonKategorijaIzmeni);
            this.tabPage1.Controls.Add(this.buttonKategorijaDodaj);
            this.tabPage1.Controls.Add(this.textKategorija);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage1.Size = new System.Drawing.Size(1187, 687);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arzuriranje kategorija";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listKategorije
            // 
            this.listKategorije.FormattingEnabled = true;
            this.listKategorije.ItemHeight = 30;
            this.listKategorije.Location = new System.Drawing.Point(677, 32);
            this.listKategorije.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listKategorije.Name = "listKategorije";
            this.listKategorije.Size = new System.Drawing.Size(419, 574);
            this.listKategorije.TabIndex = 10;
            this.listKategorije.SelectedIndexChanged += new System.EventHandler(this.listKategorije_SelectedIndexChanged);
            // 
            // buttonKategorijaObrisi
            // 
            this.buttonKategorijaObrisi.Enabled = false;
            this.buttonKategorijaObrisi.Location = new System.Drawing.Point(67, 342);
            this.buttonKategorijaObrisi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonKategorijaObrisi.Name = "buttonKategorijaObrisi";
            this.buttonKategorijaObrisi.Size = new System.Drawing.Size(305, 46);
            this.buttonKategorijaObrisi.TabIndex = 9;
            this.buttonKategorijaObrisi.Text = "Obrisi kategoriju";
            this.buttonKategorijaObrisi.UseVisualStyleBackColor = true;
            this.buttonKategorijaObrisi.Click += new System.EventHandler(this.buttonKategorijaObrisi_Click);
            // 
            // buttonKategorijaIzmeni
            // 
            this.buttonKategorijaIzmeni.Enabled = false;
            this.buttonKategorijaIzmeni.Location = new System.Drawing.Point(67, 284);
            this.buttonKategorijaIzmeni.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonKategorijaIzmeni.Name = "buttonKategorijaIzmeni";
            this.buttonKategorijaIzmeni.Size = new System.Drawing.Size(305, 46);
            this.buttonKategorijaIzmeni.TabIndex = 8;
            this.buttonKategorijaIzmeni.Text = "Izmeni kategoriju";
            this.buttonKategorijaIzmeni.UseVisualStyleBackColor = true;
            this.buttonKategorijaIzmeni.Click += new System.EventHandler(this.buttonKategorijaIzmeni_Click);
            // 
            // buttonKategorijaDodaj
            // 
            this.buttonKategorijaDodaj.Location = new System.Drawing.Point(67, 208);
            this.buttonKategorijaDodaj.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonKategorijaDodaj.Name = "buttonKategorijaDodaj";
            this.buttonKategorijaDodaj.Size = new System.Drawing.Size(305, 46);
            this.buttonKategorijaDodaj.TabIndex = 7;
            this.buttonKategorijaDodaj.Text = "Dodaj kategoriju";
            this.buttonKategorijaDodaj.UseVisualStyleBackColor = true;
            this.buttonKategorijaDodaj.Click += new System.EventHandler(this.buttonKategorijaDodaj_Click);
            // 
            // textKategorija
            // 
            this.textKategorija.Location = new System.Drawing.Point(67, 148);
            this.textKategorija.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textKategorija.Name = "textKategorija";
            this.textKategorija.Size = new System.Drawing.Size(302, 35);
            this.textKategorija.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naziv kategorije";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.comboKategorija);
            this.tabPage2.Controls.Add(this.textArtikalMera);
            this.tabPage2.Controls.Add(this.labelArtikalMera);
            this.tabPage2.Controls.Add(this.textArtikalCena);
            this.tabPage2.Controls.Add(this.labelArtikalCena);
            this.tabPage2.Controls.Add(this.listArtikli);
            this.tabPage2.Controls.Add(this.buttonArtikalObrisi);
            this.tabPage2.Controls.Add(this.buttonArtikalIzmeni);
            this.tabPage2.Controls.Add(this.buttonArtikalDodaj);
            this.tabPage2.Controls.Add(this.textArtikal);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage2.Size = new System.Drawing.Size(1187, 687);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Arzurainje artikala";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kategorija";
            // 
            // comboKategorija
            // 
            this.comboKategorija.FormattingEnabled = true;
            this.comboKategorija.Location = new System.Drawing.Point(41, 84);
            this.comboKategorija.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboKategorija.Name = "comboKategorija";
            this.comboKategorija.Size = new System.Drawing.Size(302, 38);
            this.comboKategorija.TabIndex = 21;
            // 
            // textArtikalMera
            // 
            this.textArtikalMera.Location = new System.Drawing.Point(41, 364);
            this.textArtikalMera.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textArtikalMera.Name = "textArtikalMera";
            this.textArtikalMera.Size = new System.Drawing.Size(302, 35);
            this.textArtikalMera.TabIndex = 20;
            // 
            // labelArtikalMera
            // 
            this.labelArtikalMera.AutoSize = true;
            this.labelArtikalMera.Location = new System.Drawing.Point(41, 328);
            this.labelArtikalMera.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelArtikalMera.Name = "labelArtikalMera";
            this.labelArtikalMera.Size = new System.Drawing.Size(202, 30);
            this.labelArtikalMera.TabIndex = 19;
            this.labelArtikalMera.Text = "Jedinica mere artikla";
            // 
            // textArtikalCena
            // 
            this.textArtikalCena.Location = new System.Drawing.Point(41, 264);
            this.textArtikalCena.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textArtikalCena.Name = "textArtikalCena";
            this.textArtikalCena.Size = new System.Drawing.Size(302, 35);
            this.textArtikalCena.TabIndex = 18;
            // 
            // labelArtikalCena
            // 
            this.labelArtikalCena.AutoSize = true;
            this.labelArtikalCena.Location = new System.Drawing.Point(41, 228);
            this.labelArtikalCena.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelArtikalCena.Name = "labelArtikalCena";
            this.labelArtikalCena.Size = new System.Drawing.Size(122, 30);
            this.labelArtikalCena.TabIndex = 17;
            this.labelArtikalCena.Text = "Cena artikla";
            // 
            // listArtikli
            // 
            this.listArtikli.FormattingEnabled = true;
            this.listArtikli.ItemHeight = 30;
            this.listArtikli.Location = new System.Drawing.Point(499, 48);
            this.listArtikli.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listArtikli.Name = "listArtikli";
            this.listArtikli.Size = new System.Drawing.Size(604, 574);
            this.listArtikli.TabIndex = 16;
            this.listArtikli.SelectedIndexChanged += new System.EventHandler(this.listArtikli_SelectedIndexChanged);
            // 
            // buttonArtikalObrisi
            // 
            this.buttonArtikalObrisi.Enabled = false;
            this.buttonArtikalObrisi.Location = new System.Drawing.Point(41, 578);
            this.buttonArtikalObrisi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonArtikalObrisi.Name = "buttonArtikalObrisi";
            this.buttonArtikalObrisi.Size = new System.Drawing.Size(305, 46);
            this.buttonArtikalObrisi.TabIndex = 15;
            this.buttonArtikalObrisi.Text = "Obrisi artikal";
            this.buttonArtikalObrisi.UseVisualStyleBackColor = true;
            this.buttonArtikalObrisi.Click += new System.EventHandler(this.buttonArtikalObrisi_Click);
            // 
            // buttonArtikalIzmeni
            // 
            this.buttonArtikalIzmeni.Enabled = false;
            this.buttonArtikalIzmeni.Location = new System.Drawing.Point(41, 520);
            this.buttonArtikalIzmeni.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonArtikalIzmeni.Name = "buttonArtikalIzmeni";
            this.buttonArtikalIzmeni.Size = new System.Drawing.Size(305, 46);
            this.buttonArtikalIzmeni.TabIndex = 14;
            this.buttonArtikalIzmeni.Text = "Izmeni artikal";
            this.buttonArtikalIzmeni.UseVisualStyleBackColor = true;
            this.buttonArtikalIzmeni.Click += new System.EventHandler(this.buttonArtikalIzmeni_Click);
            // 
            // buttonArtikalDodaj
            // 
            this.buttonArtikalDodaj.Location = new System.Drawing.Point(41, 444);
            this.buttonArtikalDodaj.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonArtikalDodaj.Name = "buttonArtikalDodaj";
            this.buttonArtikalDodaj.Size = new System.Drawing.Size(305, 46);
            this.buttonArtikalDodaj.TabIndex = 13;
            this.buttonArtikalDodaj.Text = "Dodaj artikal";
            this.buttonArtikalDodaj.UseVisualStyleBackColor = true;
            this.buttonArtikalDodaj.Click += new System.EventHandler(this.buttonArtikalDodaj_Click);
            // 
            // textArtikal
            // 
            this.textArtikal.Location = new System.Drawing.Point(41, 172);
            this.textArtikal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textArtikal.Name = "textArtikal";
            this.textArtikal.Size = new System.Drawing.Size(302, 35);
            this.textArtikal.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Naziv artikla";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.flowStat);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage3.Size = new System.Drawing.Size(1187, 687);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pregled statistike";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowStat
            // 
            this.flowStat.Location = new System.Drawing.Point(58, 128);
            this.flowStat.Name = "flowStat";
            this.flowStat.Size = new System.Drawing.Size(1016, 508);
            this.flowStat.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(381, 46);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(340, 35);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(799, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 778);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormAdmin";
            this.Text = "Administracija";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonKategorijaObrisi;
        private System.Windows.Forms.Button buttonKategorijaIzmeni;
        private System.Windows.Forms.Button buttonKategorijaDodaj;
        private System.Windows.Forms.TextBox textKategorija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listKategorije;
        private System.Windows.Forms.ListBox listArtikli;
        private System.Windows.Forms.Button buttonArtikalObrisi;
        private System.Windows.Forms.Button buttonArtikalIzmeni;
        private System.Windows.Forms.Button buttonArtikalDodaj;
        private System.Windows.Forms.TextBox textArtikal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textArtikalCena;
        private System.Windows.Forms.Label labelArtikalCena;
        private System.Windows.Forms.TextBox textArtikalMera;
        private System.Windows.Forms.Label labelArtikalMera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboKategorija;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel flowStat;
        private System.Windows.Forms.Label label4;
    }
}

