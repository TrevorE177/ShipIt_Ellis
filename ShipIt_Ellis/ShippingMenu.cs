using System.ComponentModel;
using System.Threading;

namespace ShipIt_Ellis
{
    public static class ShippingMenu
    {
        public static void Menu(Shipper Warehouse)
        {
            int loop = 1;
            while(loop == 1)
            {
                Console.Clear();
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("------------------------------------------");
                Display("1", "Add a bicycle to the shipment");
                Display("2", "Add a lawn mower to the shipment");
                Display("3", "Add a baseball glove to the shipment");
                Display("4", "Add crackers to the shipment");
                Display("5", "View list of shipping items");
                Display("6", "Display total shipping cost of items");
                Display("7", "Exit program");
                Console.WriteLine();

                string option = Console.ReadLine();

                if (option == "1")
                {
                    // add bicycle
                    Bicycle newBicycle = new Bicycle();
                    Warehouse.Add(newBicycle);
                    Console.Clear();
                    Console.WriteLine("Bicycle was added");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == "2")
                {
                    // add lawn mower
                    LawnMower newLawnMower = new LawnMower();
                    Warehouse.Add(newLawnMower);
                    Console.Clear();
                    Console.WriteLine("Lawn Mower was added");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == "3")
                {
                    // add baseball glove
                    BaseballGlove newBaseballGlove = new BaseballGlove();
                    Warehouse.Add(newBaseballGlove);
                    Console.Clear();
                    Console.WriteLine("Baseball glove was added");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == "4")
                {
                    // add crackers
                    Crackers newCrackers = new Crackers();
                    Warehouse.Add(newCrackers);
                    Console.Clear();
                    Console.WriteLine("Crackers were added");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == "5")
                {
                    // display list of items in shipment
                    Console.Clear();
                    Warehouse.List();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == "6")
                {
                    // display total shipping cost
                    Console.Clear();
                    decimal shippingTotal = Warehouse.ComputeCosts();
                    Console.WriteLine("The total shipping cost for this order is: $" + shippingTotal);
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == "7")
                {
                    // end program
                    Console.WriteLine();
                    loop = 0;
                }
                else
                {
                    // default
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
