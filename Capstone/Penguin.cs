﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public  class Penguin: Animal
    {


        public string AnimalType { get; set; }

       

        public Penguin (string name, int inventory, string slotLocation, double price,  string animalType)
             : base(name, inventory, slotLocation, price)
        {

            AnimalType = animalType;
         

        }

    }
}
