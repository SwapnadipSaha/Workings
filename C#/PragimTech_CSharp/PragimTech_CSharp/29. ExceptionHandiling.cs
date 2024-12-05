using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System.Runtime.Serialization;

namespace ExceptionHandiling
{
    class ExceptionHandiling
    {
        public static void Main29()
        {
            try
            {
                string[] newArray = new string[3];

                newArray[0] = "Swa";
                newArray[1] = "Element 2";
                newArray[2] = "Element 3";
                newArray[3] = "Element 4";
            }

            //or this can be done

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("The exception is " + ex.Message);
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);

            }
            catch (Exception ex) // Here it throws "Index was outside the bounds of the array."  This should be the last one if there are more than exception catch blocks. All the exeptions will be catch here. If there are more than one catch blocks, and the exception is already catches by one of the catch block, then the general exception block will not work.
            {
                Console.WriteLine("The exception is " + ex.Message);
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }

        }

    }
    class InnerException
    {
        public static void Main291()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First Number");
                    int fn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    int sn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sum is {0} ", fn + sn);

                }
                catch (Exception ex)
                {

                    string hostName = Dns.GetHostName();   //for HostName
                    IPAddress ipAddresses = Dns.GetHostAddresses(hostName).FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork); ;    //for IP Address

                    string filePath = @"D:\472124\T Factor New\PragimTech\Module 2\1. C# Tutorial for Beginners\PragimTech1 csharp\PragimTech csharp\Contents\LogFile.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath, true);   // true will append. Only filepath will rewrite
                        sw.WriteLine();
                        sw.WriteLine(DateTime.Now + " - " + ex.GetType().Name + " - " + hostName + " - " + ipAddresses);
                        sw.WriteLine(DateTime.Now + " - " + ex.Message);
                        sw.Close();
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present", ex);
                    }

                }
            }
            catch (Exception ex1)
            {

                Console.WriteLine("Current Exception:" + ex1.GetType().Name);
                Console.WriteLine("Inner Exception:" + ex1.InnerException.GetType().Name);
            }

        }
    }
    class CustomException
    {
        public static void Main293()
        {
            try
            {
                Exception ex = new Exception();
                throw new UserDefinedCustomException();
                throw new UserDefinedCustomException("User defined Exceptions");
                throw new UserDefinedCustomException("User defined Exceptions and Innder exceptions", ex);
            }

            catch (UserDefinedCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
    class UserDefinedCustomException : Exception
    {
        public UserDefinedCustomException() : base()
        {
            //the default constructor. Calling from the Base
        }
        public UserDefinedCustomException(string message) : base(message)
        {
            //the parameterized constructor. Calling from the Base
        }
        public UserDefinedCustomException(string message, Exception InnerException) : base(message, InnerException)
        {
            //the parameterized constructor, with InnerException. Calling from the Base
        }
        public UserDefinedCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

    }
    class ExceptionAbuse
    {
        public static void Main294()
        {
            try
            {
                Console.WriteLine("Enter Numerator");
                int fn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Denominator");
                int sn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sum is {0} ", fn / sn);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not accepted");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Numbers should be between {0} and {1}.", Int32.MinValue, Int32.MaxValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class ExceptionAbuseSolved
    {
        public static void Main294()
        {
            try
            {
                int fn, sn;
                Console.WriteLine("Enter Numerator");
                fn = Convert.ToInt32(Console.ReadLine());
                bool isNumerator = Int32.TryParse(Console.ReadLine(), out fn);

                if (isNumerator)
                {
                    Console.WriteLine("Enter Denominator");
                    sn = Convert.ToInt32(Console.ReadLine());
                    bool isDenominator = Int32.TryParse(Console.ReadLine(), out sn);
                    if (isDenominator && sn != 0)
                    {
                        Console.WriteLine("Quotient {0}", fn / sn);
                    }
                    else
                    {
                        if (sn == 0)
                        {
                            Console.WriteLine("Division by zero is not accepted");
                        }
                        else
                        {
                            Console.WriteLine("Enter a number for Denominator between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                        }
                       
                    }
                }
                else
                {
                    Console.WriteLine("Enter a number for Numerator between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                }


            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}