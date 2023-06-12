using billing_system.API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace billing_system.API.Models
{
    public class Payment : Entity
    {
        public int amount;
        public PaymentType paymentType;
        public PaymentInfo paymentInfo;
    }
}
