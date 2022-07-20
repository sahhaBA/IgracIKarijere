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
    public partial class frmZauzetiStadioni : Form
    {
        KonekcijaNaBazu knb = null;
        List<ZauzetiStadioni> ZauzetiStadioni = null;
        public frmZauzetiStadioni(KonekcijaNaBazu knbb, ref List<ZauzetiStadioni> zauzStadi)
        {
            InitializeComponent();
            dgv_ZauzetiStadioni.AutoGenerateColumns = false;
            knb = knbb;
            ZauzetiStadioni = zauzStadi;
            UcitajPodatke();
        }

        private void UcitajPodatke(List<ZauzetiStadioni> Prikazati = null)
        {
            var rezultat = Prikazati ?? ZauzetiStadioni;

            dgv_ZauzetiStadioni.DataSource = null;
            dgv_ZauzetiStadioni.DataSource = rezultat;

            lbl_UkupnoPrikazanih.Text = $"Ukupno prikazanih: {rezultat.Count()}";
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Pretraga_TextChanged(object sender, EventArgs e)
        {
            string filter = txt_Pretraga.Text.ToLower().Trim();

            var rezultat = string.IsNullOrWhiteSpace(filter) ? ZauzetiStadioni :
                ZauzetiStadioni.Where(zs => zs.Stadion.Naziv.ToLower().Contains(filter)).ToList();

            UcitajPodatke(rezultat);
        }

        private void btn_Printaj_Click(object sender, EventArgs e)
        {
            Hide();
            frmPrikazIzvjestajaZauzetiStadioni frm = new frmPrikazIzvjestajaZauzetiStadioni(ref ZauzetiStadioni);
            frm.ShowDialog();
            Show();
        }
    }
}
