using System;
using System.Collections.Generic;


namespace WithOutDelegates
{
    class WithOutDelegates
    {
        public static void Main281()
        {
            List<Employee> te = new List<Employee>();
            te.Add(new Employee() { ID = 101, Name = "Swapnadip Saha", Salary = 10000, Experience = 5 });
            te.Add(new Employee() { ID = 102, Name = "Arnab Neogy", Salary = 8000, Experience = 4 });
            te.Add(new Employee() { ID = 103, Name = "Rohit Singh", Salary = 12000, Experience = 6 });
            te.Add(new Employee() { ID = 104, Name = "Koushik Roy", Salary = 6000, Experience = 8 });
            te.Add(new Employee() { ID = 105, Name = "Antara Dey", Salary = 7000, Experience = 3 });
            te.Add(new Employee() { ID = 106, Name = "Shantanu Bakshi", Salary = 9000, Experience = 2 });

            Employee.PromoteEmployee(te);
        }
    }
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList)
        {
            foreach (Employee emp in employeeList)
            {
                if (emp.Experience >= 5)
                {
                    Console.WriteLine("Eligible WODelegates " + emp.ID + "-" + emp.Name);
                }
            }
        }
    }
}