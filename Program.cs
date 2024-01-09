namespace ConsoleBasedInventoryManagementSystem;

class Program
{
    private static List<string> mainMenuOptions = ["Show inventory", "Add new item", "Edit item", "Remove item"];

    private static void PrintOptions(List<string> options)
    {
        int index = 1;
        foreach (string option in options)
        {
            Console.WriteLine($"{Environment.NewLine}{index}. {option}");
            index++;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello and welcome to your inventory! What would you like to do today?");
        PrintOptions(mainMenuOptions);

        // Game loop for decision-making within the console application
        Console.WriteLine("Press Q to quit or backstep in the menu");
        while (true)
        {
            ConsoleKey pressedKey = Console.ReadKey().Key;

            if (pressedKey == ConsoleKey.Q)
            {
                break;
            }
        }
    }
}
