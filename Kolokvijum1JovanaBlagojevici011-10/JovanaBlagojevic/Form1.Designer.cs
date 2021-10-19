
namespace JovanaBlagojevic
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.textGodina = new System.Windows.Forms.TextBox();
            this.textZanorvi = new System.Windows.Forms.TextBox();
            this.textOcene = new System.Windows.Forms.TextBox();
            this.textFajl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUbaci = new System.Windows.Forms.Button();
            this.buttonUpisi = new System.Windows.Forms.Button();
            this.buttonUcitaj = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Godina izdanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lista Zanrova";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lista ocena";
            // 
            // textNaziv
            // 
            this.textNaziv.Location = new System.Drawing.Point(225, 86);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(610, 35);
            this.textNaziv.TabIndex = 5;
            // 
            // textAutor
            // 
            this.textAutor.Location = new System.Drawing.Point(225, 138);
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(610, 35);
            this.textAutor.TabIndex = 6;
            this.textAutor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textGodina
            // 
            this.textGodina.Location = new System.Drawing.Point(225, 194);
            this.textGodina.Name = "textGodina";
            this.textGodina.Size = new System.Drawing.Size(610, 35);
            this.textGodina.TabIndex = 7;
            // 
            // textZanorvi
            // 
            this.textZanorvi.Location = new System.Drawing.Point(225, 253);
            this.textZanorvi.Name = "textZanorvi";
            this.textZanorvi.Size = new System.Drawing.Size(610, 35);
            this.textZanorvi.TabIndex = 8;
            // 
            // textOcene
            // 
            this.textOcene.Location = new System.Drawing.Point(225, 308);
            this.textOcene.Name = "textOcene";
            this.textOcene.Size = new System.Drawing.Size(610, 35);
            this.textOcene.TabIndex = 9;
            // 
            // textFajl
            // 
            this.textFajl.Location = new System.Drawing.Point(225, 410);
            this.textFajl.Name = "textFajl";
            this.textFajl.Size = new System.Drawing.Size(610, 35);
            this.textFajl.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Naziv fajla";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonUbaci
            // 
            this.buttonUbaci.Location = new System.Drawing.Point(225, 364);
            this.buttonUbaci.Name = "buttonUbaci";
            this.buttonUbaci.Size = new System.Drawing.Size(610, 40);
            this.buttonUbaci.TabIndex = 12;
            this.buttonUbaci.Text = "Ubaci u listu";
            this.buttonUbaci.UseVisualStyleBackColor = true;
            this.buttonUbaci.Click += new System.EventHandler(this.buttonUbaci_Click);
            // 
            // buttonUpisi
            // 
            this.buttonUpisi.Location = new System.Drawing.Point(225, 465);
            this.buttonUpisi.Name = "buttonUpisi";
            this.buttonUpisi.Size = new System.Drawing.Size(610, 40);
            this.buttonUpisi.TabIndex = 13;
            this.buttonUpisi.Text = "Upisi u fajl";
            this.buttonUpisi.UseVisualStyleBackColor = true;
            this.buttonUpisi.Click += new System.EventHandler(this.buttonUpisi_Click);
            // 
            // buttonUcitaj
            // 
            this.buttonUcitaj.Location = new System.Drawing.Point(47, 562);
            this.buttonUcitaj.Name = "buttonUcitaj";
            this.buttonUcitaj.Size = new System.Drawing.Size(788, 40);
            this.buttonUcitaj.TabIndex = 14;
            this.buttonUcitaj.Text = "Ucitaj iz fajla";
            this.buttonUcitaj.UseVisualStyleBackColor = true;
            this.buttonUcitaj.Click += new System.EventHandler(this.buttonUcitaj_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(47, 621);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(788, 214);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 845);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonUcitaj);
            this.Controls.Add(this.buttonUpisi);
            this.Controls.Add(this.buttonUbaci);
            this.Controls.Add(this.textFajl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textOcene);
            this.Controls.Add(this.textZanorvi);
            this.Controls.Add(this.textGodina);
            this.Controls.Add(this.textAutor);
            this.Controls.Add(this.textNaziv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNaziv;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.TextBox textGodina;
        private System.Windows.Forms.TextBox textZanorvi;
        private System.Windows.Forms.TextBox textOcene;
        private System.Windows.Forms.TextBox textFajl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonUbaci;
        private System.Windows.Forms.Button buttonUpisi;
        private System.Windows.Forms.Button buttonUcitaj;
        private System.Windows.Forms.ListBox listBox1;
    }
}

