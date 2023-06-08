using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public abstract class Animal
    {
        public string Name { get; set; }

       

        public int Inventory { get; set; } = 5;

        public Animal (string name, int inventory)
        {
            Name = name;
            Inventory = inventory;
        }
    }
}
