using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace Capstone
{
    public class VendingMachine
    {

        public decimal CurrentMoneyProvided { get; set; } = 0;

        public string Slot { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public Dictionary<string, Animal> Items = new Dictionary<string, Animal>();

        

        public void FeedMoney()
        {
            Console.WriteLine($"Insert dollar bills of $1,$5,$10,$20");

            string moneyFed = Console.ReadLine();
            decimal money = Convert.ToDecimal(moneyFed);
            CurrentMoneyProvided += money;
            Console.WriteLine($"Current money provided: ${this.CurrentMoneyProvided}");
            string logMessage = $"{DateTime.Now} FEED MONEY: ${money} ${CurrentMoneyProvided}";
            LogPurchase(logMessage);




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
                        Duck duck = new Duck(newArray[3], 5, newArray[0], Convert.ToDecimal(newArray[2]), newArray[1], "Quack, Quack, Splash!");
                        
                        

                        Items[newArray[0]] =duck;
                         
                    }
                    if (newArray[3] == "Pony")
                    {

                        Pony pony = new Pony(newArray[3],5, newArray[0], Convert.ToDecimal(newArray[2]), newArray[1], "Neigh, Neigh, Yay!");


                        Items[newArray[0]] = pony;
                    }
                    if (newArray[3] == "Cat")
                    {
                        Cat cat = new Cat (newArray[3], 5, newArray[0], Convert.ToDecimal(newArray[2]), newArray[1], "Meow,Meow,Meow!");


                        Items[newArray[0]] = cat;
                    }
                    if (newArray[3] == "Penguin")
                    {
                        Penguin penguin = new Penguin (newArray[3], 5, newArray[0], Convert.ToDecimal(newArray[2]), newArray[1], "Squawk, Squawk, Whee!");


                        Items[newArray[0]] = penguin;
                    }
                    
                }
                return Items;
            }
         
        }
        public void Dispensing(Animal animal)
        {
            CurrentMoneyProvided = CurrentMoneyProvided - animal.Price;
            animal.Inventory -= 1;
            Console.WriteLine($"Dispensing {animal.Name}, Cost: ${animal.Price}, Total money remaining: ${CurrentMoneyProvided}");
            Console.WriteLine(animal.Message);
            string logMessage = $"{DateTime.Now} {animal.Name} {animal.Price} {CurrentMoneyProvided}$";
            LogPurchase(logMessage);

        }
        public void FinishTraction()
        {
            
            double totalQuarters = 0;
            double totalDimes = 0;
            double totalNickles = 0;
            while (CurrentMoneyProvided > 0.0m)
            {
                if (CurrentMoneyProvided>= 0.25m)
                {
                    CurrentMoneyProvided -= 0.25m;
                    totalQuarters += 1;
                   
                }
                else if (CurrentMoneyProvided < 0.25m && CurrentMoneyProvided >= .10m)
                {
                    CurrentMoneyProvided -= 0.10m;
                    totalDimes += 1;
                   

                }
                else if (CurrentMoneyProvided == 0.05m)
                {
                    CurrentMoneyProvided -= 0.05m;
                    totalNickles += 1;
                   

                }
            }
            Console.WriteLine($"Dispensing {totalQuarters} Quaters, {totalDimes} Dimes, {totalNickles} Nickles");
            string logMessage = $"{DateTime.Now} GIVE CHANGE: ${CurrentMoneyProvided}";
            LogPurchase(logMessage);

        }
        public void LogPurchase (string logMessage)
        {
            string directory = @"C:\Users\Student\workspace\c-sharp-minicapstonemodule1-team2\Capstone\";
            string fileName = "Log.txt";
            string fullPath = Path.Combine(directory, fileName);

            using (StreamWriter sw = new StreamWriter(fullPath, true))
            {
                sw.WriteLine(logMessage);
            }
        }
    }
}
