using System;

namespace ConsoleReadWrite
{
    class ConsoleReadWrite
    {
        static void Main2()
        {
            Console.WriteLine("Enter Name");
            string x = Console.ReadLine();
            Console.WriteLine("Your Name is " + x);
            Console.WriteLine("Your Name is {0}", x);

            Console.WriteLine("First Name");
            string fn = Console.ReadLine();

            Console.WriteLine("Last Name");
            string ln = Console.ReadLine();

            Console.WriteLine("Your Name is " + fn + " " + ln);
            Console.WriteLine("Your Name is {0} {1}", fn, ln);
        }
    }

}

