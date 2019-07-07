using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class GostMapiranja :ClassMap<Gost>
    {
        public GostMapiranja()
        {
            Table("GOST");
            Id(x => x.Id).Column("ID_GOSTA").GeneratedBy.TriggerIdentity();
            Map(x => x.Ime).Column("IME_GOSTA");
            Map(x => x.Prezime).Column("PREZIME_GOSTA");
            Map(x => x.Funkcija).Column("FUNKCIJA");
            HasMany(x => x.Mitinzi).KeyColumn("ID_GOSTA").LazyLoad().Cascade.All().Inverse();
        }

    }
}
