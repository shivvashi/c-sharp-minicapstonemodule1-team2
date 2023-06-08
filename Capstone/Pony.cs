using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Pony: Animal
    {
        public string AnimalType { get; set; }

        public string SlotLocation { get; set; }

        public double Price { get; set; }

        public Pony(string name, string slotLocation, double price, int inventory, string animalType)
            : base(name, inventory)
        {

            AnimalType = animalType;
            SlotLocation = slotLocation;
            Price = price;

        }
    }
}
