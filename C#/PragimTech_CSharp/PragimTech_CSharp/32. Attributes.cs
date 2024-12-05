using System;
using System.Collections.Generic;

namespace Attributes
{
    class Attributes
    {
        public static void Main32()
        {
            List<int> la = new List<int>() { 9,10};
            int[] a =new int[2];
            a[0] = 7;
            a[1] = 8;
            Console.WriteLine(Calculator.Add(new List<int>() { 5, 6 }));
            Console.WriteLine(Calculator.Add(new List<int>() { a[0], a[1]}));
            Console.WriteLine(Calculator.Add(la));

        }
    }

    class Calculator
    {
        [Obsolete("Use public static int Add(List<int> a)")]
        public static int Add(int a, int b)
        {
            return a + b;
        }
        [Obsolete("Use public static int Add(List<int> a)")] 
        public static int Add(params int[] a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            return sum;
        }

        public static int Add(List<int> a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            return sum;
        }
    }

}
