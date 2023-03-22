using System;
using System.Collections.Generic;

#nullable disable

namespace School.Core.Data
{
    public partial class Medecin
    {
        public Medecin()
        {
            MedecinOrders = new HashSet<MedecinOrder>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<MedecinOrder> MedecinOrders { get; set; }
    }
}
