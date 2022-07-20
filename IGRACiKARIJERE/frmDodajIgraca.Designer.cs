namespace IGRACiKARIJERE
{
    partial class frmDodajIgraca
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajIgraca));
            this.btn_Izlaz = new System.Windows.Forms.Button();
            this.btn_Spasi = new System.Windows.Forms.Button();
            this.txt_Ime = new System.Windows.Forms.TextBox();
            this.txt_Prezime = new System.Windows.Forms.TextBox();
            this.txt_Nacionalnost = new System.Windows.Forms.TextBox();
            this.txt_Sifra = new System.Windows.Forms.TextBox();
            this.IME = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Spolovi = new System.Windows.Forms.ComboBox();
            this.cmb_Godiste = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Pozicija = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chck_Aktivan = new System.Windows.Forms.CheckBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.pb_Slika = new System.Windows.Forms.PictureBox();
            this.btn_UcitajSliku = new System.Windows.Forms.Button();
            this.ofd_UcitajSliku = new System.Windows.Forms.OpenFileDialog();
            this.pb_Oko = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Slika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Oko)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Izlaz
            // 
            this.btn_Izlaz.BackColor = System.Drawing.Color.Transparent;
            this.btn_Izlaz.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.MesiGo;
            this.btn_Izlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Izlaz.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Izlaz.Location = new System.Drawing.Point(12, 406);
            this.btn_Izlaz.Name = "btn_Izlaz";
            this.btn_Izlaz.Size = new System.Drawing.Size(127, 32);
            this.btn_Izlaz.TabIndex = 3;
            this.btn_Izlaz.Text = "NAZAD";
            this.btn_Izlaz.UseVisualStyleBackColor = false;
            this.btn_Izlaz.Click += new System.EventHandler(this.btn_Izlaz_Click);
            // 
            // btn_Spasi
            // 
            this.btn_Spasi.BackColor = System.Drawing.Color.Transparent;
            this.btn_Spasi.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.MesiGo;
            this.btn_Spasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Spasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Spasi.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Spasi.Location = new System.Drawing.Point(580, 406);
            this.btn_Spasi.Name = "btn_Spasi";
            this.btn_Spasi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Spasi.Size = new System.Drawing.Size(208, 32);
            this.btn_Spasi.TabIndex = 6;
            this.btn_Spasi.Text = "SPASI IGRAČA";
            this.btn_Spasi.UseVisualStyleBackColor = false;
            this.btn_Spasi.Click += new System.EventHandler(this.btn_Spasi_Click);
            // 
            // txt_Ime
            // 
            this.txt_Ime.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ime.Location = new System.Drawing.Point(631, 59);
            this.txt_Ime.Name = "txt_Ime";
            this.txt_Ime.Size = new System.Drawing.Size(145, 23);
            this.txt_Ime.TabIndex = 7;
            // 
            // txt_Prezime
            // 
            this.txt_Prezime.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Prezime.Location = new System.Drawing.Point(631, 95);
            this.txt_Prezime.Name = "txt_Prezime";
            this.txt_Prezime.Size = new System.Drawing.Size(145, 23);
            this.txt_Prezime.TabIndex = 8;
            // 
            // txt_Nacionalnost
            // 
            this.txt_Nacionalnost.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nacionalnost.Location = new System.Drawing.Point(631, 205);
            this.txt_Nacionalnost.Name = "txt_Nacionalnost";
            this.txt_Nacionalnost.Size = new System.Drawing.Size(145, 23);
            this.txt_Nacionalnost.TabIndex = 10;
            // 
            // txt_Sifra
            // 
            this.txt_Sifra.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sifra.Location = new System.Drawing.Point(631, 278);
            this.txt_Sifra.Name = "txt_Sifra";
            this.txt_Sifra.PasswordChar = '*';
            this.txt_Sifra.Size = new System.Drawing.Size(145, 23);
            this.txt_Sifra.TabIndex = 9;
            this.txt_Sifra.TextChanged += new System.EventHandler(this.txt_Sifra_TextChanged);
            // 
            // IME
            // 
            this.IME.AutoSize = true;
            this.IME.BackColor = System.Drawing.Color.Transparent;
            this.IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IME.ForeColor = System.Drawing.SystemColors.Control;
            this.IME.Location = new System.Drawing.Point(583, 63);
            this.IME.Name = "IME";
            this.IME.Size = new System.Drawing.Size(29, 13);
            this.IME.TabIndex = 11;
            this.IME.Text = "IME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(550, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "PREZIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(573, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "SPOL";
            // 
            // cmb_Spolovi
            // 
            this.cmb_Spolovi.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Spolovi.FormattingEnabled = true;
            this.cmb_Spolovi.Location = new System.Drawing.Point(631, 131);
            this.cmb_Spolovi.Name = "cmb_Spolovi";
            this.cmb_Spolovi.Size = new System.Drawing.Size(145, 24);
            this.cmb_Spolovi.TabIndex = 14;
            // 
            // cmb_Godiste
            // 
            this.cmb_Godiste.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Godiste.FormattingEnabled = true;
            this.cmb_Godiste.Location = new System.Drawing.Point(631, 168);
            this.cmb_Godiste.Name = "cmb_Godiste";
            this.cmb_Godiste.Size = new System.Drawing.Size(145, 24);
            this.cmb_Godiste.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(550, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "GODIŠTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(509, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "NACIONALNOST";
            // 
            // cmb_Pozicija
            // 
            this.cmb_Pozicija.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Pozicija.FormattingEnabled = true;
            this.cmb_Pozicija.Location = new System.Drawing.Point(631, 241);
            this.cmb_Pozicija.Name = "cmb_Pozicija";
            this.cmb_Pozicija.Size = new System.Drawing.Size(145, 24);
            this.cmb_Pozicija.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(550, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "POZICIJA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(569, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "ŠIFRA";
            // 
            // chck_Aktivan
            // 
            this.chck_Aktivan.AutoSize = true;
            this.chck_Aktivan.BackColor = System.Drawing.Color.Transparent;
            this.chck_Aktivan.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chck_Aktivan.ForeColor = System.Drawing.Color.White;
            this.chck_Aktivan.Location = new System.Drawing.Point(631, 314);
            this.chck_Aktivan.Name = "chck_Aktivan";
            this.chck_Aktivan.Size = new System.Drawing.Size(79, 20);
            this.chck_Aktivan.TabIndex = 21;
            this.chck_Aktivan.Text = "AKTIVAN";
            this.chck_Aktivan.UseVisualStyleBackColor = false;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // pb_Slika
            // 
            this.pb_Slika.BackColor = System.Drawing.Color.Transparent;
            this.pb_Slika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Slika.Location = new System.Drawing.Point(24, 59);
            this.pb_Slika.Name = "pb_Slika";
            this.pb_Slika.Size = new System.Drawing.Size(208, 236);
            this.pb_Slika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Slika.TabIndex = 22;
            this.pb_Slika.TabStop = false;
            // 
            // btn_UcitajSliku
            // 
            this.btn_UcitajSliku.BackColor = System.Drawing.Color.Transparent;
            this.btn_UcitajSliku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_UcitajSliku.BackgroundImage")));
            this.btn_UcitajSliku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UcitajSliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UcitajSliku.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_UcitajSliku.Location = new System.Drawing.Point(24, 302);
            this.btn_UcitajSliku.Name = "btn_UcitajSliku";
            this.btn_UcitajSliku.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_UcitajSliku.Size = new System.Drawing.Size(208, 32);
            this.btn_UcitajSliku.TabIndex = 23;
            this.btn_UcitajSliku.Text = "UČITAJ SLIKU";
            this.btn_UcitajSliku.UseVisualStyleBackColor = false;
            this.btn_UcitajSliku.Click += new System.EventHandler(this.btn_UcitajSliku_Click);
            // 
            // ofd_UcitajSliku
            // 
            this.ofd_UcitajSliku.FileName = "openFileDialog1";
            // 
            // pb_Oko
            // 
            this.pb_Oko.BackColor = System.Drawing.SystemColors.Window;
            this.pb_Oko.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Oko.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Oko.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Oko.Image = global::IGRACiKARIJERE.Properties.Resources.eye;
            this.pb_Oko.Location = new System.Drawing.Point(754, 278);
            this.pb_Oko.Name = "pb_Oko";
            this.pb_Oko.Size = new System.Drawing.Size(22, 23);
            this.pb_Oko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Oko.TabIndex = 24;
            this.pb_Oko.TabStop = false;
            this.pb_Oko.Click += new System.EventHandler(this.pb_Oko_Click);
            // 
            // frmDodajIgraca
            // 
            this.AcceptButton = this.btn_Spasi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.MesiGo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_Oko);
            this.Controls.Add(this.btn_UcitajSliku);
            this.Controls.Add(this.pb_Slika);
            this.Controls.Add(this.chck_Aktivan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_Pozicija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Godiste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Spolovi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IME);
            this.Controls.Add(this.txt_Nacionalnost);
            this.Controls.Add(this.txt_Sifra);
            this.Controls.Add(this.txt_Prezime);
            this.Controls.Add(this.txt_Ime);
            this.Controls.Add(this.btn_Spasi);
            this.Controls.Add(this.btn_Izlaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDodajIgraca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DODAVANJE IGRAČA";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Slika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Oko)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Izlaz;
        private System.Windows.Forms.Button btn_Spasi;
        private System.Windows.Forms.TextBox txt_Ime;
        private System.Windows.Forms.TextBox txt_Prezime;
        private System.Windows.Forms.TextBox txt_Nacionalnost;
        private System.Windows.Forms.TextBox txt_Sifra;
        private System.Windows.Forms.Label IME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Spolovi;
        private System.Windows.Forms.ComboBox cmb_Godiste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Pozicija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chck_Aktivan;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btn_UcitajSliku;
        private System.Windows.Forms.PictureBox pb_Slika;
        private System.Windows.Forms.OpenFileDialog ofd_UcitajSliku;
        private System.Windows.Forms.PictureBox pb_Oko;
    }
}