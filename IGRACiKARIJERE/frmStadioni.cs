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
    public partial class frmStadioni : Form
    {
        KonekcijaNaBazu knb = null;
        List<Stadioni> tempStadioni = null;
        List<ZauzetiStadioni> zauzetiStadioni = null;
        public frmStadioni(KonekcijaNaBazu knbb, ref List<Stadioni> Prikazani, ref List<ZauzetiStadioni> zauzetiStad)
        {
            InitializeComponent();
            knb = knbb;
            dgv_Stadioni.AutoGenerateColumns = false;
            tempStadioni = Prikazani;
            zauzetiStadioni = zauzetiStad;
            UcitajPodatke();
        }

        private void UcitajPodatke(List<Stadioni> Prikazati = null)
        {
            var rezultat = Prikazati ?? tempStadioni.ToList();

            dgv_Stadioni.DataSource = null;
            dgv_Stadioni.DataSource = rezultat;

            lbl_UkupnoPrikazanih.Text = $"Ukupno prikazanih: {rezultat.Count()}";
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Pretraga_TextChanged(object sender, EventArgs e)
        {
            string filter = txt_Pretraga.Text.ToLower().Trim();

            var rezultat = string.IsNullOrWhiteSpace(filter) ? tempStadioni :
                knb.Stadioni.Where(s => s.Naziv.ToLower().Contains(filter)).ToList();

            UcitajPodatke(rezultat);
        }

        private void btn_DodajStadion_Click(object sender, EventArgs e)
        {
            Hide();
            frm_DodajStadion frm = new frm_DodajStadion(knb, ref tempStadioni);
            frm.ShowDialog();
            UcitajPodatke();
            Show();
        }

        private void dgv_Stadioni_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Stadioni kliknutiStadion = dgv_Stadioni.SelectedRows[0].DataBoundItem as Stadioni;
                    if (kliknutiStadion != null)
                    {
                        Hide();
                        frm_DodajStadion frm = new frm_DodajStadion(kliknutiStadion, knb, ref tempStadioni);
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

        private void btn_ZauzetiStadioni_Click(object sender, EventArgs e)
        {
            Hide();
            frmZauzetiStadioni frm = new frmZauzetiStadioni(knb, ref zauzetiStadioni);
            frm.ShowDialog();
            Show();
        }

        private void btn_Printaj_Click(object sender, EventArgs e)
        {
            Hide();
            frmPrikazIzvjestajaListeStadiona frm = new frmPrikazIzvjestajaListeStadiona(ref tempStadioni);
            frm.ShowDialog();
            Show();
        }
    }
}
