﻿namespace IGRACiKARIJERE
{
    partial class frm_PotvrdiSifru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PotvrdiSifru));
            this.txt_Sifra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_SlikaLock = new System.Windows.Forms.PictureBox();
            this.btn_Potvrdi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SlikaLock)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Sifra
            // 
            this.txt_Sifra.BackColor = System.Drawing.Color.Gold;
            this.txt_Sifra.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sifra.Location = new System.Drawing.Point(199, 45);
            this.txt_Sifra.Multiline = true;
            this.txt_Sifra.Name = "txt_Sifra";
            this.txt_Sifra.Size = new System.Drawing.Size(150, 25);
            this.txt_Sifra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(196, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "POTVRDI ŠIFRU IGRAČA";
            // 
            // pb_SlikaLock
            // 
            this.pb_SlikaLock.BackColor = System.Drawing.Color.Gold;
            this.pb_SlikaLock.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.pass;
            this.pb_SlikaLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_SlikaLock.Location = new System.Drawing.Point(12, 12);
            this.pb_SlikaLock.Name = "pb_SlikaLock";
            this.pb_SlikaLock.Size = new System.Drawing.Size(145, 111);
            this.pb_SlikaLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_SlikaLock.TabIndex = 2;
            this.pb_SlikaLock.TabStop = false;
            // 
            // btn_Potvrdi
            // 
            this.btn_Potvrdi.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_Potvrdi.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.Klubovi;
            this.btn_Potvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Potvrdi.ForeColor = System.Drawing.Color.White;
            this.btn_Potvrdi.Location = new System.Drawing.Point(199, 76);
            this.btn_Potvrdi.Name = "btn_Potvrdi";
            this.btn_Potvrdi.Size = new System.Drawing.Size(150, 29);
            this.btn_Potvrdi.TabIndex = 1;
            this.btn_Potvrdi.Text = "POTVRDI";
            this.btn_Potvrdi.UseVisualStyleBackColor = false;
            this.btn_Potvrdi.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(169, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 128);
            this.label2.TabIndex = 4;
            // 
            // frm_PotvrdiSifru
            // 
            this.AcceptButton = this.btn_Potvrdi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IGRACiKARIJERE.Properties.Resources.MesiGo;
            this.ClientSize = new System.Drawing.Size(361, 138);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Potvrdi);
            this.Controls.Add(this.pb_SlikaLock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Sifra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PotvrdiSifru";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LOZINKA";
            ((System.ComponentModel.ISupportInitialize)(this.pb_SlikaLock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Sifra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_SlikaLock;
        private System.Windows.Forms.Button btn_Potvrdi;
        private System.Windows.Forms.Label label2;
    }
}