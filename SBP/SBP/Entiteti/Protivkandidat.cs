using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class Protivkandidat
    {
        public virtual int Id { get; set; }
        public virtual TVDuel Duel { get; set; }
        public virtual String ImeProtivkandidata { get; set; }
    }
}
