using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class TVDuel
    {
        public virtual int Id { get; set; }
        public virtual String Stanica { get; set; }
        public virtual Gostovanje JeGostovanje { get; set; }
        public virtual IList<Protivkandidat> Protivkandidati { get; set; }
        public virtual IList<Pitanje> Pitanja { get; set; }
        public TVDuel() {
            Protivkandidati = new List<Protivkandidat>();
            Pitanja = new List<Pitanje>();
        }
    }
    
}
