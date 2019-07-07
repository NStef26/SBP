using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using SBP.Entiteti;
using System.Threading.Tasks;

namespace SBP.Mapiranja
{
    class PojavljivanjeMapiranja : ClassMap<Pojavljivanje>
    {
        public PojavljivanjeMapiranja()
        {
            Table("POJAVLJIVANJE");
            Id(x => x.Id).Column("ID_POJAVLJIVANJA").GeneratedBy.SequenceIdentity("POJAVLJIVANJE_ID_SEQ");
            
            
        }
    }
}
