namespace Inventory
{
    internal class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int inStock { get; set; }
        public int reOrdered { get; set; }
        public int Discounted { get; set; }
        public Item(int id, string name, decimal price, int inStock,int reOrdered,int Discounted)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.inStock = inStock;
            this.reOrdered = reOrdered;
            this.Discounted = Discounted;
        }
    }
}
