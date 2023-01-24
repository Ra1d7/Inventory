namespace Inventory
{
    internal class Customer
    {
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string productsBought { get; set; }
        public string amountBought { get; set; }
        public Customer(string name, string phoneNumber, string email, string productsBought, string amountBought)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.productsBought = productsBought;
            this.amountBought = amountBought;
        }
        public Customer(string name, string email, string productsBought, string amountBought)
        {
            this.name = name;
            this.email = email;
            this.productsBought = productsBought;
            this.amountBought = amountBought;
        }
        public Customer(string name, string productsBought, string amountBought)
        {
            this.name = name;
            this.productsBought = productsBought;
            this.amountBought = amountBought;
        }
    }
}
