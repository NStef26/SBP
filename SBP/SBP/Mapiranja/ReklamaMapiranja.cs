using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class ReklamaMapiranja :SubclassMap<Reklama>

    {
        public ReklamaMapiranja()
        {
            Table("REKLAMA");
            KeyColumn("ID_REKLAMNOG_PROSTORA");
            Map(x => x.Trajanje).Column("TRAJANJE");
            Map(x => x.BrEmitovanja).Column("BR_EMITOVANJA");
            Map(x => x.Naziv).Column("NAZIV_TELEVIZIJE");
        }
    }
}
