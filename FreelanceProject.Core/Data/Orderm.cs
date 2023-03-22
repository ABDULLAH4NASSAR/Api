using System;
using System.Collections.Generic;

#nullable disable

namespace School.Core.Data
{
    public partial class Orderm
    {
        public Orderm()
        {
            MedecinOrders = new HashSet<MedecinOrder>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public DateTime? Orderdate { get; set; }

        public virtual ICollection<MedecinOrder> MedecinOrders { get; set; }
    }
}
