using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {

        public double CurrentMoneyProvided { get; set; } = 0;

        public void FeedMoney()
        {
            Console.WriteLine($"Insert dollar bills of $1,$5,$10,$20");

            string moneyFed = Console.ReadLine();
            double money = double.Parse(moneyFed);
            CurrentMoneyProvided += money;
            Console.WriteLine($"Current money provided: ${this.CurrentMoneyProvided}");
           

            
        }

    }
}
