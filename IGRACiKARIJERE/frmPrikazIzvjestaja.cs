using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace IGRACiKARIJERE
{
    public partial class frmPrikazIzvjestaja : Form
    {
        List<IgraciKlubovi> tempIgraciKlubovi = null;
        Igraci kliknutiIgrac = null;
        public frmPrikazIzvjestaja(ref List<IgraciKlubovi> IgKl, Igraci kliknutiIgr)
        {
            InitializeComponent();
            tempIgraciKlubovi = IgKl;
            kliknutiIgrac = kliknutiIgr;
        }

        private void frmPrikazIzvjestaja_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Igrac", kliknutiIgrac.ToString()));

            int i = 0;

            DataSet1.PodaciOIgracuDataTable tbl = new DataSet1.PodaciOIgracuDataTable();
            foreach(var k in kliknutiIgrac.Karijera)
            {
                var Golovi = tempIgraciKlubovi.Where(ik => ik.Klub.Id == k.Klub.Id && ik.Igrac.Id == kliknutiIgrac.Id).FirstOrDefault()?.Golovi.ToString();
                var Trofeji = tempIgraciKlubovi.Where(ik => ik.Klub.Id == k.Klub.Id && ik.Igrac.Id == kliknutiIgrac.Id).FirstOrDefault()?.Trofeji.ToString();
                DataSet1.PodaciOIgracuRow red = tbl.NewPodaciOIgracuRow();
                red.Rb = ++i;
                red.Klub = k.Klub.ToString();
                red.Golovi = Golovi == "0" ? "BEZ GOLOVA" : Golovi;
                red.Trofeji = Trofeji == "0" ? "BEZ TROFEJA" : Trofeji;
                tbl.AddPodaciOIgracuRow(red);
            }

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DBTabela";
            rds.Value = tbl;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
