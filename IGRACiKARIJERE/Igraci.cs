using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGRACiKARIJERE
{
    [Table("Igraci")]
    public class Igraci
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public virtual Spolovi Spol { get; set; }
        public int Godiste { get; set; }
        public string Nacionalnost { get; set; }
        public byte[] Slika { get; set; }
        public virtual Pozicije Pozicija { get; set; }
        public string Sifra { get; set; }
        public bool Aktivan { get; set; }
        public virtual List<IgraciKlubovi> Karijera { get; set; } = new List<IgraciKlubovi>();
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
