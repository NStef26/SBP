using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class ZatvoreniProstorMapiranja : ClassMap<ZatvoreniProstor>

    {
        public ZatvoreniProstorMapiranja()
        {
            Table("ZATVORENI_PROSTOR");
            Id(x => x.Id).Column("ID_ZATVORENOG_PROSTORA").GeneratedBy.TriggerIdentity();
            Map(x => x.Vlasnik).Column("VLASNIK_PROSTORA");
            Map(x => x.Cena).Column("CENA_IZNAJMLJIVANJA");
            References(x => x.Dogadjaj).Column("ID_AKCIJE3").Unique();
        }
    }
}
