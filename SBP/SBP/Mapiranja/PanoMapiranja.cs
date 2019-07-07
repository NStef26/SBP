using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class PanoMapiranja : SubclassMap<Pano>
    {
        public PanoMapiranja()
        {
            Table("PANOI");
            KeyColumn("ID_REKLAMNOG_PROSTORA");
            Map(x => x.Ulica).Column("NAZIV_ULICE");
            Map(x => x.Grad).Column("GRAD_PANO");
            Map(x => x.Povrsina).Column("POVRSINA");
            Map(x => x.Agencija).Column("AGENCIJA_VLASNIK");
        }
    }
}
