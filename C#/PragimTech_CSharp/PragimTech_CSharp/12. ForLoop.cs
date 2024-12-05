using System;
using System.Collections.Generic;
using System.Text;

namespace ForLoop
{
    class ForLoop
    {
        static void Main12()
        {
            int i = 0, ii = 0;
            int[] evenNums = new int[3];
            evenNums[0] = 0;
            evenNums[1] = 2;
            evenNums[2] = 4;

            for (int j = 0; j <= evenNums.Length - 1; j++)
            {
                Console.WriteLine("For --> In {0}th position {1}", j, evenNums[j]);
            }
            while (i < evenNums.Length)
            {
                Console.WriteLine("While --> In {0}th position {1}", i, evenNums[i]);
                i++;
            }
            foreach (int k in evenNums)
            {
                Console.WriteLine("For Each --> In {0}th position {1}", ii, k);
                ii++;
            }
        }
    }
}
