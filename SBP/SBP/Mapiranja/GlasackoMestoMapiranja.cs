using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class GlasackoMestoMapiranja : ClassMap<GlasackoMesto>
    {
        public GlasackoMestoMapiranja()
        {
            Table("GLASACKO_MESTO");
            Id(x => x.Id).Column("ID_GLASACKOG_MESTA").GeneratedBy.TriggerIdentity();
            Map(x => x.BrojGlasackogMesta).Column("BROJ_GLASACKOG_MESTA");
            Map(x => x.NazivIzborneJedinice).Column("NAZIV_IZBORNE_JEDINICE");
            Map(x => x.UkupnoBiraca).Column("UKUPNO_BIRACA");
            //Map(x => x.Rezultat).Column("REZULTATI_NA_GLASACKOM_MESTU");
            Map(x => x.IzborniKrug).Column("IZBORNI_KRUG");
            References(x => x.Rezultat).Column("REZULTATI_NA_GLASACKOM_MESTU");
            HasMany(x => x.ListaAktivista).KeyColumn("ID_GLASACKOG_MESTA");
        }
    }
}
