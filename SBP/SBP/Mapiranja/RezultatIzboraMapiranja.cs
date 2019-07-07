using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class RezultatIzboraMapiranja : ClassMap<RezultatIzbora>
    {
        public RezultatIzboraMapiranja()
        {
            Table("REZULTATI_IZBORA");
            Id(x => x.Id).Column("ID_REZULTATA_IZBORA").GeneratedBy.TriggerIdentity();
            Map(x => x.ProcenatGlasalih).Column("PROCENAT_GLASALIH_ZA_KANDIDATA");
            Map(x => x.BrojIzaslihGlasaca).Column("BROJ_BIRACA_IZASLIH");

        }

    }
}
