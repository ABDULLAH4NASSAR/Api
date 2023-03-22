using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Loginof
    {
        public Loginof()
        {
            Freelanceraccountofs = new HashSet<Freelanceraccountof>();
            Useraccountofs = new HashSet<Useraccountof>();
        }

        public decimal Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal? Id_Role { get; set; }

        public virtual Roleof IdRoleNavigation { get; set; }
        public virtual ICollection<Freelanceraccountof> Freelanceraccountofs { get; set; }
        public virtual ICollection<Useraccountof> Useraccountofs { get; set; }
    }
}
