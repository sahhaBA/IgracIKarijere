namespace IGRACiKARIJERE
{
    partial class frmZauzetiStadioni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZauzetiStadioni));
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.dgv_ZauzetiStadioni = new System.Windows.Forms.DataGridView();
            this.Stadion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_UkupnoPrikazanih = new System.Windows.Forms.Label();
            this.txt_Pretraga = new System.Windows.Forms.TextBox();
            this.btn_Printaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ZauzetiStadioni)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.BackColor = System.Drawing.Color.Transparent;
            this.btn_Nazad.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.Cristiano_Ronaldo_Wallpaper_5;
            this.btn_Nazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nazad.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Nazad.Location = new System.Drawing.Point(12, 406);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(127, 32);
            this.btn_Nazad.TabIndex = 7;
            this.btn_Nazad.Text = "NAZAD";
            this.btn_Nazad.UseVisualStyleBackColor = false;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // dgv_ZauzetiStadioni
            // 
            this.dgv_ZauzetiStadioni.AllowUserToAddRows = false;
            this.dgv_ZauzetiStadioni.AllowUserToDeleteRows = false;
            this.dgv_ZauzetiStadioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ZauzetiStadioni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stadion,
            this.Klub});
            this.dgv_ZauzetiStadioni.Location = new System.Drawing.Point(12, 81);
            this.dgv_ZauzetiStadioni.Name = "dgv_ZauzetiStadioni";
            this.dgv_ZauzetiStadioni.ReadOnly = true;
            this.dgv_ZauzetiStadioni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ZauzetiStadioni.Size = new System.Drawing.Size(776, 319);
            this.dgv_ZauzetiStadioni.TabIndex = 8;
            // 
            // Stadion
            // 
            this.Stadion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stadion.DataPropertyName = "Stadion";
            this.Stadion.HeaderText = "Stadion";
            this.Stadion.Name = "Stadion";
            this.Stadion.ReadOnly = true;
            // 
            // Klub
            // 
            this.Klub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Klub.DataPropertyName = "Klub";
            this.Klub.HeaderText = "Klub";
            this.Klub.Name = "Klub";
            this.Klub.ReadOnly = true;
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
            this.txt_Pretraga.Location = new System.Drawing.Point(12, 28);
            this.txt_Pretraga.Name = "txt_Pretraga";
            this.txt_Pretraga.Size = new System.Drawing.Size(776, 23);
            this.txt_Pretraga.TabIndex = 24;
            this.txt_Pretraga.TextChanged += new System.EventHandler(this.txt_Pretraga_TextChanged);
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
            this.btn_Printaj.TabIndex = 37;
            this.btn_Printaj.Text = "prnt";
            this.btn_Printaj.UseVisualStyleBackColor = false;
            this.btn_Printaj.Click += new System.EventHandler(this.btn_Printaj_Click);
            // 
            // frmZauzetiStadioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.Cristiano_Ronaldo_Wallpaper_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Printaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_UkupnoPrikazanih);
            this.Controls.Add(this.txt_Pretraga);
            this.Controls.Add(this.dgv_ZauzetiStadioni);
            this.Controls.Add(this.btn_Nazad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmZauzetiStadioni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STADIONI - KLUBOVI";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ZauzetiStadioni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nazad;
        private System.Windows.Forms.DataGridView dgv_ZauzetiStadioni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_UkupnoPrikazanih;
        private System.Windows.Forms.TextBox txt_Pretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stadion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klub;
        private System.Windows.Forms.Button btn_Printaj;
    }
}