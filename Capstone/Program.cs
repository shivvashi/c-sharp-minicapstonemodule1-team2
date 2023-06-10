using System;
using System.Collections.Generic;

namespace Capstone
{
    class Program
    {
        
        static void Main(string[] args)

        {  
            Menu menu = new Menu();
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.MakingDictionary();
            Dictionary<string, Animal> itemList = vendingMachine.Items;

            menu.DisplayOptions();
            int userChoice = menu.ParseUserChoice();
            while (userChoice == 1)
            {
                menu.DisplayItem();
                Console.WriteLine();
                menu.DisplayOptions();
                userChoice = menu.ParseUserChoice();

            }
        

            if (userChoice == 2)
            {

                menu.DisplayPurchaseOptions(vendingMachine.CurrentMoneyProvided);
                userChoice = menu.ParseUserChoice();
                while (userChoice == 1)
                {
                    vendingMachine.FeedMoney();
                    menu.DisplayPurchaseOptions(vendingMachine.CurrentMoneyProvided);
                    userChoice = menu.ParseUserChoice();
                }
                if (userChoice == 2)
                {
                    menu.DisplayItem();
                    //userChoice = menu.ParseUserChoice();
                    Console.WriteLine();
                    Console.WriteLine($"Please enter code to choose your item.");
                    string itemChoice = Console.ReadLine();
                    if (itemList.ContainsKey(itemChoice) == false)
                    {
                        Console.WriteLine($"Please try again.");
                    }
                    else
                    {
                        Animal valueKey = itemList[itemChoice];
                        Console.WriteLine($"{valueKey}");
                    }


                }

            }
            else if(userChoice == 1)
            {
                menu.DisplayItem();

            }
     















        }
    }
}
