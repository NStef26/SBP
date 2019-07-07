using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class Gostovanje : Pojavljivanje
    {
        public virtual int Gledanost { get; set; }
        public virtual String Emisija { get; set; }
        public virtual String Voditelj { get; set; }
        public virtual TVDuel Duel { get; set; }
    }
}
