using billing_system.API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace billing_system.API.Models
{

    // order n..n item 
    // 1        n
    // n        1
    // needs brakdown 

    // order n..1 user 
    // 1        1
    // n        1

    public class Order : Entity
    {
        public int userId;
        public int addressId;
        public OrderStatus orderStatus;
    }
}
