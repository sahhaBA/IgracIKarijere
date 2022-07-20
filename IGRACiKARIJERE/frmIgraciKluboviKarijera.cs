using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGRACiKARIJERE
{
    public partial class frmIgraciKluboviKarijera : Form
    {
        KonekcijaNaBazu knb = null;
        List<Klubovi> tempKlubovi = null;
        List<IgraciKlubovi> tempIgraciKlubovi = null;
        Igraci kliknutiIgrac = null;
        public frmIgraciKluboviKarijera(KonekcijaNaBazu knbb, Igraci klIgr, ref List<Klubovi> klubovi, ref List<IgraciKlubovi> IgKl)
        {
            InitializeComponent();
            dgv_IgraciKlubovi.AutoGenerateColumns = false;
            knb = knbb;
            tempKlubovi = klubovi;
            tempIgraciKlubovi = IgKl;
            kliknutiIgrac = klIgr;
            cmb_Klubovi.DropDownStyle = ComboBoxStyle.DropDownList;
            Text = $"KARIJERA - {kliknutiIgrac}";
            UcitajIgraceKlubove();
        }

        private void UcitajIgraceKlubove()
        {
           
            dgv_IgraciKlubovi.DataSource = null;
            dgv_IgraciKlubovi.DataSource = kliknutiIgrac.Karijera.ToList();

            lbl_UkupnoGolova.Text = $"Ukupno golova: {kliknutiIgrac.Karijera.Sum(g => g.Golovi).ToString()}";
            lbl_UkupnoTrofeja.Text = $"Ukupno trofeja: {kliknutiIgrac.Karijera.Sum(t => t.Trofeji).ToString()}";

            UcitajKlubove();
        }

        private void UcitajKlubove()
        {
            var query = (from k in tempKlubovi.AsEnumerable()
                        where !(from ek in kliknutiIgrac.Karijera
                               select ek.Klub.Id).Contains(k.Id)
                        select k).ToList();

            cmb_Klubovi.DataSource = !chck_UcitajNeunesene.Checked ? tempKlubovi : query;
            cmb_Klubovi.DisplayMember = "Naziv";
            cmb_Klubovi.ValueMember = "Id";
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validiraj())
                {
                    DaLiVecPostoji(cmb_Klubovi);

                    IgraciKlubovi novi = new IgraciKlubovi();

                    novi.Klub = cmb_Klubovi.SelectedItem as Klubovi;
                    novi.Golovi = int.Parse(txt_Golovi.Text);
                    novi.Trofeji = int.Parse(txt_Trofeji.Text);

                    kliknutiIgrac.Karijera.Add(novi);
                    tempIgraciKlubovi.Add(novi);
                    knb.SaveChanges();

                    Ponisti();
                    UcitajIgraceKlubove();
                }
            }
            catch(Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void Ponisti()
        {
            txt_Golovi.Text = "";
            txt_Trofeji.Text = "";
        }

        private void DaLiVecPostoji(ComboBox cmb_Klubovi)
        {
            if (kliknutiIgrac.Karijera.Where(k => k.Klub == cmb_Klubovi.SelectedItem as Klubovi).Count() > 0)
                throw new Exception($"Klub {cmb_Klubovi.Text} je već evidentiran za igrača {kliknutiIgrac}");
        }

        private bool Validiraj()
        {
            return ObavezanUnos(txt_Golovi) && ObavezanUnos(txt_Trofeji) && ObavezanUnos(cmb_Klubovi);
        }

        private bool ObavezanUnos(object obj)
        {
            int parsedValue = 0;
            if(obj is TextBox && (string.IsNullOrWhiteSpace((obj as TextBox).Text) || !int.TryParse((obj as TextBox).Text, out parsedValue) || parsedValue < 0))
            {
                err.SetError(obj as TextBox, "OBAVEZNO POLJE!");
                return false;
            }
            else if(obj is ComboBox && (obj as ComboBox).SelectedIndex == -1)
            {
                err.SetError(obj as ComboBox, "Polje je prazno, dodajte novi klub!");
                return false;
            }
            err.Clear();
            return true;
        }

        private void chck_UcitajNeunesene_CheckedChanged(object sender, EventArgs e)
        {
            UcitajKlubove();
        }

        private void btn_Printaj_Click(object sender, EventArgs e)
        {
            Hide();
            frmPrikazIzvjestaja frm = new frmPrikazIzvjestaja(ref tempIgraciKlubovi, kliknutiIgrac);
            frm.ShowDialog();
            Show();
        }

        private void dgv_IgraciKlubovi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    IgraciKlubovi kliknutiIgracKlub = dgv_IgraciKlubovi.SelectedRows[0].DataBoundItem as IgraciKlubovi;
                    if (kliknutiIgracKlub != null)
                    {
                        frmModifikacijaIgracaKluba frm = new frmModifikacijaIgracaKluba(knb, ref tempKlubovi, kliknutiIgracKlub, kliknutiIgrac);
                        frm.ShowDialog();
                        Ponisti();
                        UcitajIgraceKlubove();
                    }
                }
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }
    }
}
