using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Categoryof
    {
        public Categoryof()
        {
            Freelanceraccountofs = new HashSet<Freelanceraccountof>();
        }

        public decimal Id { get; set; }
        public string Catname { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Freelanceraccountof> Freelanceraccountofs { get; set; }
    }
}
