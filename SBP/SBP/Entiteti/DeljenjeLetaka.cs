using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class DeljenjeLetaka : Akcija
    {
        public virtual String Grad { get; set; } 
        public virtual IList<LokacijaDeljenje> ListaLokacija { get; set; }
        public DeljenjeLetaka()
        {
            ListaLokacija = new List<LokacijaDeljenje>();
        }
    }
}
