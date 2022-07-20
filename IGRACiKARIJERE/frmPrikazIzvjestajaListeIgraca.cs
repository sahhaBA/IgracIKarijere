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
    public partial class frmPrikazIzvjestajaListeIgraca : Form
    {
        List<Igraci> tempIgraci = null;
        public frmPrikazIzvjestajaListeIgraca(ref List<Igraci> poslaniIgraci)
        {
            InitializeComponent();
            tempIgraci = poslaniIgraci;
        }

        private void frmPrikazIzvjestajaListeIgraca_Load(object sender, EventArgs e)
        {
            List<object> list = new List<object>();
            int i = 0;
            foreach (var igrac in tempIgraci)
            {
                list.Add(new
                {
                    Rb = ++i,
                    Ime = igrac.Ime,
                    Prezime = igrac.Prezime,
                    Spol = igrac.Spol.ToString(),
                    Godište = igrac.Godiste.ToString(),
                    Nacionalnost = igrac.Nacionalnost,
                    Pozicija = igrac.Pozicija.ToString(),
                    Aktivan = igrac.Aktivan.ToString() == "True" ? "DA" : "NE"
                });
            }

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DBListaIgraca";
            rds.Value = list;

            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
