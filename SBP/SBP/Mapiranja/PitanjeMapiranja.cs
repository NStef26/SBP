using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class PitanjeMapiranja : ClassMap<Pitanje>
    {
        public PitanjeMapiranja()
        {
            Table("PITANJE");
            Id(x => x.Id).Column("ID_PITANJA").GeneratedBy.TriggerIdentity();
            Map(x => x.Tekst).Column("PITANJE");
            References(x => x.Duel).Column("ID_TV_DUEL");
        }
    }
}
