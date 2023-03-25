using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Useraccountof
    {
        public Useraccountof()
        {
            Paymentmethodofs = new HashSet<Paymentmethodof>();
            Postprojectofs = new HashSet<Postprojectof>();
            Reviewsofs = new HashSet<Reviewsof>();
            Testimonialofs = new HashSet<Testimonialof>();
        }

        public decimal Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal? Phonenumber { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Imagetwo { get; set; }
        public DateTime? Birthdate { get; set; }
        public decimal? Id_Login { get; set; }
        public decimal? id_bank { get; set; }

        public virtual Loginof IdLoginNavigation { get; set; }
        public virtual ICollection<Paymentmethodof> Paymentmethodofs { get; set; }
        public virtual ICollection<Postprojectof> Postprojectofs { get; set; }
        public virtual ICollection<Reviewsof> Reviewsofs { get; set; }
        public virtual ICollection<Testimonialof> Testimonialofs { get; set; }
    }
}
