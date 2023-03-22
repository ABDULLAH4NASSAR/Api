using System;
using System.Collections.Generic;

#nullable disable

namespace FreelanceProject.Core.Data
{
    public partial class Wallettof
    {
        public decimal Id { get; set; }
        public decimal? Amountinwallet { get; set; }
        public decimal? Id_Paymentmethod { get; set; }

        public virtual Paymentmethodof IdPaymentmethodNavigation { get; set; }
    }
}
