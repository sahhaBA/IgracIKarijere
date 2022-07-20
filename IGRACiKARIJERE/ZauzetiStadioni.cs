using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGRACiKARIJERE
{
    [Table("ZauzetiStadioni")]
    public class ZauzetiStadioni
    {
        public int Id { get; set; }
        public Stadioni Stadion { get; set; }
        public Klubovi Klub { get; set; }
    }
}
