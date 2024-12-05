using System;
using System.Collections.Generic;
namespace DelegatesLambda
{

    delegate bool IsPromotableEmployee(Employee emp);

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotableEmployee IsEligible)
        {
            foreach (Employee emp in employeeList)
            {
                if (IsEligible(emp))
                {
                    Console.WriteLine("Eligible Lmbda " + emp.ID + "-" + emp.Name);
                }
            }
        }
    }

    class DelegatesLambda
    {
        public static void Main283()
        {
            List<Employee> oe = new List<Employee>();

            oe.Add(new Employee() { ID = 101, Name = "Swapnadip Saha", Salary = 10000, Experience = 5 });
            oe.Add(new Employee() { ID = 102, Name = "Arnab Neogy", Salary = 8000, Experience = 4 });
            oe.Add(new Employee() { ID = 103, Name = "Rohit Singh", Salary = 12000, Experience = 6 });
            oe.Add(new Employee() { ID = 104, Name = "Koushik Roy", Salary = 6000, Experience = 8 });
            oe.Add(new Employee() { ID = 105, Name = "Antara Dey", Salary = 7000, Experience = 3 });
            oe.Add(new Employee() { ID = 106, Name = "Shantanu Bakshi", Salary = 9000, Experience = 2 });

            Employee.PromoteEmployee(oe, emp => emp.Experience >= 5);
        }
    }


}
