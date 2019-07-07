using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class ProtivkandidatMapiranja : ClassMap<Protivkandidat>
    {
        public ProtivkandidatMapiranja()
        {
            Table("IME_PROTIVKANDIDATA");
            Id(x => x.Id).Column("ID_PROTIVKANDIDATA");
            Map(x => x.ImeProtivkandidata).Column("IME_PROTIVKANDIDATA");
            References(x => x.Duel).Column("ID_TV_DUEL");
        }
    }
}
