using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Animal
    {
        public string Name { get; set; }

        public string SlotLocation { get; set; }

        public decimal Price { get; set; }

        public int Inventory { get; set; }

        public string Message { get; set; }

        public Animal (string name, int inventory, string slotLocation, decimal price,string message)
        {
            Name = name;
            Inventory = inventory;
            SlotLocation = slotLocation;
            Price = price;
            Message = message;
        }
    }
}
