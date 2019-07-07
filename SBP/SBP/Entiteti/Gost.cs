using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
   public class Gost
    {
        public virtual int Id { get; set; }
        public virtual String Ime { get; set; }
        public virtual String Prezime { get; set; }
        public virtual String Funkcija { get; set; }
        public virtual IList<Miting> Mitinzi { get; set; }

        public Gost() {
            Mitinzi = new List<Miting>(); 
        }

    }
}
