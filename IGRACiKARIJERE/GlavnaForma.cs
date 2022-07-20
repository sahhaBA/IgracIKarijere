using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGRACiKARIJERE
{
    public partial class GlavnaForma : Form
    {
        KonekcijaNaBazu knb = null;
        List<Igraci> igraciAsync = null;
        List<Klubovi> kluboviAsync = null;
        List<Stadioni> stadioniAsync = null;
        List<ZauzetiStadioni> zauzetiStadioniAsync = null;
        List<IgraciKlubovi> IgraciKluboviAsync = null;
        List<Spolovi> spoloviAsync = null;
        List<Pozicije> pozicijeAsync = null;
        public GlavnaForma(KonekcijaNaBazu knbb, ref List<Igraci> igr, ref List<Klubovi> klu, ref List<Stadioni> sta, ref List<ZauzetiStadioni> zau, ref List<IgraciKlubovi> igKl, ref List<Spolovi> spl, ref List<Pozicije> pzc)
        {
            InitializeComponent();
            knb = knbb;
            igraciAsync = igr;
            kluboviAsync = klu;
            stadioniAsync = sta;
            zauzetiStadioniAsync = zau;
            IgraciKluboviAsync = igKl;
            spoloviAsync = spl;
            pozicijeAsync = pzc;
        }
      
        private void btn_Izlaz_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Da li zaista zelite napustiti?","Izlaz",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Igraci_Click(object sender, EventArgs e)
        {
            Hide();
            frmIgraci frm = new frmIgraci(knb, ref igraciAsync, ref kluboviAsync, ref IgraciKluboviAsync, ref spoloviAsync, ref pozicijeAsync);
            frm.ShowDialog();
            Show();
        }

        private void btn_Klubovi_Click(object sender, EventArgs e)
        {
            Hide();
            frmKlubovi frm = new frmKlubovi(knb, ref kluboviAsync, ref zauzetiStadioniAsync, ref stadioniAsync);
            frm.ShowDialog();
            Show();
        }

        public void btn_Stadioni_Click(object sender, EventArgs e)
        {
            Hide();
            frmStadioni frm = new frmStadioni(knb, ref stadioniAsync, ref zauzetiStadioniAsync);
            frm.ShowDialog();
            Show();
        }
    }
}
