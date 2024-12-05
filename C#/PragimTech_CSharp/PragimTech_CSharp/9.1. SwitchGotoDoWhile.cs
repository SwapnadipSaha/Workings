using System;
using System.Collections.Generic;
using System.Text;
class SwitchGotoDoWhile
{
    static void Main9_1()
    {

        int totalBill = 0;
       
        string again;
        do
        {
            string choice;
            do
            {
                Console.WriteLine("Enter Your Choice of Pizza");
                Console.WriteLine("\r R for Regular \n M for Medium \n L for Large");
                choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "R":
                        totalBill += 100;
                        break;
                    case "M":
                        totalBill += 150;
                        break;
                    case "L":
                        totalBill += 200;
                        break;
                    default:
                        Console.WriteLine("You have Entered {0}. Please Choose Correct Option.", choice);
                        break;
                }
            } while (choice.ToUpper() != "R" && choice.ToUpper() != "M" && choice.ToUpper() != "L");

            do
            {
                Console.WriteLine("Do you want more? Yes or No");
                again = Console.ReadLine();
                if (again.ToUpper() != "YES" && again.ToUpper() != "Y" && again.ToUpper() != "NO" && again.ToUpper() != "N")
                {
                    Console.WriteLine("You have entered {0}. Please enter Valid Option", again);
                }
            } while (again.ToUpper() != "YES" && again.ToUpper() != "NO" && again.ToUpper() != "Y" && again.ToUpper() != "N");

        } while (again.ToUpper() != "NO" && again.ToUpper() != "N");


        Console.WriteLine("Your Total Bill is {0}", totalBill);
        Console.WriteLine("Thank You for Shopping!");
    }
}

