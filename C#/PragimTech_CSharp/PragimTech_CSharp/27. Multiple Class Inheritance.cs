using System;

namespace MultipleClassInheritance 
{

    class MultipleClassInheritance
    {
        static void Main182()
        {
            D d = new D();
            //d.
        }
    }

    public class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Class");
        }
    }


    public class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Class");
        }
    }

    public class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C Class");
        }
    }

    public class D : B/*,C*/
    {
        public override void Print()
        {
            Console.WriteLine("D Class");
        }
    }
}