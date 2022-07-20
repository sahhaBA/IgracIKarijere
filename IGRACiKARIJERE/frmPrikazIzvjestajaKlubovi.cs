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
    public partial class frmPrikazIzvjestajaKlubovi : Form
    {
        List<Klubovi> klubovi = null;
        public frmPrikazIzvjestajaKlubovi(ref List<Klubovi> tempKlubovi)
        {
            InitializeComponent();
            klubovi = tempKlubovi;
        }

        private void frmPrikazIzvjestajaKlubovi_Load(object sender, EventArgs e)
        {
            int i = 0;
            List<object> list = new List<object>();
            foreach (var k in klubovi)
            {
                list.Add(new
                {
                    Rb = ++i,
                    Naziv = k.Naziv,
                    Lokacija = k.Lokacija,
                    Stadion = k.Stadion.ToString(),
                    GodinaOsnivanja = k.GodinaOsnivanja
                });
            }

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DSTabela";
            rds.Value = list;

            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
