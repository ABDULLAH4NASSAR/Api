using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Testimonialof
    {
        public decimal Id { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public decimal? Id_User { get; set; }

        public virtual Useraccountof IdUserNavigation { get; set; }
    }
}
