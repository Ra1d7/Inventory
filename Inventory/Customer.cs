using System.Diagnostics;

namespace Inventory
{
    internal class Customer
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string productsBought { get; set; }
        public string amountBought { get; set; }
        public Customer(int id,string name, string phoneNumber, string email, string productsBought, string amountBought)
        {
            Id= id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.productsBought = productsBought;
            this.amountBought = amountBought;
        }
        public Customer(int id,string name, string productsBought, string amountBought)
        {
            Id = id;
            this.name = name;
            this.productsBought = productsBought;
            this.amountBought = amountBought;
        }
        internal object GetProperty(int index)
        {
            switch (index)
            {
                case 0: return Id;
                case 1: return name;
                case 2: return phoneNumber;
                case 3: return email;
                case 4: return productsBought;
                case 5: return amountBought;
            }
            return null;
        }
    }
}
