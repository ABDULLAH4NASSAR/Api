using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Qualificationsfreelanerof
    {
        public decimal Id { get; set; }
        public string Professionalcertificate_Award { get; set; }
        public string Conferringorganization { get; set; }
        public string Summary { get; set; }
        public DateTime? Startdate { get; set; }
        public decimal? Id_Freelancer { get; set; }

        public virtual Freelanceraccountof IdFreelancerNavigation { get; set; }
    }
}
