using System;

namespace InherittedConstructorCalling
{

    class InherittedConstructorCalling
    {
        static void Main181()
        {
            Console.WriteLine("-----Case 1-----");

            SonClass S1 = new SonClass();
            Console.WriteLine("-----Case 2-----");
            DaughterClass c1 = new DaughterClass();
            Console.WriteLine("-----Case 3-----");
            FatherClass S2 = new SonClass();
            Console.WriteLine("-----Case 4-----");
            MotherClass c2 = new DaughterClass();
        }
    }

    public class MotherClass
    {
        public MotherClass()
        {
            Console.WriteLine("Mother Class Parameter Less Constructor.");
        }
        public MotherClass(string Message)
        {
            Console.WriteLine("Mother Class Constructor with Parameter .");
            Console.WriteLine(Message);
        }
    }
    public class DaughterClass : MotherClass
    {
        public DaughterClass() : base("Daughter controlling Mother")
        {
            Console.WriteLine("Daughter Class Parameter Less Constructor.");
        }
    }

    public class FatherClass
    {
        public FatherClass()
        {
            Console.WriteLine("Father Class Parameter Less Constructor.");
        }
    }
    public class SonClass : FatherClass
    {
        public SonClass()
        {
            Console.WriteLine("Son Class Parameter Less Constructor.");
        }
    }
}