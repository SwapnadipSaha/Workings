using System;

namespace PolyMorphism
{

    public class Employees
    {
        public string FName = "Swapnadip";
        public string LName = "Saha";
        public virtual void PrintFullName()
        {
            Console.WriteLine("Name of the Employee is {0} {1}", FName, LName);
        }

    }
    public class PartTimeEmployees : Employees
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Name of the Employee is {0} {1} - Part Time", FName, LName);
        }
    }
    public class FullTimeEmployees : Employees
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Name of the Employee is {0} {1} - Full Time", FName, LName);
        }
    }

    public class TemporaryEmployees : Employees
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Name of the Employee is {0} {1} - Tempo", FName, LName);
        }
    }

    public class OtherEmployees : Employees
    {
        public new void PrintFullName()
        {
            Console.WriteLine("Name of the Employee is {0} {1} - Other", FName, LName);
        }
    }

    public class ContractEmployees : Employees
    {
        public new void PrintFullName()
        {
            Console.WriteLine("Name of the Employee is {0} {1} - Contract", FName, LName);
        }
    }

    class Polymorphism
    {
        static void Main20()
        {
            Employees[] emp = new Employees[5];
            emp[0] = new Employees();
            emp[1] = new PartTimeEmployees();
            emp[2] = new FullTimeEmployees();
            emp[3] = new TemporaryEmployees();
            emp[4] = new OtherEmployees();

            foreach (var e in emp)
            {
                e.PrintFullName();
            }

            ContractEmployees ce = new ContractEmployees();
            ce.PrintFullName();
        }
    }

}
