using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class ReklamniProstorMapiranja : ClassMap<ReklamniProstor>
    {
        public ReklamniProstorMapiranja()
        {
            Table("REKLAMNI_PROSTOR");
            Id(x => x.Id).Column("ID_REKLAMNOG_PROSTORA").GeneratedBy.TriggerIdentity();
            Map(x => x.Iznos).Column("IZNOS");
            Map(x => x.DatumOd).Column("DATUM_OD");
            Map(x => x.DatumDo).Column("DATUM_DO");
        }
    }
}
