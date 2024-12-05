using System;
using System.Collections.Generic;
using System.Text;

namespace BreakContinue
{

    class BreakContinue
    {
        static void Main13()
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(i + " ");
                if (i == 10)
                    break;
            }
            Console.WriteLine("");
            for (int i = 0; i <= 20; i++)
            {

                if (i % 2 == 1)
                    continue;

                Console.Write(i + " ");
            }
        }
    }
}
