using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Paymentmethodof
    {
        public Paymentmethodof()
        {
            Wallettofs = new HashSet<Wallettof>();
        }

        public decimal Id { get; set; }
        public decimal Card { get; set; }
        public DateTime Expirydate { get; set; }
        public string Cardholdername { get; set; }
        public decimal Cvc_Cvv { get; set; }
        public decimal? Id_User { get; set; }
        public decimal? Id_Freelancer { get; set; }

        public virtual Freelanceraccountof IdFreelancerNavigation { get; set; }
        public virtual Useraccountof IdUserNavigation { get; set; }
        public virtual ICollection<Wallettof> Wallettofs { get; set; }
    }
}
