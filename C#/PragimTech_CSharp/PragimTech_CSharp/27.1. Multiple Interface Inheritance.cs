using System;
namespace MultipleInterfaceInheritance
{
    class MultipleInheritance
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
    interface IA
    {
        void PrintA();

    }
    class ClassA : IA
    {
        public void PrintA()
        {
            Console.WriteLine("A Class");
        }
    }

    interface IB
    {
        void PrintB();

    }
    class ClassB : IB
    {
        public void PrintB()
        {
            Console.WriteLine("B Class");
        }
    }

    //One way
    class ClassAB : IA, IB
    {
        public void PrintA()
        {
            Console.WriteLine("AB A Class");
        }

        public void PrintB()
        {
            Console.WriteLine("AB B Class");
        }
    }
    //Another way  -- Recommendeed
    class ClassBA : IA, IB
    {
        ClassA a = new ClassA();
        ClassB b = new ClassB();
        public void PrintA()
        {
            a.PrintA();
        }

        public void PrintB()
        {
            b.PrintB();
        }
    }


    class MultipleInterfaceInheritance
    {
        static void Main271()
        {
            ClassBA ba = new ClassBA();
            ClassAB ab = new ClassAB();

            ba.PrintA();   // OutPut    A class
            ba.PrintB();   // OutPut    B class

            ab.PrintA();   // OutPut    AB A class
            ab.PrintB();   // OutPut    AB B class

        }
    }


}