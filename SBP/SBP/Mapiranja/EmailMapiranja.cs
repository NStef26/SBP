using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class EmailMapiranja : ClassMap<Email>
    {
        public EmailMapiranja()
        {
            Table("E_MAIL");
            Id(x => x.Id).Column("ID_E_MAIL").GeneratedBy.TriggerIdentity();
            Map(x => x.Mail).Column("E_MAIL");
            References(x => x.aktivista).Column("ID_AKTIVISTE1");
        }
    }
}
