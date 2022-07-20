namespace IGRACiKARIJERE
{
    partial class frmIgraci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIgraci));
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_UkupnoPrikazanih = new System.Windows.Forms.Label();
            this.txt_Pretraga = new System.Windows.Forms.TextBox();
            this.dgv_Igraci = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godiste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pozicija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Karijera = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.btn_DodajIgraca = new System.Windows.Forms.Button();
            this.cmb_Filter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ProsjekGolova = new System.Windows.Forms.Label();
            this.btn_Printaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Igraci)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Pretraga";
            // 
            // lbl_UkupnoPrikazanih
            // 
            this.lbl_UkupnoPrikazanih.AutoSize = true;
            this.lbl_UkupnoPrikazanih.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UkupnoPrikazanih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UkupnoPrikazanih.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_UkupnoPrikazanih.Location = new System.Drawing.Point(12, 62);
            this.lbl_UkupnoPrikazanih.Name = "lbl_UkupnoPrikazanih";
            this.lbl_UkupnoPrikazanih.Size = new System.Drawing.Size(152, 16);
            this.lbl_UkupnoPrikazanih.TabIndex = 25;
            this.lbl_UkupnoPrikazanih.Text = "Ukupno prikazanih: 0";
            // 
            // txt_Pretraga
            // 
            this.txt_Pretraga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pretraga.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pretraga.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Pretraga.Location = new System.Drawing.Point(13, 28);
            this.txt_Pretraga.Name = "txt_Pretraga";
            this.txt_Pretraga.Size = new System.Drawing.Size(775, 23);
            this.txt_Pretraga.TabIndex = 24;
            this.txt_Pretraga.TextChanged += new System.EventHandler(this.txt_Pretraga_TextChanged);
            // 
            // dgv_Igraci
            // 
            this.dgv_Igraci.AllowUserToAddRows = false;
            this.dgv_Igraci.AllowUserToDeleteRows = false;
            this.dgv_Igraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Igraci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Spol,
            this.Godiste,
            this.Nacionalnost,
            this.Pozicija,
            this.Aktivan,
            this.Karijera});
            this.dgv_Igraci.Location = new System.Drawing.Point(12, 81);
            this.dgv_Igraci.Name = "dgv_Igraci";
            this.dgv_Igraci.ReadOnly = true;
            this.dgv_Igraci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Igraci.Size = new System.Drawing.Size(776, 319);
            this.dgv_Igraci.TabIndex = 23;
            this.dgv_Igraci.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Igraci_CellMouseClick);
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            // 
            // Godiste
            // 
            this.Godiste.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Godiste.DataPropertyName = "Godiste";
            this.Godiste.HeaderText = "Godište";
            this.Godiste.Name = "Godiste";
            this.Godiste.ReadOnly = true;
            // 
            // Nacionalnost
            // 
            this.Nacionalnost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nacionalnost.DataPropertyName = "Nacionalnost";
            this.Nacionalnost.HeaderText = "Nacionalnost";
            this.Nacionalnost.Name = "Nacionalnost";
            this.Nacionalnost.ReadOnly = true;
            // 
            // Pozicija
            // 
            this.Pozicija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pozicija.DataPropertyName = "Pozicija";
            this.Pozicija.HeaderText = "Pozicija";
            this.Pozicija.Name = "Pozicija";
            this.Pozicija.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            // 
            // Karijera
            // 
            this.Karijera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Karijera.HeaderText = "Karijera";
            this.Karijera.Name = "Karijera";
            this.Karijera.ReadOnly = true;
            this.Karijera.Text = "Karijera";
            this.Karijera.UseColumnTextForButtonValue = true;
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.BackColor = System.Drawing.Color.Transparent;
            this.btn_Nazad.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.MesiGo;
            this.btn_Nazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nazad.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Nazad.Location = new System.Drawing.Point(12, 406);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(127, 32);
            this.btn_Nazad.TabIndex = 22;
            this.btn_Nazad.Text = "NAZAD";
            this.btn_Nazad.UseVisualStyleBackColor = false;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Izlaz_Click);
            // 
            // btn_DodajIgraca
            // 
            this.btn_DodajIgraca.BackColor = System.Drawing.Color.Transparent;
            this.btn_DodajIgraca.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.MesiGo;
            this.btn_DodajIgraca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DodajIgraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DodajIgraca.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_DodajIgraca.Location = new System.Drawing.Point(580, 406);
            this.btn_DodajIgraca.Name = "btn_DodajIgraca";
            this.btn_DodajIgraca.Size = new System.Drawing.Size(208, 32);
            this.btn_DodajIgraca.TabIndex = 21;
            this.btn_DodajIgraca.Text = "DODAJ IGRAČA";
            this.btn_DodajIgraca.UseVisualStyleBackColor = false;
            this.btn_DodajIgraca.Click += new System.EventHandler(this.btn_DodajIgraca_Click);
            // 
            // cmb_Filter
            // 
            this.cmb_Filter.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Filter.FormattingEnabled = true;
            this.cmb_Filter.Location = new System.Drawing.Point(687, 54);
            this.cmb_Filter.Name = "cmb_Filter";
            this.cmb_Filter.Size = new System.Drawing.Size(101, 24);
            this.cmb_Filter.TabIndex = 27;
            this.cmb_Filter.SelectedIndexChanged += new System.EventHandler(this.cmb_Filter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(633, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "FILTER";
            // 
            // lbl_ProsjekGolova
            // 
            this.lbl_ProsjekGolova.AutoSize = true;
            this.lbl_ProsjekGolova.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ProsjekGolova.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProsjekGolova.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ProsjekGolova.Location = new System.Drawing.Point(145, 406);
            this.lbl_ProsjekGolova.Name = "lbl_ProsjekGolova";
            this.lbl_ProsjekGolova.Size = new System.Drawing.Size(232, 19);
            this.lbl_ProsjekGolova.TabIndex = 29;
            this.lbl_ProsjekGolova.Text = "Prosjek golova prikazanih igrača: 0";
            // 
            // btn_Printaj
            // 
            this.btn_Printaj.BackColor = System.Drawing.Color.Transparent;
            this.btn_Printaj.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.H6BuNaY;
            this.btn_Printaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Printaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Printaj.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Printaj.Location = new System.Drawing.Point(518, 406);
            this.btn_Printaj.Name = "btn_Printaj";
            this.btn_Printaj.Size = new System.Drawing.Size(56, 32);
            this.btn_Printaj.TabIndex = 35;
            this.btn_Printaj.Text = "prnt";
            this.btn_Printaj.UseVisualStyleBackColor = false;
            this.btn_Printaj.Click += new System.EventHandler(this.btn_Printaj_Click);
            // 
            // frmIgraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.MesiGo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Printaj);
            this.Controls.Add(this.lbl_ProsjekGolova);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Filter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_UkupnoPrikazanih);
            this.Controls.Add(this.txt_Pretraga);
            this.Controls.Add(this.dgv_Igraci);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.btn_DodajIgraca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIgraci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IGRAČI";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Igraci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_UkupnoPrikazanih;
        private System.Windows.Forms.TextBox txt_Pretraga;
        private System.Windows.Forms.DataGridView dgv_Igraci;
        private System.Windows.Forms.Button btn_Nazad;
        private System.Windows.Forms.Button btn_DodajIgraca;
        private System.Windows.Forms.ComboBox cmb_Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godiste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pozicija;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewButtonColumn Karijera;
        private System.Windows.Forms.Label lbl_ProsjekGolova;
        private System.Windows.Forms.Button btn_Printaj;
    }
}