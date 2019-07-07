using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class MitingMapiranja :SubclassMap<Miting>

    {
      public MitingMapiranja()
        {
            Table("MITING");
            KeyColumn("ID_AKCIJE");
            Map(x => x.Lokacija).Column("LOKACIJA_MITINGA");
            Map(x => x.Mesto).Column("MESTO");
            References(x => x.Gostuje).Column("ID_GOSTA3");
            //HasMany(x=>x.Prostor)
           
        }
    }
}
