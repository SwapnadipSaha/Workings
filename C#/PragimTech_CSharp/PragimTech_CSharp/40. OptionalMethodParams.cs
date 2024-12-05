using System.Runtime.InteropServices;

namespace OptionalMethodPrama
{
    public class OptionalMethodPrama
    {
        public static void Main40()
        {
            //-----------------------4.	Optional Keyword-------------------------------------

            int[] n = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            AddNumbers(0, 0, n);                                    // Output 55
            //AddNumbers(11, 12, 13, 14, 15, 16, 17, 18, 19, 20);     // Output 155            
            AddNumbers(55, 101, null);                              // Output 156
            AddNumbers(55, 155);                                    // Output 210
            AddNumbers(55, 155, new int[] { 15, 15, 15 });          // Output 255

            Test(1, 2);
            Test(1, c: 2);

        }

        //-----------------------1.	Use parameter arrays------------------------------
        //public static void AddNumbers(int FirstNumber, int SecondNumber, params int[] numbers)
        //{
        //    int? sum = FirstNumber + SecondNumber;
        //    if (sum != null)
        //    {
        //        if (numbers != null)
        //            foreach (int i in numbers)
        //            {
        //                sum = sum + i;
        //            }
        //    }
        //    Console.WriteLine("\nSum is {0}", sum);
        //}




        ////-----------------------2.	Method Overloading------------------------------

        //public static void AddNumbers(int FirstNumber, int SecondNumber, int[] numbers)
        //{
        //    int? sum = FirstNumber+ SecondNumber;
        //    if (sum != null)
        //    {
        //        if (numbers != null)
        //        {
        //            foreach (int i in numbers)
        //            {
        //                sum = sum + i;
        //            }

        //        }
        //        Console.WriteLine("\nSum is {0}", sum);
        //    }
        //}

        //public static void AddNumbers(int FirstNumber, int SecondNumber)
        //{
        //    int? sum = FirstNumber + SecondNumber;
        //    if (sum != null)
        //    {
        //        Console.WriteLine("\nSum is {0}", sum);
        //    }
        //}

        //-----------------------3.	Specifying parameter defaults------------------------------

        //public static void AddNumbers(int FirstNumber, int SecondNumber, int[] FourthNumbers = null)
        //{
        //    int? sum = FirstNumber + SecondNumber;
        //    if (sum != null)
        //    {
        //        if (FourthNumbers != null)
        //        {
        //            foreach (int i in FourthNumbers)
        //            {
        //                sum = sum + i;
        //            }

        //        }
        //        Console.WriteLine("\nSum is {0}", sum);
        //    }
        //}

        //-----------------------4.	Optional Keyword------------------------------

        public static void AddNumbers(int FirstNumber, int SecondNumber,[Optional] int[] FourthNumbers)
        {
            int? sum = FirstNumber + SecondNumber;
            if (sum != null)
            {
                if (FourthNumbers != null)
                {
                    foreach (int i in FourthNumbers)
                    {
                        sum = sum + i;
                    }

                }
                Console.WriteLine("\nSum is {0}", sum);
            }
        }

        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine("a =" + a);
            Console.WriteLine("b =" + b);
            Console.WriteLine("c =" + c);
        }
         
    }
}
