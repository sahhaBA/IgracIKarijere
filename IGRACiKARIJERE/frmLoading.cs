using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGRACiKARIJERE
{
    public partial class frmLoading : Form
    {
        KonekcijaNaBazu knb = null;
        List<Igraci> igraciAsync = null;
        List<Klubovi> kluboviAsync = null;
        List<Stadioni> stadioniAsync = null;
        List<ZauzetiStadioni> zauzetiStadioniAsync = null;
        List<IgraciKlubovi> igraciKluboviAsync = null;
        List<Spolovi> spoloviAsync = null;
        List<Pozicije> pozicijeAsync = null;
        public frmLoading()
        {
            InitializeComponent();
            knb = KonekcijaNaBazu._knb;

            var ucitavanje = Task.Run(() => {
                igraciAsync = knb.Igraci.ToList();
                kluboviAsync = knb.Klubovi.ToList();
                stadioniAsync = knb.Stadioni.ToList();
                zauzetiStadioniAsync = knb.ZauzetiStadioni.ToList();
                igraciKluboviAsync = knb.IgraciKlubovi.ToList();
                spoloviAsync = knb.Spolovi.ToList();
                pozicijeAsync = knb.Pozicije.ToList();
            });

            var cekaj = ucitavanje.GetAwaiter();
            cekaj.OnCompleted(() => {
                Hide();
                GlavnaForma frm = new GlavnaForma(knb, ref igraciAsync, ref kluboviAsync, ref stadioniAsync, ref zauzetiStadioniAsync, ref igraciKluboviAsync, ref spoloviAsync, ref pozicijeAsync);
                frm.ShowDialog();
                Close();
            });
        }
    }
}
