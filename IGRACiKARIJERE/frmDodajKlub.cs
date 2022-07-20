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
    public partial class frmDodajKlub : Form
    {
        KonekcijaNaBazu knb = null;
        Klubovi Klub { get; set; }
        bool Edit { get; set; } = false;
        List<Klubovi> tempKl = null;
        List<ZauzetiStadioni> zauzetiStadioni = null;
        List<Stadioni> tempStadioni = null;
        string poruka { get; set; } = "OBAVEZNO POLJE";
        
        public frmDodajKlub(KonekcijaNaBazu knbb, ref List<Klubovi> Prikazati, ref List<ZauzetiStadioni> zauzetiSt, ref List<Stadioni> tempSt)
        {
            InitializeComponent();
            knb = knbb;
            tempKl = Prikazati;
            zauzetiStadioni = zauzetiSt;
            tempStadioni = tempSt;
            UcitajStadione();
            UcitajGodine();
            Klub = new Klubovi();
            cmb_GodinaOsnivanja.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Stadioni.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public frmDodajKlub(Klubovi kliknutiKlub, KonekcijaNaBazu konekcija, ref List<Klubovi> tempKl, ref List<ZauzetiStadioni> zauzetiSt, ref List<Stadioni> tempSt) : this(konekcija, ref tempKl, ref zauzetiSt, ref tempSt)
        {
            Klub = kliknutiKlub;
            Edit = true;
            UcitajPodatkeKliknutog();
        }

        private void UcitajPodatkeKliknutog()
        {
            txt_Naziv.Text = Klub.Naziv;
            txt_Lokacija.Text = Klub.Lokacija;
            cmb_Stadioni.SelectedItem = Klub.Stadion;
            cmb_GodinaOsnivanja.SelectedItem = Klub.GodinaOsnivanja;
        }

        private void UcitajStadione()
        {
            try
            {
                var query = (from s in tempStadioni.AsEnumerable()
                             where !(from zs in tempKl
                                     select zs.Stadion.Naziv).Contains(s.Naziv)
                             select s).ToList();

                cmb_Stadioni.DataSource = !chck_UcitajSve.Checked ? query : tempStadioni;
                cmb_Stadioni.DisplayMember = "Naziv";
                cmb_Stadioni.ValueMember = "Id";
            }
            catch(Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void UcitajGodine()
        {
            List<int> tempGodine = new List<int>();

            for(int i = 0; i <= 170; i++)
                tempGodine.Add(1850 + i);

            cmb_GodinaOsnivanja.DataSource = tempGodine;
        }

        private void btn_Izlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Spasi_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    if (txt_Naziv.Text.ToLower() != Klub?.Naziv?.ToLower())
                        DaLiKlubVecPostoji(txt_Naziv);
                    if(cmb_Stadioni.SelectedItem != Klub?.Stadion)
                        DaLiJeStadionZauzet(cmb_Stadioni);
                    
                    Klub.Naziv = txt_Naziv.Text;
                    Klub.Lokacija = txt_Lokacija.Text;
                    Klub.GodinaOsnivanja = int.Parse(cmb_GodinaOsnivanja.SelectedItem.ToString());
                    Klub.Stadion = cmb_Stadioni.SelectedItem as Stadioni;

                    if (!Edit)
                    {
                        ZauzetiStadioni zs = new ZauzetiStadioni();
                        zs.Klub = Klub;
                        zs.Stadion = Klub.Stadion;

                        knb.Klubovi.Add(Klub);
                        tempKl.Add(Klub);
                        knb.ZauzetiStadioni.Add(zs);
                        zauzetiStadioni.Add(zs);

                        MessageBox.Show($"Klub {Klub} uspješno dodan!", "Uspješno dodavanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        foreach(var zauzStd in zauzetiStadioni)
                        {
                            if (zauzStd.Klub.Id == Klub.Id) {
                                zauzStd.Stadion = Klub.Stadion;
                            }
                        }
                        knb.Entry(Klub).State = EntityState.Modified;
                        MessageBox.Show($"Klub {Klub} uspješno editovan!", "Uspješno editovanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DaLiKlubVecPostoji(TextBox txt_Naziv)
        {
            if (tempKl.Where(k => k.Naziv.ToLower() == txt_Naziv.Text.ToLower()).Count() > 0)
                throw new Exception($"Klub {txt_Naziv.Text} vec postoji u bazi!");
        }
        private void DaLiJeStadionZauzet(ComboBox cmb_Stadioni)
        {
            if(zauzetiStadioni.Where(zs => zs.Stadion == cmb_Stadioni.SelectedItem as Stadioni && Klub.Stadion != cmb_Stadioni.SelectedItem as Stadioni).Count()>0)
                throw new Exception($"Stadion {cmb_Stadioni.SelectedItem.ToString()} je zauzet!");
        }


        private bool Validacija()
        {
            return ObaveznoPolje(txt_Naziv) && ObaveznoPolje(txt_Lokacija) && ObaveznoPolje(cmb_Stadioni);
        }

        private bool ObaveznoPolje(object obj)
        {
            if (obj is TextBox && string.IsNullOrWhiteSpace((obj as TextBox).Text))
            {
                err.SetError(obj as TextBox, poruka);
                return false;
            }
            else if(obj is ComboBox && (obj as ComboBox).SelectedIndex == -1)
            {
                err.SetError(obj as ComboBox, "Polje je prazno, dodajte novi stadion!");
                return false;
            }
            err.Clear();
            return true;
        }

        private void chck_UcitajSve_CheckedChanged(object sender, EventArgs e)
        {
            UcitajStadione();
        }
    }
}
