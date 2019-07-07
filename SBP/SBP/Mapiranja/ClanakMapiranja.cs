using FluentNHibernate.Mapping;
using SBP.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Mapiranja
{
    class ClanakMapiranja : SubclassMap<Clanak>
    {
        public ClanakMapiranja()
        {
            Table("CLANAK");
            KeyColumn("ID_REKLAMNOG_PROSTORA");
            Map(x => x.Boja).Column("BOJA");
            Map(x => x.Naziv).Column("NAZIV_LISTA");
        }
    }
}
