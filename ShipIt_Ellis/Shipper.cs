using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipIt_Ellis
{
    public class Shipper
    {
        private List<IShippable> Inventory = new List<IShippable>();
        private int bicycleCount;
        private int lawnMowerCount;
        private int baseBallGloveCount;
        private int crackersCount;
        public void Add(IShippable newItem)
         {
            Inventory.Add(newItem);
            if (newItem.Product.Equals("Bicycle"))
            {
                bicycleCount++;
            }
            if (newItem.Product.Equals("Lawn Mower"))
            {
                lawnMowerCount++;
            }
            if (newItem.Product.Equals("Baseball Glove"))
            {
                baseBallGloveCount++;
            }
            if (newItem.Product.Equals("Crackers"))
            {
                crackersCount++;
            }
        }

        public void List() // (?) if else for items with 0 to omit them in the printed list
        {
            Console.WriteLine("Your Shipment Includes:");
            if (bicycleCount == 1)
            {
                Console.WriteLine(bicycleCount + " Bicycle");
            }
            else if (bicycleCount > 1)
            {
                Console.WriteLine(bicycleCount + " Bicycles");
            }
            else if (bicycleCount == 0)
            {
            }

            if (lawnMowerCount == 1)
            {
                Console.WriteLine(lawnMowerCount + " Lawn Mower");
            }
            else if (lawnMowerCount == 0)
            {
            }
            else if (lawnMowerCount > 1)
            {
                Console.WriteLine(lawnMowerCount + " Lawn Mowers");
            }

            if (baseBallGloveCount == 1)
            {
                Console.WriteLine(baseBallGloveCount + " Baseball Glove");
            }
            else if (baseBallGloveCount == 0)
            {
            }
            else if (baseBallGloveCount > 1)
            {
                Console.WriteLine(baseBallGloveCount + " Baseball Gloves");
            }

            if (crackersCount != 0)
            {
                Console.WriteLine(crackersCount + " Crackers");
            }

            Console.WriteLine();
        }

        public decimal ComputeCosts()
        {

            decimal costs = 0;
            foreach (IShippable item in Inventory)
            {
                costs = costs + item.ShipCost;
            }

            return costs;            
        }
    }
}