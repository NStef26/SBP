using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP.Entiteti
{
    public class UcestvujeId
    {
        public virtual Aktivista AktivistaUcestvuje { get; set; }
        public virtual Akcija UcestvujeAkcija { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(UcestvujeId))
                return false;

            UcestvujeId receivedObject = (UcestvujeId)obj;
            if ((AktivistaUcestvuje.Id == receivedObject.AktivistaUcestvuje.Id) &&
                (UcestvujeAkcija.ID == receivedObject.UcestvujeAkcija.ID))
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
