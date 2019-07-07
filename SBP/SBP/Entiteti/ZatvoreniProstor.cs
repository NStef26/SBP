using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class ZatvoreniProstor
    {
        public virtual int Id { get;  set; }
        public virtual String Vlasnik { get; set; }
        public virtual String Cena { get; set; }
        public virtual Miting Dogadjaj { get; set; }
    }
}
