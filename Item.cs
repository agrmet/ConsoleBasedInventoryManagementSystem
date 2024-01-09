namespace ConsoleBasedInventoryManagementSystem
{

    class Item
    {
        public string name;
        public double price;
        public string category;
        public int quantity;
        public Item(string name, double price, string category, int quantity)
        {
            this.name = name;
            this.price = price;
            this.category = category;
            this.quantity = quantity;
        }
    }
}