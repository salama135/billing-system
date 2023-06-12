using System;
using System.Collections.Generic;
using System.Text;

namespace billing_system.API.Models
{
    // bill n..1 user 
    // 1       1
    // n       1

    // bill 1..1 order 
    // 1       1
    // 1       1

    // bill 1..1 payment 
    // 1       1
    // 1       1

    // AKA invoice 
    public class Bill : Entity
    {
        public int userId; // is this redundent ?
        public int orderId;
        public int paymentId;
    }
}
