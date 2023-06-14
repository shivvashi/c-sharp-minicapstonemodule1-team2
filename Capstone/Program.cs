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
           userChoice= menu.ValadateChoice(userChoice);

            while (userChoice == 1)
            {
                menu.DisplayItem();
                Console.WriteLine();
                menu.DisplayOptions();
                userChoice = menu.ParseUserChoice();
                userChoice = menu.ValadateChoice(userChoice);

            }
        

            if (userChoice == 2)
            {

                menu.DisplayPurchaseOptions(vendingMachine.CurrentMoneyProvided);
                userChoice = menu.ParseUserChoice();
                userChoice = menu.ValadateChoice(userChoice);
                while (userChoice == 1)
                {
                    vendingMachine.FeedMoney();
                    menu.DisplayPurchaseOptions(vendingMachine.CurrentMoneyProvided);
                    userChoice = menu.ParseUserChoice();
                    userChoice = menu.ValadateChoice(userChoice);
                }
                while (userChoice == 2)
                {
                    menu.DisplayItem();
                   
                    Console.WriteLine();
                    Console.WriteLine($"Please enter code to choose your item.");
                    string itemChoice = Console.ReadLine().ToUpper();
       
                    if (itemList.ContainsKey(itemChoice) == false)
                    {
                        Console.WriteLine($"Please try again.");
                        menu.DisplayPurchaseOptions(vendingMachine.CurrentMoneyProvided);
                        userChoice = menu.ParseUserChoice();
                        userChoice = menu.ValadateChoice(userChoice);


                    }
                    else
                    {
                        Animal valueKey =(itemList[itemChoice]);
                     
                        if (valueKey.Inventory == 0)
                        {
                            Console.WriteLine($"Please try again, item is sold out.");
                            menu.DisplayPurchaseOptions(vendingMachine.CurrentMoneyProvided);
                            userChoice = menu.ParseUserChoice();
                            userChoice = menu.ValadateChoice(userChoice);


                        }
                        else if (valueKey.Price > vendingMachine.CurrentMoneyProvided)
                        {
                            Console.WriteLine($"Please try again, insufficient funds. Please try again.");
                            menu.DisplayPurchaseOptions(vendingMachine.CurrentMoneyProvided);
                            userChoice = menu.ParseUserChoice();
                            userChoice = menu.ValadateChoice(userChoice);
                        }
                        else
                        {
                            vendingMachine.Dispensing(valueKey);
                            itemList[itemChoice] = valueKey;
                            menu.DisplayPurchaseOptions(vendingMachine.CurrentMoneyProvided);
                            userChoice = menu.ParseUserChoice();
                            userChoice = menu.ValadateChoice(userChoice);
                        }
                        
                    }


                }
                while (userChoice == 3)
                {
                    
                    vendingMachine.FinishTraction();
                    menu.DisplayOptions();
                    userChoice = menu.ParseUserChoice();
                    userChoice = menu.ValadateChoice(userChoice);
                }

            }
         
            
     















        }
    }
}
