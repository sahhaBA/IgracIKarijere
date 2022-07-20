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
    public partial class frmPrikazIzvjestajaListeStadiona : Form
    {
        List<Stadioni> Stadioni = null;
        public frmPrikazIzvjestajaListeStadiona(ref List<Stadioni> tempStadioni)
        {
            InitializeComponent();
            Stadioni = tempStadioni;
        }

        private void frmPrikazIzvjestajaListeStadiona_Load(object sender, EventArgs e)
        {
            int i = 0;
            List<object> list = new List<object>();

            foreach(var s in Stadioni)
            {
                list.Add(new
                {
                    Rb = ++i,
                    Naziv = s.Naziv,
                    Kapacitet = s.Kapacitet.ToString()
                });
            }

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DSTabelaStadiona";
            rds.Value = list;

            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
