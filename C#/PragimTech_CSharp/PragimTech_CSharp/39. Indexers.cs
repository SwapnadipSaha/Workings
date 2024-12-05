using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Indexers
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
    }

    public class Company
    {
        private List<Employee> listEmployees;
        public Company()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee() { EmployeeId = 1, EmployeeName = "Swapno", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 2, EmployeeName = "Dip ", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 3, EmployeeName = "Saha", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 4, EmployeeName = "Hms", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 5, EmployeeName = "Appl", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 6, EmployeeName = "Support", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 7, EmployeeName = "Tmc", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 8, EmployeeName = "Kolkata", Gender = "Male" });

        }
        // Use "this" keyword to create an indexer

        // This Indexer takes employeeld as parameter

        // and returns employee name


        //--------The indexer -----------------
        public string this[int employeeld]
        {
            //Just like properties indexers have get and set accessors

            get
            {
                // for the given employee id. It will returnthe name of the employee

                return listEmployees.FirstOrDefault(x => x.EmployeeId == employeeld).EmployeeName;  //find an employee x such that, that employee's EmployeeID whould match the parameter passing into the indexer. From this object Pick EmployeeName


                //-----------------OR-------------------------
                //        foreach (var employee in listEmployees)
                //        {
                //            if (employee.EmployeeId == employeeId)
                //            {
                //                return employee.EmployeeName;
                //            }
                //        }
                //        return null; // or throw an exception, if desired
            }
            set
            {
                listEmployees.FirstOrDefault(x => x.EmployeeId == employeeld).EmployeeName = value;  //for an employee x such that, that employee's EmployeeID whould match the parameter passing into the indexer. Set the value i.e. name for the EmployeeId

                // i.e.comp[2]="Swapnadip Saha"    Here the name of the employee whoose id is 2 will set to Swapnadip Saha

                //-----------------OR-------------------------
                //foreach (var employee in listEmployees)
                //{
                //    if (employee.EmployeeId == employeeId)
                //    {
                //        employee.EmployeeName = value;
                //        return;
                //    }
                //}
                //// Optionally handle the case where the employeeId is not found
                //throw new ArgumentException($"Employee with ID {employeeId} not found.");
            }


        }

        public string this[string gender]
        {
            get
            {
                return listEmployees.Count(x => x.Gender == gender).ToString();
            }

            set
            {
                foreach (Employee emp in listEmployees)
                {
                    if (emp.Gender == gender)
                    {
                        emp.Gender = value.ToString();
                    }
                }
            }



        }
    }
}