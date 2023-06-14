using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Pony: Animal
    {
        public string AnimalType { get; set; }

    

     

        public Pony(string name, int inventory, string slotLocation, decimal price, string animalType,string message)
            : base(name, inventory,slotLocation,price,message)
        {

            AnimalType = animalType;
         

        }
    }
}
