using System;
using System.Collections.Generic;
using System.Text;
class SwitchGoto
{
    static void Main9()
    {
        int totalBill = 0;
    Start:  //Labels for goto
        Console.WriteLine("Enter Your Choice of Pizza");
        Console.WriteLine("\r R for Regular \n M for Medium \n L for Large");
        string choice = Console.ReadLine();
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
                goto Start;

        }

    again:
        Console.WriteLine("Do you want more? Yes or No");
        string again = Console.ReadLine();
        switch (again.ToUpper())
        {
            case "YES":
            case "Y":
                goto Start;
            case "NO":
            case "N":
                break;
            default:
                Console.WriteLine("You have Entered {0}. Please Choose Correct Option.", again);
                goto again;
        }
        Console.WriteLine("Your Total Bill is {0}", totalBill);
        Console.WriteLine("Thank You for Shopping!");
    }
}

