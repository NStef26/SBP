using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class SusretMapiranja :SubclassMap<Susret>
    {
       public SusretMapiranja()
        {
            Table("SUSRETI");
            KeyColumn("ID_AKCIJE");
            Map(x => x.Grad).Column("GRAD_SUSRET");
            Map(x => x.Lokacija).Column("LOKACIJA_SUSRETA");
            Map(x => x.Trajanje).Column("VREME_TRAJANJA");
        }

    }
}
