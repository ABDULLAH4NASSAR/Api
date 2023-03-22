using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Educationfreelanerof
    {
        public decimal Id { get; set; }
        public string Country { get; set; }
        public string University_College { get; set; }
        public string Degree { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public decimal? Id_Freelancer { get; set; }

        public virtual Freelanceraccountof IdFreelancerNavigation { get; set; }
    }
}
