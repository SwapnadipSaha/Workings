using System;
using System.Collections.Generic;

namespace WithDelegates
{
    class WithDelegates
    {
        public static void Main282()
        {
            List<Employee> te = new List<Employee>();  // Object of the Employee Class

            IsPromotableEmployee objIsEligible = new IsPromotableEmployee(IsElligible);   // Object of the delegate where the constructor has the method name as same signature i.e. IsElligible

            te.Add(new Employee() { ID = 101, Name = "Swapnadip Saha", Salary = 10000, Experience = 5 });
            te.Add(new Employee() { ID = 102, Name = "Arnab Neogy", Salary = 8000, Experience = 4 });
            te.Add(new Employee() { ID = 103, Name = "Rohit Singh", Salary = 12000, Experience = 6 });
            te.Add(new Employee() { ID = 104, Name = "Koushik Roy", Salary = 6000, Experience = 8 });
            te.Add(new Employee() { ID = 105, Name = "Antara Dey", Salary = 7000, Experience = 3 });
            te.Add(new Employee() { ID = 106, Name = "Shantanu Bakshi", Salary = 9000, Experience = 2 });

            Employee.PromoteEmployee(te, objIsEligible);   // Passing the Employee list and the delegate 
        }

        public static bool IsElligible(Employee emp)   // the delegate is pointing to this method
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

    delegate bool IsPromotableEmployee(Employee emp);   // the delegate


    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotableEmployee IsEligible)   // The delegate object is passes
        {
            foreach (Employee emp in employeeList)
            {
                if (IsEligible(emp))   //Replaced the condition with delegate
                {
                    Console.WriteLine("Eligible Delegates " + emp.ID + "-" + emp.Name);
                }
            }
        }

    }
}