using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class Miting : Akcija
    {
        public virtual String Lokacija { get; set; }
        public virtual String Mesto { get; set; }
        public virtual Gost Gostuje { get; set; }
        public virtual ZatvoreniProstor Prostor { get; set; }
    }
}
