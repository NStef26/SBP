using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class NovinarMapiranja : ClassMap<Novinar>
    {
        public NovinarMapiranja()
        {
            Table("IME_NOVINARA");
            Id(x => x.Id).Column("ID_NOVINARA").GeneratedBy.TriggerIdentity();
            Map(x => x.Ime).Column("IME_NOVINARA");
            References(x => x.Intervjuise).Column("ID_POJAVLJIVANJA");
        }
    }
}
