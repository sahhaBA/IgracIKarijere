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
    public partial class frm_PotvrdiSifru : Form
    {
        KonekcijaNaBazu knb = null;
        Igraci Igrac { get; set; }
        List<Igraci> tempIgraci = null;
        List<Spolovi> tempSpolovi = null;
        List<Pozicije> tempPozicije = null;
        public frm_PotvrdiSifru(Igraci kliknutiIgrac, KonekcijaNaBazu knbb, ref List<Igraci> Prikazati, ref List<Spolovi> spl, ref List<Pozicije> pzc)
        {
            InitializeComponent();
            knb = knbb;
            Igrac = kliknutiIgrac;
            tempIgraci = Prikazati;
            tempSpolovi = spl;
            tempPozicije = pzc;
            Text = Igrac.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Sifra.Text == Igrac.Sifra)
            {
                Hide();
                frmDodajIgraca frm = new frmDodajIgraca(Igrac, knb, ref tempIgraci, ref tempSpolovi, ref tempPozicije);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Šifra nevažeća", $"Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_Sifra.Text = "";
        }
    }
}
