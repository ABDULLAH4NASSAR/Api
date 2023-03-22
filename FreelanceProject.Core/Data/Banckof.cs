using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Banckof
    {
        public decimal Id { get; set; }
        public decimal Cardnumber { get; set; }
        public string Cardholdername { get; set; }
        public decimal Cvv { get; set; }
        public decimal Amount { get; set; }
        public DateTime Expirydate { get; set; }
    }
}
