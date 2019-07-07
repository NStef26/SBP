using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class Intervju : Pojavljivanje
    {
        public virtual DateTime Intervjuisan { get; set; }
        public virtual DateTime Objavljen { get; set; }
        public virtual String Naziv { get; set; }
        public virtual IList<Novinar> ListaNovinara { get; set; }
        public Intervju()
        {
            ListaNovinara = new List<Novinar>();
        }

    }
}
