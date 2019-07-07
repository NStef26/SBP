using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
   public class Ucestvuje
    {
        public virtual UcestvujeId Id { get; set; }

        public Ucestvuje()
        {
            Id = new UcestvujeId();
        }
    }
}
