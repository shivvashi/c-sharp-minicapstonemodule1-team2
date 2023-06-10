using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Capstone
{
    public class VendingMachine
    {

        public double CurrentMoneyProvided { get; set; } = 0;

        public string Slot { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public Dictionary<string, Animal> Items = new Dictionary<string, Animal>();

        

        public void FeedMoney()
        {
            Console.WriteLine($"Insert dollar bills of $1,$5,$10,$20");

            string moneyFed = Console.ReadLine();
            double money = double.Parse(moneyFed);
            CurrentMoneyProvided += money;
            Console.WriteLine($"Current money provided: ${this.CurrentMoneyProvided}");
           

            
        }
        public Dictionary<string,Animal> MakingDictionary()
        {
            string directory = @"C:\Users\Student\workspace\c-sharp-minicapstonemodule1-team2\";
            string fileName = "vendingmachine.csv";
            string fullPath = Path.Combine(directory, fileName);

            using (StreamReader sr = new StreamReader(fullPath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] newArray = line.Split("|");
                    if (newArray[3] == "Duck")
                    {
                        Duck duck = new Duck(newArray[3], 5, newArray[0], Double.Parse(newArray[2]), newArray[1]);
                        
                        

                        Items[newArray[0]] =duck;
                         
                    }
                    if (newArray[3] == "Pony")
                    {

                        Pony pony = new Pony(newArray[3],5, newArray[0], Convert.ToDouble(newArray[2]), newArray[1]);


                        Items[newArray[0]] = pony;
                    }
                    if (newArray[3] == "Cat")
                    {
                        Cat cat = new Cat (newArray[3], 5, newArray[0], Convert.ToDouble(newArray[2]), newArray[1]);


                        Items[newArray[0]] = cat;
                    }
                    if (newArray[3] == "Penguin")
                    {
                        Penguin penguin = new Penguin (newArray[3], 5, newArray[0], Convert.ToDouble(newArray[2]), newArray[1]);


                        Items[newArray[0]] = penguin;
                    }
                    
                }
                return Items;
            }
        }

    }
}
