namespace ConsoleBasedInventoryManagementSystem
{
    class Groceries : Item
    {
        public double unitPrice;
        public double weight;
        public string unitType;
        public Groceries(string name, double price, string category, int quantity, double unitPrice, double weight, string unitType) : base(name, price, category, quantity)
        {
            this.unitPrice = unitPrice;
            this.weight = weight;
            this.unitType = unitType;
        }

        public double GetPrice(double weight)
        {
            return unitPrice * weight;
        }

        public string GetUnitType()
        {
            return unitType;
        }

    }
}