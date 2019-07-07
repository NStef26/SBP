using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class Aktivista
    {
        public virtual int Id { get;set; }
        public virtual String Ime { get; set; }
        public virtual String Ime_roditelja { get; set; }
        public virtual String Prezime { get; set; }
        public virtual String Primedba { get; set; } //ako nema primedbu, napisaće 'nemam primedbi'
        public virtual DateTime Datum_rodjenja { get; set; }
        public virtual String Adresa { get; set; }
        public virtual IList<Email> Mailovi { get; set; }
        public virtual IList<Telefon> Telefoni { get; set; }
        public virtual GlasackoMesto Posmatra { get; set; }
        public virtual IList<Akcija> ListaAkcija { get; set; }
        public virtual Koordinator NjegovKoordinator { get; set; }
        public virtual IList<Ucestvuje> Ucestvuju { get; set; }

        public Aktivista() {
            Mailovi = new List<Email>();
            Telefoni = new List<Telefon>();
            ListaAkcija = new List<Akcija>();
            Ucestvuju = new List<Ucestvuje>();

        }
        
    }
    public class Koordinator : Aktivista {
        public virtual IList<Aktivista> KoordiniseAktiviste { get; set; }
        public virtual String Ime_opstine { get; set; }
        public virtual String Adresa_kancelarije { get; set; }
        public Koordinator() {
            KoordiniseAktiviste = new List<Aktivista>(4); 
        }
    }
}
