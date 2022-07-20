namespace IGRACiKARIJERE
{
    partial class frmIgraciKluboviKarijera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIgraciKluboviKarijera));
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.dgv_IgraciKlubovi = new System.Windows.Forms.DataGridView();
            this.Klub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Golovi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trofeji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_Klubovi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Golovi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Trofeji = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Dodaj = new System.Windows.Forms.Button();
            this.chck_UcitajNeunesene = new System.Windows.Forms.CheckBox();
            this.btn_Printaj = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_UkupnoGolova = new System.Windows.Forms.Label();
            this.lbl_UkupnoTrofeja = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IgraciKlubovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.BackColor = System.Drawing.Color.Transparent;
            this.btn_Nazad.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.H6BuNaY;
            this.btn_Nazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nazad.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Nazad.Location = new System.Drawing.Point(13, 407);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(193, 32);
            this.btn_Nazad.TabIndex = 23;
            this.btn_Nazad.Text = "NAZAD";
            this.btn_Nazad.UseVisualStyleBackColor = false;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // dgv_IgraciKlubovi
            // 
            this.dgv_IgraciKlubovi.AllowUserToAddRows = false;
            this.dgv_IgraciKlubovi.AllowUserToDeleteRows = false;
            this.dgv_IgraciKlubovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IgraciKlubovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Klub,
            this.Golovi,
            this.Trofeji});
            this.dgv_IgraciKlubovi.Location = new System.Drawing.Point(219, 9);
            this.dgv_IgraciKlubovi.Name = "dgv_IgraciKlubovi";
            this.dgv_IgraciKlubovi.ReadOnly = true;
            this.dgv_IgraciKlubovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_IgraciKlubovi.Size = new System.Drawing.Size(569, 391);
            this.dgv_IgraciKlubovi.TabIndex = 24;
            this.dgv_IgraciKlubovi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_IgraciKlubovi_CellMouseClick);
            // 
            // Klub
            // 
            this.Klub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Klub.DataPropertyName = "Klub";
            this.Klub.HeaderText = "Klub";
            this.Klub.Name = "Klub";
            this.Klub.ReadOnly = true;
            // 
            // Golovi
            // 
            this.Golovi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Golovi.DataPropertyName = "Golovi";
            this.Golovi.HeaderText = "Broj golova";
            this.Golovi.Name = "Golovi";
            this.Golovi.ReadOnly = true;
            // 
            // Trofeji
            // 
            this.Trofeji.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Trofeji.DataPropertyName = "Trofeji";
            this.Trofeji.HeaderText = "Broj trofeja";
            this.Trofeji.Name = "Trofeji";
            this.Trofeji.ReadOnly = true;
            // 
            // cmb_Klubovi
            // 
            this.cmb_Klubovi.FormattingEnabled = true;
            this.cmb_Klubovi.Location = new System.Drawing.Point(14, 28);
            this.cmb_Klubovi.Name = "cmb_Klubovi";
            this.cmb_Klubovi.Size = new System.Drawing.Size(192, 21);
            this.cmb_Klubovi.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "KLUBOVI";
            // 
            // txt_Golovi
            // 
            this.txt_Golovi.Location = new System.Drawing.Point(14, 71);
            this.txt_Golovi.Multiline = true;
            this.txt_Golovi.Name = "txt_Golovi";
            this.txt_Golovi.Size = new System.Drawing.Size(192, 21);
            this.txt_Golovi.TabIndex = 27;
            this.txt_Golovi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "GOLOVI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "TROFEJI";
            // 
            // txt_Trofeji
            // 
            this.txt_Trofeji.Location = new System.Drawing.Point(14, 114);
            this.txt_Trofeji.Multiline = true;
            this.txt_Trofeji.Name = "txt_Trofeji";
            this.txt_Trofeji.Size = new System.Drawing.Size(192, 21);
            this.txt_Trofeji.TabIndex = 29;
            this.txt_Trofeji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IGRACiKARIJERE.Properties.Resources.trofej;
            this.pictureBox1.Location = new System.Drawing.Point(14, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Dodaj
            // 
            this.btn_Dodaj.BackColor = System.Drawing.Color.Transparent;
            this.btn_Dodaj.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.H6BuNaY;
            this.btn_Dodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dodaj.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Dodaj.Location = new System.Drawing.Point(13, 141);
            this.btn_Dodaj.Name = "btn_Dodaj";
            this.btn_Dodaj.Size = new System.Drawing.Size(193, 32);
            this.btn_Dodaj.TabIndex = 32;
            this.btn_Dodaj.Text = "DODAJ";
            this.btn_Dodaj.UseVisualStyleBackColor = false;
            this.btn_Dodaj.Click += new System.EventHandler(this.btn_Dodaj_Click);
            // 
            // chck_UcitajNeunesene
            // 
            this.chck_UcitajNeunesene.AutoSize = true;
            this.chck_UcitajNeunesene.BackColor = System.Drawing.Color.Transparent;
            this.chck_UcitajNeunesene.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chck_UcitajNeunesene.ForeColor = System.Drawing.Color.White;
            this.chck_UcitajNeunesene.Location = new System.Drawing.Point(91, 8);
            this.chck_UcitajNeunesene.Name = "chck_UcitajNeunesene";
            this.chck_UcitajNeunesene.Size = new System.Drawing.Size(115, 20);
            this.chck_UcitajNeunesene.TabIndex = 33;
            this.chck_UcitajNeunesene.Text = "Učitaj neunesene";
            this.chck_UcitajNeunesene.UseVisualStyleBackColor = false;
            this.chck_UcitajNeunesene.CheckedChanged += new System.EventHandler(this.chck_UcitajNeunesene_CheckedChanged);
            // 
            // btn_Printaj
            // 
            this.btn_Printaj.BackColor = System.Drawing.Color.Transparent;
            this.btn_Printaj.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.H6BuNaY;
            this.btn_Printaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Printaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Printaj.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Printaj.Location = new System.Drawing.Point(732, 406);
            this.btn_Printaj.Name = "btn_Printaj";
            this.btn_Printaj.Size = new System.Drawing.Size(56, 32);
            this.btn_Printaj.TabIndex = 34;
            this.btn_Printaj.Text = "prnt";
            this.btn_Printaj.UseVisualStyleBackColor = false;
            this.btn_Printaj.Click += new System.EventHandler(this.btn_Printaj_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // lbl_UkupnoGolova
            // 
            this.lbl_UkupnoGolova.AutoSize = true;
            this.lbl_UkupnoGolova.BackColor = System.Drawing.Color.Brown;
            this.lbl_UkupnoGolova.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UkupnoGolova.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_UkupnoGolova.Location = new System.Drawing.Point(219, 403);
            this.lbl_UkupnoGolova.Name = "lbl_UkupnoGolova";
            this.lbl_UkupnoGolova.Size = new System.Drawing.Size(118, 19);
            this.lbl_UkupnoGolova.TabIndex = 35;
            this.lbl_UkupnoGolova.Text = "Ukupno golova: 0";
            // 
            // lbl_UkupnoTrofeja
            // 
            this.lbl_UkupnoTrofeja.AutoSize = true;
            this.lbl_UkupnoTrofeja.BackColor = System.Drawing.Color.Brown;
            this.lbl_UkupnoTrofeja.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UkupnoTrofeja.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_UkupnoTrofeja.Location = new System.Drawing.Point(219, 422);
            this.lbl_UkupnoTrofeja.Name = "lbl_UkupnoTrofeja";
            this.lbl_UkupnoTrofeja.Size = new System.Drawing.Size(125, 19);
            this.lbl_UkupnoTrofeja.TabIndex = 36;
            this.lbl_UkupnoTrofeja.Text = "Ukupno trofeja: 0";
            // 
            // frmIgraciKluboviKarijera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.H6BuNaY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_UkupnoTrofeja);
            this.Controls.Add(this.lbl_UkupnoGolova);
            this.Controls.Add(this.btn_Printaj);
            this.Controls.Add(this.chck_UcitajNeunesene);
            this.Controls.Add(this.btn_Dodaj);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Trofeji);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Golovi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Klubovi);
            this.Controls.Add(this.dgv_IgraciKlubovi);
            this.Controls.Add(this.btn_Nazad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIgraciKluboviKarijera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KARIJERA";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IgraciKlubovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nazad;
        private System.Windows.Forms.DataGridView dgv_IgraciKlubovi;
        private System.Windows.Forms.ComboBox cmb_Klubovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Golovi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Trofeji;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Golovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trofeji;
        private System.Windows.Forms.Button btn_Dodaj;
        private System.Windows.Forms.CheckBox chck_UcitajNeunesene;
        private System.Windows.Forms.Button btn_Printaj;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Label lbl_UkupnoTrofeja;
        private System.Windows.Forms.Label lbl_UkupnoGolova;
    }
}