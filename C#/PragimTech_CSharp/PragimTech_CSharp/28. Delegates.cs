using System;
using System.Collections.Generic;

namespace Delegates { 
class Delegates
{
    public delegate void HelloFunctionDelegate(string message);
    public static void Main28()
    {
        HelloFunctionDelegate hfd = new HelloFunctionDelegate(Hello);
        hfd("This message is Displaying from the Hello Method, using HelloFunctionDelegate delegate");
    }

    public static void Hello(string message) //
    {
        Console.WriteLine(message);
    }
}
}