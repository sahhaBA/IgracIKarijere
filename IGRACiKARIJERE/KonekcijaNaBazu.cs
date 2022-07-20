using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGRACiKARIJERE
{
    public class KonekcijaNaBazu : DbContext
    {
        public static KonekcijaNaBazu _knb = new KonekcijaNaBazu();
        public KonekcijaNaBazu() : base("PutanjaNaBazu")
        {

        }
        public DbSet<Igraci> Igraci { get; set; }
        public DbSet<Spolovi> Spolovi { get; set; }
        public DbSet<Pozicije> Pozicije { get; set; }
        public DbSet<Klubovi> Klubovi { get; set; }
        public DbSet<Stadioni> Stadioni { get; set; }
        public DbSet<IgraciKlubovi> IgraciKlubovi { get; set; }
        public DbSet<ZauzetiStadioni> ZauzetiStadioni { get; set; }
    }
}
