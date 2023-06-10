using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Animal
    {
        public string Name { get; set; }

        public string SlotLocation { get; set; }

        public double Price { get; set; }

        public int Inventory { get; set; } = 5;

        public Animal (string name, int inventory, string slotLocation, double price)
        {
            Name = name;
            Inventory = inventory;
            SlotLocation = slotLocation;
            Price = price;
        }
    }
}
