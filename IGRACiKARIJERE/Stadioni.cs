using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGRACiKARIJERE
{
    [Table("Stadioni")]
    public class Stadioni
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Kapacitet { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
