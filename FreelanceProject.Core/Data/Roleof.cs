using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Roleof
    {
        public Roleof()
        {
            Loginofs = new HashSet<Loginof>();
        }

        public decimal Id { get; set; }
        public string Namerole { get; set; }

        public virtual ICollection<Loginof> Loginofs { get; set; }
    }
}
