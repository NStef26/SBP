using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class LokacijaDeljenjeMapiranja : ClassMap<LokacijaDeljenje>
    {
        public LokacijaDeljenjeMapiranja()
        {
            Table("NAZIVI_LOKACIJA");
            Id(x => x.Id).Column("ID_LOKACIJA").GeneratedBy.TriggerIdentity();
            Map(x => x.Naziv).Column("NAZIVI_LOKACIJA");
            References(x => x.Deljenje).Column("ID_AKCIJE1");
        }
    }
}
