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
    public partial class frmIgraci : Form
    {
        KonekcijaNaBazu knb = null;
        List<Igraci> tempIgraci = null;
        List<Klubovi> tempKlubovi = null;
        List<IgraciKlubovi> tempIgraciKlubovi = null;
        List<Spolovi> tempSpolovi = null;
        List<Pozicije> tempPozicije = null;
        public frmIgraci(KonekcijaNaBazu knbb, ref List<Igraci> Prikazani, ref List<Klubovi> klubovi, ref List<IgraciKlubovi>IgKl, ref List<Spolovi> spl, ref List<Pozicije> pzc)
        {
            InitializeComponent();
            knb = knbb;
            dgv_Igraci.AutoGenerateColumns = false;
            tempIgraci = Prikazani;
            tempKlubovi = klubovi;
            tempIgraciKlubovi = IgKl;
            tempSpolovi = spl;
            tempPozicije = pzc;
            UcitajFilter();
            UcitajPodatke();
            cmb_Filter.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void UcitajFilter()
        {
            List<string> tempLista = new List<string> { "Sve", "Napad", "Veza", "Odbrana", "Golman" };
            cmb_Filter.DataSource = tempLista;
        }

        private void UcitajPodatke(List<Igraci> Prikazani = null)
        {
            var rezultat = Prikazani ?? tempIgraci.ToList();

            dgv_Igraci.DataSource = null;
            dgv_Igraci.DataSource = rezultat;

            lbl_UkupnoPrikazanih.Text = $"Ukupno prikazanih: {rezultat.Count()}";

            IzracunajProsjekGolova(rezultat);
        }

        private void IzracunajProsjekGolova(List<Igraci> rezultat = null)
        {
            double prosjek = 0;
            int igraciSaGolovima = 0;

            foreach (var igrac in rezultat)
            {
                double temp = igrac.Karijera.Sum(g => g.Golovi);
                temp /= igrac.Karijera.Count();
                if(temp > 0)
                {
                    igraciSaGolovima++;
                    prosjek += temp;
                }
            }

            if (igraciSaGolovima > 0)
                prosjek /= igraciSaGolovima;

            lbl_ProsjekGolova.Text = prosjek == 0 ? "Prosjek golova prikazanih igrača: 0" :
                $"Prosjek golova prikazanih igrača: {prosjek.ToString("#.00")}";
        }

        private void btn_Izlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Pretraga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UcitajIgrace(txt_Pretraga, cmb_Filter);
            }
            catch(Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void UcitajIgrace(TextBox txt_Pretraga, ComboBox cmb_Filter)
        {
            string filter = txt_Pretraga.Text.ToLower().Trim();
            string selektovano = (cmb_Filter.SelectedItem.ToString() == "Sve") ? "" : cmb_Filter.SelectedItem.ToString();

            var rezultat = string.IsNullOrWhiteSpace(filter) ? tempIgraci.AsEnumerable().Where(i => i.Pozicija.Naziv.Contains(selektovano)).ToList()
                : tempIgraci.AsEnumerable().Where(i => i.Pozicija.Naziv.Contains(selektovano) && (i.Ime.ToLower().Contains(filter) || i.Prezime.ToLower().Contains(filter))).ToList();

            UcitajPodatke(rezultat);
        }

        private void cmb_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UcitajIgrace(txt_Pretraga, cmb_Filter);
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }
        private void btn_DodajIgraca_Click(object sender, EventArgs e)
        {
            Hide();
            frmDodajIgraca frm = new frmDodajIgraca(knb, ref tempIgraci, ref tempSpolovi, ref tempPozicije);
            frm.ShowDialog();
            UcitajPodatke();
            Show();
        }

        private void dgv_Igraci_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Igraci kliknutiIgrac = dgv_Igraci.SelectedRows[0].DataBoundItem as Igraci;
                    if (kliknutiIgrac != null)
                    {
                        Form frm = null;
                        if (e.ColumnIndex == 7)
                        {
                            Hide();
                            frm = new frmIgraciKluboviKarijera(knb, kliknutiIgrac, ref tempKlubovi, ref tempIgraciKlubovi);
                        }
                        else
                            frm = new frm_PotvrdiSifru(kliknutiIgrac, knb, ref tempIgraci, ref tempSpolovi, ref tempPozicije);
                        frm.ShowDialog();
                        UcitajPodatke();
                        Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void btn_Printaj_Click(object sender, EventArgs e)
        {
            Hide();
            frmPrikazIzvjestajaListeIgraca frm = new frmPrikazIzvjestajaListeIgraca(ref tempIgraci);
            frm.ShowDialog();
            Show();
        }
    }
}
