using System;
namespace Struct
{

    class Struct
    {
        static void Main24()
        {
            Customer c1 = new Customer();
            c1.PrintCustomer();// The default Constructor is still working even after defining the Constructor with Parameter

            Customer c2 = new Customer(1, "SS");
            c2.PrintCustomer();

            Customer c3 = new Customer();
            c3.id = 2;
            c3.name = "EC";
            c3.PrintCustomer();

            Customer c4 = new Customer()
            {
                id = 3,
                name = "SC"
            };
            c4.PrintCustomer();



            //--------------------------------------------------------

            int i1 = 10;
            if (i1 == 10)
            {
                int j1 = 20;
                Customer cc = new Customer();
                cc.id = 101;
                cc.name = "SS";
            }

            //--------------------------------------------------------

            int i = 10;
            int j = i;
            Console.WriteLine("i {0} and j {1}", i, j);
            j++;
            Console.WriteLine("i {0} and j {1}", i, j);

            Customer cc1 = new Customer();
            cc1.id = 102;
            cc1.name = "EC";
            Customer cc2 = cc1;
            Console.WriteLine("cc1.id {0} and cc1.Name {1} cc2.id {0} and cc2.Name {1}", cc1.id, cc1.name, cc2.id, cc2.name);
            cc2.id = 103;
            cc2.name = "SC";
            Console.WriteLine("cc1.id {0} and cc1.Name {1} cc2.id {0} and cc2.Name {1}", cc1.id, cc1.name, cc2.id, cc2.name);
        }
    }
    public struct Customer
    {
        private int _id;
        private string _name;
        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
            }
        }

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
            }
        }

        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;

        }

        public void PrintCustomer()
        {
            Console.WriteLine("Id {0} and Name {1}", this._id, this._name);
        }
    }

}