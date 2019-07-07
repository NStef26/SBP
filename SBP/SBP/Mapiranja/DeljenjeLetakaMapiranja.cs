using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class DeljenjeLetakaMapiranja : SubclassMap<DeljenjeLetaka>
    {
       public DeljenjeLetakaMapiranja()
        {
            Table("DELJENJE_LETAKA");
            KeyColumn("ID_AKCIJE");
            Map(x => x.Grad).Column("GRAD_DELJENJE");
            HasMany(x => x.ListaLokacija).KeyColumn("ID_AKCIJE1").LazyLoad().Cascade.All().Inverse();
        }
    }
}
