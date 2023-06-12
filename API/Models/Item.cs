using billing_system.API.Models.Enums;

namespace billing_system.API.Models
{
    public class Item : Entity
    {
        public string title;
        public float price;
        public ItemType type;
        public int stock;
    }
}
