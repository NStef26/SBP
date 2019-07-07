using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class AktivistaMapiranja : ClassMap<Aktivista>
    {
        public AktivistaMapiranja()
        {
            Table("AKTIVISTA");
            Id(x => x.Id).Column("ID_AKTIVISTE").GeneratedBy.TriggerIdentity();
            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Ime_roditelja).Column("IME_RODITELJA");
            Map(x => x.Datum_rodjenja).Column("DATUM_RODJENJA");
            Map(x => x.Adresa).Column("ADRESA");
            References(x => x.Posmatra).Column("ID_GLASACKOG_MESTA");
            References(x => x.NjegovKoordinator).Column("ID_KOORDINATORA");
            //HasMany(x => x.ListaAkcija).KeyColumn("ID_AKTIVISTE").LazyLoad().Cascade.All().Inverse(); //!!!

            HasManyToMany(x => x.ListaAkcija)
                .Table("UCESTVUJE")
                .ParentKeyColumn("ID_AKTIVISTE0")
                .ChildKeyColumn("ID_AKCIJE1")
                .Inverse()
                .Cascade.All();
            HasMany(x => x.Ucestvuju).KeyColumn("ID_AKTIVISTE0").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Mailovi).KeyColumn("ID_AKTIVISTE1").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Telefoni).KeyColumn("ID_AKTIVISTE2").LazyLoad().Cascade.All().Inverse();

        }

    }
}
