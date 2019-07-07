using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class Akcija
    {
        public virtual int ID { get; set; }
        public virtual String Naziv { get; set; }
        public virtual IList<Aktivista> ListaAktivista { get; set; }
        public virtual IList<Ucestvuje> Ucestvuju { get; set; }

        public Akcija()
        {
            ListaAktivista = new List<Aktivista>();
            Ucestvuju = new List<Ucestvuje>();
        }

    }
}
