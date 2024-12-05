using System;
using System.Collections.Generic;
using System.Text;

namespace WhileLoop
{
    class DoWhileLoop
    {
        static void Main11()
        {
            int range;
            string choice;
            do
            {
                Console.WriteLine("Enter Your the Target?");
                range = Convert.ToInt32(Console.ReadLine());
                int start = 0;

                while (start <= range)
                {
                    Console.Write(start + " ");
                    start = start + 2;   // If the condition is not here then Infinity Loop
                }

                do
                {
                    Console.WriteLine("\n Do You want to Continue? Y/N");
                    choice = Console.ReadLine();
                    if (choice.ToUpper() != "YES" && choice.ToUpper() != "NO" && choice.ToUpper() != "Y" && choice.ToUpper() != "N")
                    {
                        Console.WriteLine("\n Please Enter a Valid Option");
                    }
                } while (choice.ToUpper() != "YES" && choice.ToUpper() != "NO" && choice.ToUpper() != "Y" && choice.ToUpper() != "N");
            } while (choice.ToUpper() == "YES" || choice.ToUpper() == "Y");
        }
    }

}