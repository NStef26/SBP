using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class UcestvujeMapiranja : ClassMap<Ucestvuje>
    {
        public UcestvujeMapiranja()
        {
            Table("UCESTVUJE");
            CompositeId(x => x.Id)
                .KeyReference(x => x.AktivistaUcestvuje, "ID_AKTIVISTE0")
                .KeyReference(x => x.UcestvujeAkcija, "ID_AKCIJE1");
        }
    }
}
