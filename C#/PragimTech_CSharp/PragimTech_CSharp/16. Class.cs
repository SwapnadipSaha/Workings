using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
//Before doing this, need to add refernce  as now moved to separate class Libraries
using System.Text;

namespace Classes
{

    class ClassDemo
    {
        static void Main16()
        {
            Customer c1 = new Customer();
            Customer cc = new Customer("Swapnadip", "Saha");
            cc.PrintFullName();
            c1.PrintFullName();
        }
    }

    class Customer
    {
        string _firstName;
        string _lastName;

        public int id;
        public string Name;

        public void PrintFullName()
        {
            Console.WriteLine("Full Name ={0} {1}", _firstName, _lastName);
            //or
            Console.WriteLine("Full Name ={0} {1}", this._firstName, this._lastName);
        }

        public Customer() : this("No First Name", "No Last Name")
        {

        }
        public Customer(string FName, string LName)
        {
            _firstName = FName;
            _lastName = LName;

            //or

            this._firstName = FName;
            this._lastName = LName;
        }

        ~Customer()
        { }
    }
}