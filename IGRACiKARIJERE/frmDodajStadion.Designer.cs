namespace IGRACiKARIJERE
{
    partial class frm_DodajStadion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DodajStadion));
            this.btn_Spasi = new System.Windows.Forms.Button();
            this.btn_Izlaz = new System.Windows.Forms.Button();
            this.txt_Naziv = new System.Windows.Forms.TextBox();
            this.txt_Kapacitet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Spasi
            // 
            this.btn_Spasi.BackColor = System.Drawing.Color.Transparent;
            this.btn_Spasi.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.Klubovi;
            this.btn_Spasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Spasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Spasi.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Spasi.Location = new System.Drawing.Point(580, 406);
            this.btn_Spasi.Name = "btn_Spasi";
            this.btn_Spasi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Spasi.Size = new System.Drawing.Size(208, 32);
            this.btn_Spasi.TabIndex = 8;
            this.btn_Spasi.Text = "SPASI STADION";
            this.btn_Spasi.UseVisualStyleBackColor = false;
            this.btn_Spasi.Click += new System.EventHandler(this.btn_Spasi_Click);
            // 
            // btn_Izlaz
            // 
            this.btn_Izlaz.BackColor = System.Drawing.Color.Transparent;
            this.btn_Izlaz.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.Klubovi;
            this.btn_Izlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Izlaz.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Izlaz.Location = new System.Drawing.Point(12, 406);
            this.btn_Izlaz.Name = "btn_Izlaz";
            this.btn_Izlaz.Size = new System.Drawing.Size(127, 32);
            this.btn_Izlaz.TabIndex = 7;
            this.btn_Izlaz.Text = "NAZAD";
            this.btn_Izlaz.UseVisualStyleBackColor = false;
            this.btn_Izlaz.Click += new System.EventHandler(this.btn_Izlaz_Click);
            // 
            // txt_Naziv
            // 
            this.txt_Naziv.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Naziv.Location = new System.Drawing.Point(47, 345);
            this.txt_Naziv.Name = "txt_Naziv";
            this.txt_Naziv.Size = new System.Drawing.Size(129, 23);
            this.txt_Naziv.TabIndex = 9;
            // 
            // txt_Kapacitet
            // 
            this.txt_Kapacitet.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Kapacitet.Location = new System.Drawing.Point(630, 56);
            this.txt_Kapacitet.Name = "txt_Kapacitet";
            this.txt_Kapacitet.Size = new System.Drawing.Size(129, 23);
            this.txt_Kapacitet.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "NAZIV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(684, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "KAPACITET";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frm_DodajStadion
            // 
            this.AcceptButton = this.btn_Spasi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.rona;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Kapacitet);
            this.Controls.Add(this.txt_Naziv);
            this.Controls.Add(this.btn_Spasi);
            this.Controls.Add(this.btn_Izlaz);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DodajStadion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DODAVANJE STADIONA";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Spasi;
        private System.Windows.Forms.Button btn_Izlaz;
        private System.Windows.Forms.TextBox txt_Naziv;
        private System.Windows.Forms.TextBox txt_Kapacitet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider err;
    }
}