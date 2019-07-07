using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP.Entiteti;

namespace SBP.Mapiranja
{
    class IntervjuMapiranja : SubclassMap<Intervju>
    {
        public IntervjuMapiranja()
        {
            Table("INTERVJU");
            KeyColumn("ID_POJAVLJIVANJA");
            Map(x => x.Intervjuisan).Column("DATUM_INTERVJUA");
            Map(x => x.Objavljen).Column("DATUM_OBJAVLJIVANJA");
            Map(x => x.Naziv).Column("NAZIV_LISTA");
            HasMany(x => x.ListaNovinara).KeyColumn("ID_POJAVLJIVANJA");
        }
    }
}
