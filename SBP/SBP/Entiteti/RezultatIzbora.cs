using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class RezultatIzbora
    {
        public virtual int Id { get; set; }
        public virtual int ProcenatGlasalih { get; set; }
        public virtual int BrojIzaslihGlasaca { get; set; }

        public virtual GlasackoMesto Mesto { get; set; }


    }
}
