using System;
using System.Collections.Generic;
using System.Text;

namespace billing_system.API.Models
{
    public abstract class Entity
    {
        private int id;
        private DateTime createdAt;
        private DateTime updatedAt;
        private DateTime createdBy;
        private DateTime updatedBy;
        private bool deleted;

        public int Id { get => id; set => id = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
        public DateTime CreatedBy { get => createdBy; set => createdBy = value; }
        public DateTime UpdatedBy { get => updatedBy; set => updatedBy = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
    }
}
