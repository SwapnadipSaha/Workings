using System;

namespace interfaces
{
    interface ICustomer
    {
        void Print();
    }
    interface ICustomer2
    {
        void Print();
    }
    class Interfaces : ICustomer, ICustomer2
    {
        //void ICustomer.Print()
        public void Print()
        {
            Console.WriteLine("Print 1");
        }

        void ICustomer2.Print()
        {
            Console.WriteLine("Print 2");
        }
        static void Main25()
        {
            Interfaces I1 = new Interfaces();
            ((ICustomer)I1).Print();
            ((ICustomer2)I1).Print();

            ICustomer i2 = new Interfaces();
            i2.Print();


            ICustomer2 i3 = new Interfaces();
            i3.Print();
            Interfaces I4 = new Interfaces();
            I4.Print();
            ((ICustomer2)I4).Print();

        }
    }

}
