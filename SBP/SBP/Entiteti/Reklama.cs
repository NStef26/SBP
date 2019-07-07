using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class Reklama : ReklamniProstor
    {
        public virtual int Trajanje { get; set; }
        public virtual int BrEmitovanja { get; set; }
        public virtual String Naziv { get; set; }
    }
}
