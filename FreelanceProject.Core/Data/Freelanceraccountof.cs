using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Freelanceraccountof
    {
        public Freelanceraccountof()
        {
            Educationfreelanerofs = new HashSet<Educationfreelanerof>();
            Experiencefreelanerofs = new HashSet<Experiencefreelanerof>();
            Paymentmethodofs = new HashSet<Paymentmethodof>();
            Publicationsfreelanerofs = new HashSet<Publicationsfreelanerof>();
            Qualificationsfreelanerofs = new HashSet<Qualificationsfreelanerof>();
            Reviewsofs = new HashSet<Reviewsof>();
            Testomonialfreelancers = new HashSet<Testomonialfreelancer>();
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
        public string Facebooklink { get; set; }
        public string Linkedinlink { get; set; }
        public string Twitterlink { get; set; }
        public string Describeyourself { get; set; }
        public string Languge { get; set; }
        public string Resumee { get; set; }
        public decimal? Id_Cat { get; set; }
        public decimal? Id_Login { get; set; }

        public virtual Categoryof IdCatNavigation { get; set; }
        public virtual Loginof IdLoginNavigation { get; set; }
        public virtual ICollection<Educationfreelanerof> Educationfreelanerofs { get; set; }
        public virtual ICollection<Experiencefreelanerof> Experiencefreelanerofs { get; set; }
        public virtual ICollection<Paymentmethodof> Paymentmethodofs { get; set; }
        public virtual ICollection<Publicationsfreelanerof> Publicationsfreelanerofs { get; set; }
        public virtual ICollection<Qualificationsfreelanerof> Qualificationsfreelanerofs { get; set; }
        public virtual ICollection<Reviewsof> Reviewsofs { get; set; }
        public virtual ICollection<Testomonialfreelancer> Testomonialfreelancers { get; set; }
    }
}
