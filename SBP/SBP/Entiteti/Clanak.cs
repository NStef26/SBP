using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class Clanak : ReklamniProstor
    {
        public virtual String Boja { get; set; }
        public virtual String Naziv { get; set; }
    }
}
