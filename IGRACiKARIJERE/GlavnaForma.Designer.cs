namespace IGRACiKARIJERE
{
    partial class GlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Izlaz = new System.Windows.Forms.Button();
            this.btn_Igraci = new System.Windows.Forms.Button();
            this.btn_Klubovi = new System.Windows.Forms.Button();
            this.btn_Stadioni = new System.Windows.Forms.Button();
            this.WinMedPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WinMedPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(626, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "© 2020 sahha All Rights Reserved";
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
            this.btn_Izlaz.TabIndex = 1;
            this.btn_Izlaz.Text = "IZLAZ";
            this.btn_Izlaz.UseVisualStyleBackColor = false;
            this.btn_Izlaz.Click += new System.EventHandler(this.btn_Izlaz_Click);
            // 
            // btn_Igraci
            // 
            this.btn_Igraci.BackColor = System.Drawing.Color.Transparent;
            this.btn_Igraci.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.Klubovi;
            this.btn_Igraci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Igraci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Igraci.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Igraci.Location = new System.Drawing.Point(607, 12);
            this.btn_Igraci.Name = "btn_Igraci";
            this.btn_Igraci.Size = new System.Drawing.Size(181, 32);
            this.btn_Igraci.TabIndex = 2;
            this.btn_Igraci.Text = "IGRAČI";
            this.btn_Igraci.UseVisualStyleBackColor = false;
            this.btn_Igraci.Click += new System.EventHandler(this.btn_Igraci_Click);
            // 
            // btn_Klubovi
            // 
            this.btn_Klubovi.BackColor = System.Drawing.Color.Transparent;
            this.btn_Klubovi.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.Klubovi;
            this.btn_Klubovi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Klubovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Klubovi.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Klubovi.Location = new System.Drawing.Point(607, 50);
            this.btn_Klubovi.Name = "btn_Klubovi";
            this.btn_Klubovi.Size = new System.Drawing.Size(181, 32);
            this.btn_Klubovi.TabIndex = 3;
            this.btn_Klubovi.Text = "KLUBOVI";
            this.btn_Klubovi.UseVisualStyleBackColor = false;
            this.btn_Klubovi.Click += new System.EventHandler(this.btn_Klubovi_Click);
            // 
            // btn_Stadioni
            // 
            this.btn_Stadioni.BackColor = System.Drawing.Color.Transparent;
            this.btn_Stadioni.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.Klubovi;
            this.btn_Stadioni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stadioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stadioni.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Stadioni.Location = new System.Drawing.Point(607, 88);
            this.btn_Stadioni.Name = "btn_Stadioni";
            this.btn_Stadioni.Size = new System.Drawing.Size(181, 32);
            this.btn_Stadioni.TabIndex = 4;
            this.btn_Stadioni.Text = "STADIONI";
            this.btn_Stadioni.UseVisualStyleBackColor = false;
            this.btn_Stadioni.Click += new System.EventHandler(this.btn_Stadioni_Click);
            // 
            // WinMedPlayer
            // 
            this.WinMedPlayer.Enabled = true;
            this.WinMedPlayer.Location = new System.Drawing.Point(545, 418);
            this.WinMedPlayer.Name = "WinMedPlayer";
            this.WinMedPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WinMedPlayer.OcxState")));
            this.WinMedPlayer.Size = new System.Drawing.Size(75, 23);
            this.WinMedPlayer.TabIndex = 5;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.GlMeni;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WinMedPlayer);
            this.Controls.Add(this.btn_Stadioni);
            this.Controls.Add(this.btn_Klubovi);
            this.Controls.Add(this.btn_Igraci);
            this.Controls.Add(this.btn_Izlaz);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlavnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GLAVNI MENI";
            ((System.ComponentModel.ISupportInitialize)(this.WinMedPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Izlaz;
        private System.Windows.Forms.Button btn_Igraci;
        private System.Windows.Forms.Button btn_Klubovi;
        private System.Windows.Forms.Button btn_Stadioni;
        private AxWMPLib.AxWindowsMediaPlayer WinMedPlayer;
    }
}

