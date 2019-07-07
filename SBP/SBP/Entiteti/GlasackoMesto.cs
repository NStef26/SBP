using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class GlasackoMesto
    {
        public virtual int Id { get; set; }
        public virtual int BrojGlasackogMesta { get; set; }
        public virtual String NazivIzborneJedinice { get; set; }
        public virtual int UkupnoBiraca { get; set; }
        public virtual int Rezultati { get; set; }
        public virtual String IzborniKrug { get; set; }
        //mozda treba dima Posmatra
        public virtual RezultatIzbora Rezultat { get; set; }
        public virtual IList<Aktivista> ListaAktivista { get; set; }
        
        public GlasackoMesto()
        {
            ListaAktivista = new List<Aktivista>();
        }
    }
}
