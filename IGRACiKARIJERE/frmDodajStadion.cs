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
    public partial class frm_DodajStadion : Form
    {
        KonekcijaNaBazu knb = null;
        string poruka { get; set; } = "OBAVEZNO POLJE!";
        bool Edit { get; set; } = false;
        Stadioni st { get; set; }
        List<Stadioni> tempStadioni = null;
        public frm_DodajStadion(KonekcijaNaBazu knbb, ref List<Stadioni> Prikazati)
        {
            InitializeComponent();
            knb = knbb;
            st = new Stadioni();
            tempStadioni = Prikazati;
        }
        public frm_DodajStadion(Stadioni kliknutiStadion, KonekcijaNaBazu konekcija, ref List<Stadioni> tempSt) : this(konekcija, ref tempSt)
        {
            st = kliknutiStadion;
            Edit = true;
            UcitajPodatkeKliknutog();
        }

        private void UcitajPodatkeKliknutog()
        {
            txt_Naziv.Text = st.Naziv;
            txt_Kapacitet.Text = st.Kapacitet.ToString();
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
                    if (txt_Naziv.Text.ToLower() != st?.Naziv?.ToLower())
                        DaLiVecPostoji(txt_Naziv);

                    st.Naziv = txt_Naziv.Text;
                    st.Kapacitet = int.Parse(txt_Kapacitet.Text);

                    if (!Edit)
                    {
                        knb.Stadioni.Add(st);
                        tempStadioni.Add(st);
                        MessageBox.Show($"Stadion {st.Naziv} uspješno dodan!", "Uspješno dodavanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        knb.Entry(st).State = EntityState.Modified;
                        MessageBox.Show($"Stadion {st.Naziv} uspješno editovan!", "Uspješno editovanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DaLiVecPostoji(TextBox txt_Naziv)
        {
            if (tempStadioni.Where(s => s.Naziv.ToLower() == txt_Naziv.Text.ToLower()).Count() > 0)
                throw new Exception($"Stadion {txt_Naziv.Text} je već evidentiran!");
        }

        private bool Validiraj()
        {
            return ObaveznoPolje(txt_Naziv) && ObaveznoPolje(txt_Kapacitet);
        }

        private bool ObaveznoPolje(TextBox obj)
        {
            int parsedValue = 0;
            if (string.IsNullOrWhiteSpace(obj.Text))
            {
                err.SetError(obj, poruka);
                return false;
            }
            if (obj == txt_Kapacitet && (!int.TryParse(txt_Kapacitet.Text, out parsedValue) || parsedValue <= 0)){
                err.SetError(obj, "Kapacitet mora biti pozitivan broj!");
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
