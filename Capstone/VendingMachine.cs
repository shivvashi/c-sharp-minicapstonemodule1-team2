using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {

        public double CurrentMoneyProvided { get; set; } = 0;

        public double MoneyGiven {get; set;}

        public double FeedMoney(double money)
        {
            CurrentMoneyProvided += money;

            return CurrentMoneyProvided;
        }

    }
}
