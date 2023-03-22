using System;
using System.Collections.Generic;

#nullable disable

namespace School.Core.Data
{
    public partial class Homepage
    {
        public decimal Id { get; set; }
        public string Logo { get; set; }
        public string Maintext { get; set; }
        public string Categorytext { get; set; }
        public string Producttext { get; set; }
        public string Testimonialtext { get; set; }
        public string Contacttext { get; set; }
    }
}
