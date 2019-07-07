using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace SBP.Mapiranja
{
    public class AkcijaMapiranja : ClassMap<SBP.Entiteti.Akcija> {
        public AkcijaMapiranja()
        {
            Table("AKCIJA");
            Id(x => x.ID).Column("ID_AKCIJE").GeneratedBy.TriggerIdentity();
            Map(x => x.Naziv, "NAZIV");

            HasManyToMany(x => x.ListaAktivista)
                .Table("UCESTVUJE")
                .ParentKeyColumn("ID_AKCIJE1")
                .ChildKeyColumn("ID_AKTIVISTE0")
                //.Inverse()
                .Cascade.All();
           
            HasMany(x => x.Ucestvuju).KeyColumn("ID_AKCIJE1").LazyLoad().Cascade.All().Inverse(); //!

    } }
}
