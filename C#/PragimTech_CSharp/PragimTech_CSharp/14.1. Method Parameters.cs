using System;
using System.Collections.Generic;
using System.Text;
namespace MethodParameters
{

    class MethodParameters
    {
        static void Main141()
        {
            int[] arr = new int[3];
            arr[0] = 98;
            arr[1] = 89;
            arr[2] = 79;

            int i = 10, j = 9, k = 1, s = 0;
            float f = 0.0f;
            valueParam(i);
            Console.WriteLine("Main 1 - {0}", i);
            valueRef(ref i);
            Console.WriteLine("Main 2 - {0}", i);
            f = outParameter(i, j, out k, out s);
            Console.WriteLine("outParameter from Main -Sum of {0} and {1} is {2} , Product {3} and division {4}", i, j, s, k, f);
            Console.WriteLine("paramsArray");

            Console.WriteLine("---------No parameter---------\n");
            paramsArray();
            Console.WriteLine("---------With parameter---------\n");
            paramsArray(arr);
            Console.WriteLine("---------With number of parameter---------\n");
            paramsArray(1, 2, 3, 4, 5, 67);
            paramsArray2("Swapnadip", 'A', 'B', 'C', 'D', 'E');
        }
        public static void valueParam(int n)
        {
            n++;
            Console.WriteLine("valueParam - {0}", n);
        }
        public static void valueRef(ref int n)
        {
            n++;
            Console.WriteLine("valueRef - {0}", n);
        }
        public static float outParameter(int n, int j, out int prod, out int sum)
        {
            prod = n * j;
            sum = n + j;
            return n / j;

        }

        public static void paramsArray(params int[] numbers)
        {

            int sum = 0;
            Console.WriteLine("paramsArray Number of parameter array - {0}", numbers.Length);
            Console.Write("The numbers are ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            foreach (int i in numbers)
            {
                sum = sum + i;
            }
            Console.WriteLine("\nSum is {0}", sum);
        }

        public static void paramsArray2(string x, params char[] prop)
        {
            Console.WriteLine("paramsArray-2 {0} has the following properties ", x);
            for (int i = 0; i < prop.Length; i++)
            {
                Console.Write(prop[i] + " ");
            }
        }
    }

}