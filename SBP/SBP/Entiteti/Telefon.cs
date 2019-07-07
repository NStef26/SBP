using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class Telefon
    {   
        public virtual int Id { get;  set; }
        public virtual Aktivista aktivista { get; set; }
        public virtual int telefon { get; set; }
    }
}
