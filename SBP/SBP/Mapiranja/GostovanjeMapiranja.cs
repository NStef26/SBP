using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class GostovanjeMapiranja : SubclassMap<Gostovanje>
    {
        public GostovanjeMapiranja() {
            Table("GOSTOVANJE");
            KeyColumn("ID_POJAVLJIVANJA");
            Map(x => x.Gledanost).Column("GLEDANOST");
            Map(x => x.Emisija).Column("NAZIV_EMISIJE");
            Map(x => x.Voditelj).Column("IME_VODITELJA");
        }
    }
}
