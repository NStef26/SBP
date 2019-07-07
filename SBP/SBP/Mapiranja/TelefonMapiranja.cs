using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class TelefonMapiranja : ClassMap<Telefon>
    {
        public TelefonMapiranja()
        {
            Table("TELEFON");
            Id(x => x.Id).Column("ID_TELEFON").GeneratedBy.TriggerIdentity();
            Map(x => x.telefon).Column("TELEFON");
            References(x => x.aktivista).Column("ID_AKTIVISTE2");
        }
    }
}
