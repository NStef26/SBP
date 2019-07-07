using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;
namespace SBP.Mapiranja
{
    class KoordinatorMapiranja : SubclassMap<Koordinator>
    {
       public KoordinatorMapiranja()
        {
            Table("KOORDINATOR");
            KeyColumn("ID_AKTIVISTE");
            Map(x => x.Adresa_kancelarije).Column("ADRESA_KANCELARIJE");
            Map(x => x.Ime_opstine).Column("IME_OPSTINE");

            HasMany(x => x.KoordiniseAktiviste).KeyColumn("ID_AKTIVISTE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
