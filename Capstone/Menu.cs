using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone
{
    public class Menu

    {
        
        public void DisplayItem()
        {
            string directory = @"C:\Users\Student\workspace\c-sharp-minicapstonemodule1-team2\";
            string fileName = "vendingmachine.csv";
            string fullPath = Path.Combine(directory, fileName);

           using (StreamReader sr = new StreamReader(fullPath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
        public void DisplayOptions()
        {
            Console.WriteLine($"Please Pick a number option");
            Console.WriteLine($"(1) Display Vending Machine Items");
            Console.WriteLine($"(2) Purchase");
            Console.WriteLine($"(3) Exit");
        }

        public void DisplayPurchaseOptions()
        {
            Console.WriteLine($"Please Pick a number option");
            Console.WriteLine($"Current Money Provided:");
            Console.WriteLine($"(1) Feed Money");
            Console.WriteLine($"(2) Select Product");
            Console.WriteLine($"(3) Finish Transaction");
        }

        public int ParseUserChoice()
        {
            
           
            int result = 0;
            while (result == 0)
            {
               string userInput = (Console.ReadLine());
                bool success = int.TryParse(userInput, out result);
                if (!success)
                {
                    Console.WriteLine($"Please try again to enter a number");
                }

            }
            return result;
           
        }
    }
}
// menu.DisplayOptions();

// string userInput = "";
//int result = 0;
//while (result == 0)
//{
//    userInput = (Console.ReadLine());
//    bool success = int.TryParse(userInput, out result);
//    if (!success)
//    {
//        Console.WriteLine($"Please try again to enter a number");
//    }

//}

//if (userInput == "1")
//{
//    menu.DisplayItem();
//    Console.WriteLine();



//string userInput2 = "";
//int result2 = 0;
//while (result2 == 0)
//{
//    userInput2 = (Console.ReadLine());
//    bool success = int.TryParse(userInput2, out result2);
//    if (!success)
//    {
//        Console.WriteLine($"Please try again to enter a number");
//    }

//}