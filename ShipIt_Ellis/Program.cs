using System;
using ShipIt_Ellis;

internal class Program
{
    private static void Main(string[] args)
    {
        Shipper Warehouse = new Shipper();
        ShippingMenu.Menu(Warehouse);
    }
}