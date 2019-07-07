using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class Susret : Akcija
    {
        public virtual String Grad { get; set; }
        public virtual String Lokacija { get; set; }
        public virtual int Trajanje { get; set; }
    }
}
