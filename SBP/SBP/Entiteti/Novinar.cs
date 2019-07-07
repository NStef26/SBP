using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
   public  class Novinar
    {
        public virtual int Id { get; set; }
        public virtual Intervju Intervjuise { get; set; }
        public virtual String Ime { get; set; }
    }
}
