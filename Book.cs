

namespace ConsoleBasedInventoryManagementSystem
{
    class Book : Item
    {
        public string genre;
        public string author;

        public Book(string name, double price, string category, int quantity, string genre, string author) : base(name, price, category, quantity)
        {
            this.genre = genre;
            this.author = author;
        }
    }
}