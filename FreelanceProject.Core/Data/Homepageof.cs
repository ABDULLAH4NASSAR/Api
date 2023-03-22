using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Homepageof
    {
        public decimal Id { get; set; }
        public string Logourl { get; set; }
        public string Imageurl { get; set; }
        public string Nameplatform { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Textone { get; set; }
        public string Texttwo { get; set; }
        public string Textthree { get; set; }
        public string Location { get; set; }
        public decimal? Phonenumber { get; set; }
        public string Facebooklink { get; set; }
        public string Instagramlink { get; set; }
        public string Twitter { get; set; }
        public string Whatsapp { get; set; }
    }
}
