using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Postprojectof
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Skillsrequired { get; set; }
        public string Currency { get; set; }
        public decimal? Amounttopaybyhours { get; set; }
        public decimal? Payfixedprice { get; set; }
        public decimal? Totalfees { get; set; }
        public decimal? Profitsamount { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public decimal? Status_Completeornot { get; set; }
        public decimal? Status_Acceptorreject { get; set; }
        public decimal? Status_Acceptsolution { get; set; }
        public string Attachmentfilefromuser { get; set; }
        public string Attachmentfilefromfreelancer { get; set; }
        public string Attachmentprogressproject { get; set; }
        public decimal? Id_User { get; set; }
        public decimal? ID_FREELANCER { get; set; }


        public virtual Useraccountof IdUserNavigation { get; set; }
    }
}
