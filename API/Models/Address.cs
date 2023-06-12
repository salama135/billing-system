using System;
using System.Collections.Generic;
using System.Text;

namespace billing_system.API.Models
{
    public class Address : Entity
    {
        public int userId;
        public string street;
        public string postalCode;
        public string city;
        public string Country;
    }
}
