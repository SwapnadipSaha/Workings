using System;
using System.Collections.Generic;
using System.Text;

namespace NSGenerics
{
    class Generics
    {
        public static void Main34()
        {
            bool Equal = Calculator<object>.AreEqual("A", 2);
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            bool EqualGeneric = Calculator<int>.AreEqualGeneric(1, 2);

            if (EqualGeneric)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
    public class Calculator<T>
    {
        public static bool AreEqual(object val1, object val2)
        {
            return val1 == val2;
        }

        public static bool AreEqualGeneric(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }

}
