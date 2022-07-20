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
    public partial class frmKlubovi : Form
    {
        KonekcijaNaBazu knb = null;
        List<Klubovi> tempKlubovi = null;
        List<ZauzetiStadioni> zauzetiStadioni = null;
        List<Stadioni> tempStadioni = null;
        public frmKlubovi(KonekcijaNaBazu knbb, ref List<Klubovi> Prikazani, ref List<ZauzetiStadioni> zauzetiSt, ref List<Stadioni> tempSt)
        {
            InitializeComponent();
            knb = knbb;
            dgv_Klubovi.AutoGenerateColumns = false;
            tempKlubovi = Prikazani;
            zauzetiStadioni = zauzetiSt;
            tempStadioni = tempSt;
            UcitajPodatke();
        }

        private void UcitajPodatke(List<Klubovi> Prikazati = null)
        {
            var rezultat = Prikazati ?? tempKlubovi.ToList();

            dgv_Klubovi.DataSource = null;
            dgv_Klubovi.DataSource = rezultat;

            lbl_UkupnoPrikazanih.Text = $"Ukupno prikazanih: {rezultat.Count()}";
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Pretraga_TextChanged(object sender, EventArgs e)
        {
            string filter = txt_Pretraga.Text.ToLower().Trim();

            var rezultat = string.IsNullOrWhiteSpace(filter) ? tempKlubovi :
                knb.Klubovi.Where(k => k.Naziv.ToLower().Contains(filter)).ToList();

            UcitajPodatke(rezultat);
        }

        private void btn_DodajKlub_Click(object sender, EventArgs e)
        {
            Hide();
            frmDodajKlub frm = new frmDodajKlub(knb, ref tempKlubovi, ref zauzetiStadioni, ref tempStadioni);
            frm.ShowDialog();
            UcitajPodatke();
            Show();
        }

        private void dgv_Klubovi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Klubovi kliknutiKlub = dgv_Klubovi.SelectedRows[0].DataBoundItem as Klubovi;
                    if (kliknutiKlub != null)
                    {
                        Hide();
                        frmDodajKlub frm = new frmDodajKlub(kliknutiKlub, knb, ref tempKlubovi, ref zauzetiStadioni, ref tempStadioni);
                        frm.ShowDialog();
                        Show();
                    }
                }
            }
            catch(Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void btn_Printaj_Click(object sender, EventArgs e)
        {
            Hide();
            frmPrikazIzvjestajaKlubovi frm = new frmPrikazIzvjestajaKlubovi(ref tempKlubovi);
            frm.ShowDialog();
            Show();
        }
    }
}
