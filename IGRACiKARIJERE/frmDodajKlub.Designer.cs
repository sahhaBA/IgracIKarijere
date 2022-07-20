namespace IGRACiKARIJERE
{
    partial class frmDodajKlub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajKlub));
            this.btn_Spasi = new System.Windows.Forms.Button();
            this.btn_Izlaz = new System.Windows.Forms.Button();
            this.cmb_GodinaOsnivanja = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Stadioni = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IME = new System.Windows.Forms.Label();
            this.txt_Lokacija = new System.Windows.Forms.TextBox();
            this.txt_Naziv = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.chck_UcitajSve = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Spasi
            // 
            this.btn_Spasi.BackColor = System.Drawing.Color.Transparent;
            this.btn_Spasi.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.Stadioni;
            this.btn_Spasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Spasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Spasi.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Spasi.Location = new System.Drawing.Point(580, 406);
            this.btn_Spasi.Name = "btn_Spasi";
            this.btn_Spasi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Spasi.Size = new System.Drawing.Size(208, 32);
            this.btn_Spasi.TabIndex = 10;
            this.btn_Spasi.Text = "SPASI KLUB";
            this.btn_Spasi.UseVisualStyleBackColor = false;
            this.btn_Spasi.Click += new System.EventHandler(this.btn_Spasi_Click);
            // 
            // btn_Izlaz
            // 
            this.btn_Izlaz.BackColor = System.Drawing.Color.Transparent;
            this.btn_Izlaz.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.Stadioni;
            this.btn_Izlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Izlaz.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Izlaz.Location = new System.Drawing.Point(12, 406);
            this.btn_Izlaz.Name = "btn_Izlaz";
            this.btn_Izlaz.Size = new System.Drawing.Size(127, 32);
            this.btn_Izlaz.TabIndex = 9;
            this.btn_Izlaz.Text = "NAZAD";
            this.btn_Izlaz.UseVisualStyleBackColor = false;
            this.btn_Izlaz.Click += new System.EventHandler(this.btn_Izlaz_Click);
            // 
            // cmb_GodinaOsnivanja
            // 
            this.cmb_GodinaOsnivanja.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_GodinaOsnivanja.FormattingEnabled = true;
            this.cmb_GodinaOsnivanja.Location = new System.Drawing.Point(619, 52);
            this.cmb_GodinaOsnivanja.Name = "cmb_GodinaOsnivanja";
            this.cmb_GodinaOsnivanja.Size = new System.Drawing.Size(145, 24);
            this.cmb_GodinaOsnivanja.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(616, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "GODINA OSNIVANJA";
            // 
            // cmb_Stadioni
            // 
            this.cmb_Stadioni.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stadioni.FormattingEnabled = true;
            this.cmb_Stadioni.Location = new System.Drawing.Point(619, 109);
            this.cmb_Stadioni.Name = "cmb_Stadioni";
            this.cmb_Stadioni.Size = new System.Drawing.Size(145, 24);
            this.cmb_Stadioni.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(616, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "STADION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(35, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "LOKACIJA";
            // 
            // IME
            // 
            this.IME.AutoSize = true;
            this.IME.BackColor = System.Drawing.Color.Transparent;
            this.IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IME.ForeColor = System.Drawing.SystemColors.Control;
            this.IME.Location = new System.Drawing.Point(35, 36);
            this.IME.Name = "IME";
            this.IME.Size = new System.Drawing.Size(44, 13);
            this.IME.TabIndex = 19;
            this.IME.Text = "NAZIV";
            // 
            // txt_Lokacija
            // 
            this.txt_Lokacija.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lokacija.Location = new System.Drawing.Point(38, 109);
            this.txt_Lokacija.Name = "txt_Lokacija";
            this.txt_Lokacija.Size = new System.Drawing.Size(145, 23);
            this.txt_Lokacija.TabIndex = 18;
            // 
            // txt_Naziv
            // 
            this.txt_Naziv.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Naziv.Location = new System.Drawing.Point(38, 52);
            this.txt_Naziv.Name = "txt_Naziv";
            this.txt_Naziv.Size = new System.Drawing.Size(145, 23);
            this.txt_Naziv.TabIndex = 17;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // chck_UcitajSve
            // 
            this.chck_UcitajSve.AutoSize = true;
            this.chck_UcitajSve.BackColor = System.Drawing.Color.Transparent;
            this.chck_UcitajSve.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chck_UcitajSve.ForeColor = System.Drawing.Color.White;
            this.chck_UcitajSve.Location = new System.Drawing.Point(619, 139);
            this.chck_UcitajSve.Name = "chck_UcitajSve";
            this.chck_UcitajSve.Size = new System.Drawing.Size(78, 20);
            this.chck_UcitajSve.TabIndex = 25;
            this.chck_UcitajSve.Text = "Učitaj sve";
            this.chck_UcitajSve.UseVisualStyleBackColor = false;
            this.chck_UcitajSve.CheckedChanged += new System.EventHandler(this.chck_UcitajSve_CheckedChanged);
            // 
            // frmDodajKlub
            // 
            this.AcceptButton = this.btn_Spasi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.Stadioni;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chck_UcitajSve);
            this.Controls.Add(this.cmb_GodinaOsnivanja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Stadioni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IME);
            this.Controls.Add(this.txt_Lokacija);
            this.Controls.Add(this.txt_Naziv);
            this.Controls.Add(this.btn_Spasi);
            this.Controls.Add(this.btn_Izlaz);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDodajKlub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DODAVANJE KLUBA";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Spasi;
        private System.Windows.Forms.Button btn_Izlaz;
        private System.Windows.Forms.ComboBox cmb_GodinaOsnivanja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Stadioni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IME;
        private System.Windows.Forms.TextBox txt_Lokacija;
        private System.Windows.Forms.TextBox txt_Naziv;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.CheckBox chck_UcitajSve;
    }
}