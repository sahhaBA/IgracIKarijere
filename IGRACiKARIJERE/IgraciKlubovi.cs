using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGRACiKARIJERE
{
    [Table("IgraciKlubovi")]
    public class IgraciKlubovi
    {
        public int Id { get; set; }
        public Igraci Igrac { get; set; }
        public Klubovi Klub { get; set; }
        public int Golovi { get; set; }
        public int Trofeji { get; set; }
        public override string ToString()
        {
            return $"{Igrac}/{Klub}";
        }
    }
}
