using System;
using System.Collections.Generic;
using System.Text;
namespace Method
{

    class Method
    {
        static void Main14()
        {
            Method m = new Method();

            Console.WriteLine("Enter the number of Even Numbers-");
            int n = Convert.ToInt32(Console.ReadLine());
            EventNumbers(n);
            //or  Method.EventNumbers(n) if from different class;
            Console.WriteLine("\n");
            m.OddNumbers(n);
        }
        public static void EventNumbers(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public void OddNumbers(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }

}