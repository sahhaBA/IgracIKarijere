using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGRACiKARIJERE
{
    public partial class frmDodajIgraca : Form
    {
        KonekcijaNaBazu knb = null;
        string Poruka { get; } = "OBAVEZAN UNOS!";
        Igraci Igrac { get; set; }
        bool Edit { get; set; } = false;
        List<Igraci> tempIgraci = null;
        List<Spolovi> tempSpolovi = null;
        List<Pozicije> tempPozicije = null;
        public frmDodajIgraca(KonekcijaNaBazu knbb, ref List<Igraci> Prikazati, ref List<Spolovi> spl, ref List<Pozicije> pzc)
        {
            InitializeComponent();
            knb = knbb;
            Igrac = new Igraci();
            tempIgraci = Prikazati;
            tempSpolovi = spl;
            tempPozicije = pzc;
            UcitajPodatke();
            SifraOko();
            cmb_Godiste.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Pozicija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Spolovi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SifraOko()
        {
            if (txt_Sifra.Text == "")
                pb_Oko.Visible = false;
            else
                pb_Oko.Visible = true;
        }

        public frmDodajIgraca(Igraci kliknutiIgrac, KonekcijaNaBazu konekcija, ref List<Igraci> tempIg, ref List<Spolovi> spolovi, ref List<Pozicije> pozicije) : this(konekcija, ref tempIg, ref spolovi, ref pozicije)
        {
            Igrac = kliknutiIgrac;
            Edit = true;
            UcitajPodatkeOKliknutomIgracu();
        }

        private void UcitajPodatkeOKliknutomIgracu()
        {
            txt_Ime.Text = Igrac.Ime;
            txt_Prezime.Text = Igrac.Prezime;
            txt_Nacionalnost.Text = Igrac.Nacionalnost;
            txt_Sifra.Text = Igrac.Sifra;
            chck_Aktivan.Checked = Igrac.Aktivan;
            cmb_Godiste.SelectedItem = Igrac.Godiste;
            cmb_Pozicija.SelectedItem = Igrac.Pozicija;
            cmb_Spolovi.SelectedItem = Igrac.Spol;
            pb_Slika.Image = ImageHelper.FromByteToImage(Igrac.Slika);
        }

        private void UcitajPodatke()
        {
            cmb_Spolovi.DataSource = tempSpolovi;
            cmb_Spolovi.DisplayMember = "Naziv";
            cmb_Spolovi.ValueMember = "Id";

            List<int> tempGod = new List<int>();
            for(int i = 0; i <= 120; i++)
            {
                tempGod.Add(1900 + i);
            }
            cmb_Godiste.DataSource = tempGod;

            cmb_Pozicija.DataSource = tempPozicije;
            cmb_Pozicija.DisplayMember = "Naziv";
            cmb_Pozicija.ValueMember = "Id";
        }

        private void btn_Izlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Spasi_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validiraj())
                {
                    if (txt_Ime.Text.ToLower() != Igrac?.Ime?.ToLower() && txt_Prezime.Text.ToLower() != Igrac?.Prezime?.ToLower() && DaLiVecPostoji() && MessageBox.Show($"Igrač {txt_Ime.Text} {txt_Prezime.Text} je vec evidentiran. Želite li ponovo da ga spasite u bazu?", "Igrač postoji", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }

                    Igrac.Ime = txt_Ime.Text;
                    Igrac.Prezime = txt_Prezime.Text;
                    Igrac.Spol = cmb_Spolovi.SelectedItem as Spolovi;
                    Igrac.Godiste = int.Parse(cmb_Godiste.SelectedItem.ToString());
                    Igrac.Nacionalnost = txt_Nacionalnost.Text.ToUpper();
                    Igrac.Pozicija = cmb_Pozicija.SelectedItem as Pozicije;
                    Igrac.Sifra = txt_Sifra.Text;
                    Igrac.Aktivan = chck_Aktivan.Checked;
                    Igrac.Slika = ImageHelper.FromImageToByte(pb_Slika.Image);

                    if (!Edit)
                    {
                        knb.Igraci.Add(Igrac);
                        tempIgraci.Add(Igrac);
                        MessageBox.Show($"Igrač {Igrac} uspješno dodan!", "Uspješno dodavanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        knb.Entry(Igrac).State = EntityState.Modified;
                        MessageBox.Show($"Igrač {Igrac} uspješno editovan!", "Uspješno editovanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    knb.SaveChanges();
                    Close();
                }
            }
            catch(Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private bool Validiraj()
        {
            return ObaveznoPolje(txt_Ime) && ObaveznoPolje(txt_Prezime) && ObaveznoPolje(txt_Nacionalnost) && ObaveznoPolje(txt_Sifra)
                && ObaveznoPolje(pb_Slika);
        }

        private bool DaLiVecPostoji()
        {
            if(tempIgraci.Where(i => i.Ime.ToLower() == txt_Ime.Text.ToLower() && i.Prezime.ToLower() == txt_Prezime.Text.ToLower()).Count()>0)
            {
                return true;
            }
            return false;
        }

        private bool ObaveznoPolje(object obj)
        {
            if (txt_Sifra.TextLength > 15)
                return false;
            if(obj is TextBox && string.IsNullOrWhiteSpace((obj as TextBox).Text))
            {
                err.SetError(obj as TextBox, Poruka);
                return false;
            }
            else if(obj is PictureBox && (obj as PictureBox).Image == null)
            {
                err.SetError(obj as PictureBox, Poruka);
                return false;
            }
            err.Clear();
            return true;
        }

        private void btn_UcitajSliku_Click(object sender, EventArgs e)
        {
            if (ofd_UcitajSliku.ShowDialog() == DialogResult.OK)
            {
                Image slika = Image.FromFile(ofd_UcitajSliku.FileName);
                pb_Slika.Image = slika;
            }
        }

        private void pb_Oko_Click(object sender, EventArgs e)
        {
            if (txt_Sifra.PasswordChar == '*')
                txt_Sifra.PasswordChar = '\0';
            else
                txt_Sifra.PasswordChar = '*';
        }

        private void txt_Sifra_TextChanged(object sender, EventArgs e)
        {
            if (txt_Sifra.TextLength > 15)
                err.SetError(txt_Sifra, "Max. 15 znakova!");
            else
                err.Clear();
            SifraOko();
        }
    }
}
