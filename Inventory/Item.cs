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

        public Item(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        internal object GetProperty(int index)
        {
            switch (index)
            {
                case 0: return id;
                case 1: return name;
                case 2: return price;
                case 3: return inStock;
                case 4: return reOrdered;
                case 5: return Discounted;
            }
            return null;
        }
    }
}
