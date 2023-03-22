using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Reviewsof
    {
        public decimal Id { get; set; }
        public string Comments { get; set; }
        public decimal? Id_User { get; set; }
        public decimal? Id_Freelancer { get; set; }

        public virtual Freelanceraccountof IdFreelancerNavigation { get; set; }
        public virtual Useraccountof IdUserNavigation { get; set; }
    }
}
