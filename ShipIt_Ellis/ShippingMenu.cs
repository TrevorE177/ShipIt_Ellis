using System.ComponentModel;
using System.Threading;

namespace ShipIt_Ellis
{
    public static class ShippingMenu
    {
        public static void Menu(Shipper Warehouse)
        {
            for(int i = 0;i < 8; i++) // this means while i is "__", do the loop? Do I even need anything inside the parentheses then?
                // not checking for value right? or is that what the "option" is
            {
                Console.Clear();
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("------------------------------------------");
                Display("1", "Add a bicycle to the shipment.");
                Display("2", "Add a lawn mower to the shipment.");
                Display("3", "Add a baseball glove to the shipment.");
                Display("4", "Add crackers to the shipment.");
                Display("5", "View list of shipping items.");
                Display("6", "Display total shipping cost of items.");
                Display("7", "Exit program.");

                string option = Console.ReadLine();

                if (option == "1")
                {
                    // add bicycle
                    Bicycle newBicycle = new Bicycle();
                    Warehouse.Add(newBicycle);
                    Console.WriteLine("Bicycle was added.");
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    // for plurality: if (newBicycle >= 1) { Console.WriteLine("Bicycles"); } else () { Console.WriteLine("Bicycle");
                }
                else if (option == "2")
                {
                    // add lawn mower
                    LawnMower newLawnMower = new LawnMower();
                    Warehouse.Add(newLawnMower);
                }
                else if (option == "3")
                {
                    // add baseball glove
                    BaseballGlove newBaseballGlove = new BaseballGlove();
                    Warehouse.Add(newBaseballGlove);
                }
                else if (option == "4")
                {
                    // add crackers
                    Crackers newCrackers = new Crackers();
                    Warehouse.Add(newCrackers);
                }
                else if (option == "5")
                {
                    // display list of items
                    foreach (var newItem in Inventory) // "Inventory does not exist in current context"
                    {
                        Console.WriteLine(newItem);
                    }
                    // a way to display the sum of each item instead of a list of all
                }
                else if (option == "6")
                {
                    // display total shipping cost
                    double listTotal = Inventory.Sum(newItem => ShipCost); // "ShipCost does not exist in current context"
                    Console.WriteLine("The total shipping cost for this order is: " + listTotal); // do I need to use "M" here for rounding?
                }
                else if (option == "7")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error, please choose a valid option...");
                    Thread.Sleep(2000);
                }
            }
        }

        public static void Display(string prefix, string message)
        {
            Console.Write("[");
            Console.Write(prefix);
            Console.WriteLine("] " + message);
        }
    }
}
