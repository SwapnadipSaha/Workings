using System;
namespace MethodHiding
{
    class MethodHiding
    {
        static void Main19()
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.FirstName = "Swapnadip";
            fte.LastName = "Saha";
            fte.PrintFullName();

            PartTimeEmployee pte = new PartTimeEmployee();
            pte.FirstName = "Saha";
            pte.LastName = "Swapnadip";
            //pte.PrintFullName();
            ((Employee)pte).PrintFullName(); // Case 3 

            Employee pte1 = new PartTimeEmployee();
            pte1.FirstName = "Saha";
            pte1.LastName = "Swapnadip";
            pte1.PrintFullName();

        }
    }
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public void PrintFullName()
        {
            Console.WriteLine("Name of the Employee is {0} {1}", FirstName, LastName);
        }

    }
    public class PartTimeEmployee : Employee
    {
        float hourleyWage;

        public new void PrintFullName()
        {
            Console.WriteLine("Name of the Employee is {0} {1} - Contract", FirstName, LastName); //Case 1:  Method hiding - Creating own method in derivedclass
                                                                                                  //base.PrintFullName();   //Case 2: Calling base class inspite of Method hiding

        }
    }
    public class FullTimeEmployee : Employee
    {
        float monthlySalary;
    }

}
