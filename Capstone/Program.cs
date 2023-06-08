using System;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)

        {  
            Menu menu = new Menu();
            menu.DisplayOptions();
            int userChoice = menu.ParseUserChoice();
            if (userChoice == 1)
            {
                menu.DisplayItem();
                Console.WriteLine();


            }
         
            menu.DisplayOptions();
            userChoice =menu.ParseUserChoice();

            if (userChoice == 2)
            {

                menu.DisplayPurchaseOptions();
            }
            else if(userChoice == 1)
            {
                menu.DisplayItem();

            }
            VendingMachine vendingMachine = new VendingMachine();

            //vendingMachine.MoneyGiven = Console.ReadLine();

            Console.WriteLine($"Insert dollar bills of $1,$5,$10,$20");

            string moneyFed = Console.ReadLine();
            double Money = double.Parse(moneyFed);
            vendingMachine.FeedMoney(Money);
            Money = vendingMachine.CurrentMoneyProvided;
            //while()
            Console.WriteLine($"Current money provided: ${Money}");
            menu.DisplayPurchaseOptions();

            









        }
    }
}
