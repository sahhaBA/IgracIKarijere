using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGRACiKARIJERE
{
    [Table("Klubovi")]
    public class Klubovi
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public Stadioni Stadion { get; set; }
        public int GodinaOsnivanja { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
