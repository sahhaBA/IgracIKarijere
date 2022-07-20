using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGRACiKARIJERE
{
    public partial class frmModifikacijaIgracaKluba : Form
    {
        KonekcijaNaBazu knb = null;
        List<Klubovi> tempKlubovi = null;
        IgraciKlubovi IgracKlub = null;
        Igraci Igrac = null;
        public frmModifikacijaIgracaKluba(KonekcijaNaBazu knbb, ref List<Klubovi> kluboviZaUcitat, IgraciKlubovi kliknutiIgracKlub, Igraci kliknutiIgrac)
        {
            InitializeComponent();
            knb = knbb;
            tempKlubovi = kluboviZaUcitat;
            IgracKlub = kliknutiIgracKlub;
            Igrac = kliknutiIgrac;
            Text = $"MODIFIKOVANJE KARIJERE - {IgracKlub}";
            cmb_Klubovi.DropDownStyle = ComboBoxStyle.DropDownList;
            UcitajPodakteOKliknutom();
        }

        private void UcitajPodakteOKliknutom()
        {
            var query = (from k in tempKlubovi.AsEnumerable()
                        where !(from ek in Igrac.Karijera
                               select ek.Klub.Id).Contains(k.Id)
                        select k).ToList();

            cmb_Klubovi.DataSource = !chck_UcitajNeunesene.Checked ? tempKlubovi : query;
            cmb_Klubovi.DisplayMember = "Naziv";
            cmb_Klubovi.ValueMember = "Id";

            cmb_Klubovi.SelectedItem = IgracKlub.Klub;
            txt_Golovi.Text = IgracKlub.Golovi.ToString();
            txt_Trofeji.Text = IgracKlub.Trofeji.ToString();
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chck_UcitajNeunesene_CheckedChanged(object sender, EventArgs e)
        {
            UcitajPodakteOKliknutom();
        }

        private void btn_Spasi_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validiraj())
                {
                    if (cmb_Klubovi.SelectedItem != IgracKlub.Klub)
                        DaLiVecPostoji();

                    IgracKlub.Klub = cmb_Klubovi.SelectedItem as Klubovi;
                    IgracKlub.Golovi = int.Parse(txt_Golovi.Text);
                    IgracKlub.Trofeji = int.Parse(txt_Trofeji.Text);

                    knb.Entry(IgracKlub).State = EntityState.Modified;
                    MessageBox.Show($"{IgracKlub} - uspješno modifikovano", "Uspješno editovanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    knb.SaveChanges();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void DaLiVecPostoji()
        {
            if (Igrac.Karijera.Where(ik => ik.Klub == cmb_Klubovi.SelectedItem as Klubovi).Count() > 0)
                throw new Exception($"Klub {cmb_Klubovi.Text} je već evidentiran za igrača {Igrac}");
        }

        private bool Validiraj()
        {
            return ObaveznoPolje(txt_Golovi) && ObaveznoPolje(txt_Trofeji) && ObaveznoPolje(cmb_Klubovi);
        }

        private bool ObaveznoPolje(object obj)
        {
            int parsedValue = 0;
            if(obj is TextBox && (string.IsNullOrWhiteSpace((obj as TextBox).Text) || !int.TryParse((obj as TextBox).Text, out parsedValue) || parsedValue < 0))
            {
                err.SetError(obj as TextBox, "OBAVEZAN UNOS!");
                return false;
            }
            else if (obj is ComboBox && (obj as ComboBox).SelectedIndex == -1)
            {
                err.SetError(obj as ComboBox, "Polje je prazno, dodajte novi klub!");
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
