using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class TVDuelMapiranja : ClassMap<TVDuel>
    {
        public TVDuelMapiranja()
        {
            Table("TV_DUEL");
            Id(x => x.Id).Column("ID_TV_DUELA").GeneratedBy.TriggerIdentity();
            Map(x => x.Stanica).Column("NAZIV_STANICE");
            References(x => x.JeGostovanje).Column("ID_POJAVLJIVANJA2");
            HasMany(x => x.Protivkandidati).KeyColumn("ID_TV_DUEL").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Pitanja).KeyColumn("ID_TV_DUEL").LazyLoad().Cascade.All().Inverse();
        }
    }
}
