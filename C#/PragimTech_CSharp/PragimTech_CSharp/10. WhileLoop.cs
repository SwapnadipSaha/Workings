using System;
using System.Collections.Generic;
using System.Text;
namespace WhileLoop
{

    class WhileLoop
    {
        static void Main10()
        {
            //MY
            Console.WriteLine("Enter Your the Target?");
            int range = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            Console.WriteLine("The even Numbers are ");
            while (j <= range)
            {
                j += 2;
                Console.WriteLine(j - 2);
            }

            Console.WriteLine("----------Pragim-------------");
            int start = 0;
            while (start <= range)
            {
                Console.Write(start + " ");
                start = start + 2;   // If the condition is not here then Infinity Loop
            }
        }
    }

}