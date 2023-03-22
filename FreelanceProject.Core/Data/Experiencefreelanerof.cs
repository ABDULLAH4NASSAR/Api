using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Experiencefreelanerof
    {
        public decimal Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Summary { get; set; }
        
        public string status { get; set; }

        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public decimal? Id_Freelancer { get; set; }

        public virtual Freelanceraccountof IdFreelancerNavigation { get; set; }
    }
}
