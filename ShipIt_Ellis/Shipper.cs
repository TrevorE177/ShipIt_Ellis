using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipIt_Ellis
{
    public class Shipper
    {
         List<IShippable> Inventory = new List<IShippable>();
         public void Add(IShippable newItem)
         {
             newItem = Product; // Why does this not receive the name from the "item" classes through the interface?
             Inventory.Add(newItem);
         }
    }
}



// trying to test if items are being added correctly/possible replacement for function above

        //List<IShippable> Inventory;

        //public void Add(IShippable newItem)
        //{
        //    if (Inventory == null)
        //    {
        //        Inventory = new List<IShippable>();
        //    }

        //    Inventory.Add(newItem);

        //    foreach (IShippable product in Inventory)
        //    {
        //        Console.WriteLine(Product);
        //    }
        //}

