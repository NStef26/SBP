using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class Pano : ReklamniProstor
    {
        public virtual String Ulica { get; set; }
        public virtual String Grad { get; set; }
        public virtual int Povrsina { get; set; }
        public virtual String Agencija { get; set; }
    }
}
