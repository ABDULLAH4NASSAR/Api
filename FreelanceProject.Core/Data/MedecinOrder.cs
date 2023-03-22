using System;
using System.Collections.Generic;

#nullable disable

namespace School.Core.Data
{
    public partial class MedecinOrder
    {
        public MedecinOrder()
        {
            Endusers = new HashSet<Enduser>();
        }

        public decimal Id { get; set; }
        public decimal? MedecinIdFk { get; set; }
        public decimal? OrderIdFk { get; set; }

        public virtual Medecin MedecinIdFkNavigation { get; set; }
        public virtual Orderm OrderIdFkNavigation { get; set; }
        public virtual ICollection<Enduser> Endusers { get; set; }
    }
}
