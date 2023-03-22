using System;
using System.Collections.Generic;

#nullable disable

namespace School.Core.Data
{
    public partial class Enduser
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Enail { get; set; }
        public decimal? MedecinOrder { get; set; }

        public virtual MedecinOrder MedecinOrderNavigation { get; set; }
    }
}
