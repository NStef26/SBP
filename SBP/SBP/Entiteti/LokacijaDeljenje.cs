using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
   public class LokacijaDeljenje
    {
        public virtual int Id { get;  set; }
        public virtual String Naziv { get; set; }
        public virtual DeljenjeLetaka Deljenje { get; set; }
    }
}
