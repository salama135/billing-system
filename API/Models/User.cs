using billing_system.API.Models.Enums;
using System;

namespace billing_system.API.Models
{
    // user 1..n address 
    // 1       n
    // 1       1

    public class User : Entity
    {
        public string name;
        public UserType userType;
        public DateTime birthdate;
    }
}
