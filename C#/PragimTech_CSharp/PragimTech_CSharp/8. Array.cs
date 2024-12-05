using System;
using System.Collections.Generic;
using System.Text;
class Array
{
    static void Main8()
    {
        int[] evenNums =new int[3];
        evenNums[0] = 0;
        evenNums[1] = 2;
        evenNums[2] = 4;

        Console.WriteLine("1st number is {0}", evenNums[0]);

        for (int i = 0; i <= evenNums.Length - 1; i++)
        {
            Console.WriteLine("In {0}th position {1}",i+1, evenNums[i]);
        }
    }
}

