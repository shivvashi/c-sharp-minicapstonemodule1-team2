using System;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)

        {
            Menu menu = new Menu();
            menu.DisplayOptions();

            string userInput = "";
            int result = 0;
            while (result == 0)
            {
                userInput = (Console.ReadLine());
                bool success = int.TryParse(userInput, out result);
                if (!success)
                {
                    Console.WriteLine($"Please try again to enter a number");
                }

            }
           
            if (userInput == "1")
            {
                menu.DisplayItem();
            }
            if (userInput == "2")
            {
                menu.DisplayPurchaseOptions();
            }
            
        }
    }
}
