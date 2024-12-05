using System;
namespace OverridingVsHiding
{

    class OverridingVsHiding
    {
        public class BaseClass
        {
            public void Print()
            {
                Console.WriteLine("I am base Class");
            }

        }

        public class DerivedClass : BaseClass
        {
            public new void Print()
            {
                Console.WriteLine("I am Derived Class");
            }

        }
        static void Main21()
        {
            BaseClass B = new DerivedClass();
            B.Print();

            DerivedClass c = new DerivedClass();
            c.Print();
        }
    }


}