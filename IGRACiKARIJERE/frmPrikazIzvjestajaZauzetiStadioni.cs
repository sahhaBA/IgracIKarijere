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
    public partial class frmPrikazIzvjestajaZauzetiStadioni : Form
    {
        List<ZauzetiStadioni> ZauzetiStadioni = null;
        public frmPrikazIzvjestajaZauzetiStadioni(ref List<ZauzetiStadioni> ZauzStad)
        {
            InitializeComponent();
            ZauzetiStadioni = ZauzStad;
        }

        private void frmPrikazIzvjestajaZauzetiStadioni_Load(object sender, EventArgs e)
        {
            int i = 0;
            DSZeuzetiStadioni.TabelaZauzetihStadionaDataTable tbl = new DSZeuzetiStadioni.TabelaZauzetihStadionaDataTable();
            foreach (var zs in ZauzetiStadioni)
            {
                DSZeuzetiStadioni.TabelaZauzetihStadionaRow red = tbl.NewTabelaZauzetihStadionaRow();
                red.Rb = ++i;
                red.Stadion = zs.Stadion.Naziv;
                red.Klub = zs.Klub.Naziv;
                tbl.AddTabelaZauzetihStadionaRow(red);
            }

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DSTabelaZS";
            rds.Value = tbl;

            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
