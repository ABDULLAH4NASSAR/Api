using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Testomonialfreelancer
    {
        public decimal Id { get; set; }
        public string Status { get; set; }
        public string Massage { get; set; }
        public decimal? Id_Freelancer { get; set; }

        public virtual Freelanceraccountof IdFreelancerNavigation { get; set; }
    }
}
