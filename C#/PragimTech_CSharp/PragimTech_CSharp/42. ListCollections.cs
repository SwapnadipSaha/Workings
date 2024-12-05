using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollections
{
    public class ListCollections
    {
        public static void Main()
        {
            Customer customer01 = new Customer()
            {
                Id = 101,
                Name = "Swapna",
                Salary = 550
            };
            Customer customer02 = new Customer()
            {
                Id = 102,
                Name = "DreamZ",
                Salary = 500
            };
            Customer customer03 = new Customer()
            {
                Id = 103,
                Name = "Dip Saha",
                Salary = 450
            };

            Customer customer04 = new Customer()
            {
                Id = 104,
                Name = "Dip Saha Swapna",
                Salary = 400
            };

            //Customer[] arrCustomer = new Customer[2];
            //arrCustomer[0] = customer01;
            //arrCustomer[1] = customer02;
            ////arrCustomer[2] = customer03;/// This will be a runtime error. Index out of range. As the array size is 2. We are trying to fit 3 objects

            List<Customer> lstCustomer = new List<Customer>();/// this has 3 overloads 1. is blank, 2 is int capacity 3 is IEnumerable<Customers> Collection
            List<Customer> lstCustomer2 = new List<Customer>(2);

            lstCustomer.Add(customer01);
            lstCustomer.Add(customer02);
            lstCustomer.Add(customer03);    /// This will not be a runtime error. or Index out of range As List can grow in size

            lstCustomer2.Add(customer01);
            lstCustomer2.Add(customer02);
            lstCustomer2.Add(customer03);   /// This will not be a runtime error. or Index out of range As List can grow in size
            //    lstCustomer2.Add("Swa[nadip Saha");   /// Not possible as Generic collections are strongly typed

            //Customer02 customer021 = new Customer02();
            //lstCustomer2.Add(customer021);   // This is possible. As Customer02 is a child for Customer and so they are of same type.

            //lstCustomer.Insert(0, customer03);  // This will insert in a particular position. Rest of the objects below this will go one step below each



            ////To retrive
            //Console.WriteLine("---------Single---------");
            //Customer rterieveCC = lstCustomer2[2];
            //Console.WriteLine(rterieveCC.Id + " " + rterieveCC.Name + " " + rterieveCC.Salary);
            //Console.WriteLine();

            //Console.WriteLine("---------For Each---------");
            //foreach (Customer customer in lstCustomer)
            //{
            //    Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Salary);
            //    Console.WriteLine();
            //}

            //Console.WriteLine("---------For---------");
            //for (int i = 0; i < lstCustomer2.Count; i++) //< = will give index out of range
            //{
            //    Console.WriteLine(lstCustomer2[i].Id + " " + lstCustomer2[i].Name + " " + lstCustomer2[i].Salary);
            //    Console.WriteLine();
            //}
            //Console.WriteLine(lstCustomer.IndexOf(customer03));   //This will give the index of the object of first occurance                                       //Output    0
            //Console.WriteLine(lstCustomer.IndexOf(customer03, 1));   //This will give the index of the object. It will search from position 1                       //Output    3
            //Console.WriteLine(lstCustomer.IndexOf(customer03, 1, 2));   //This will give the index of the object. It will search from index 1 to next 2 objects       //Output    -1   As the index does not exist

            //lstCustomer.Remove(customer01); // This will remove the first occurance of the object



            //////////////////////////////////Functions///////////////////////////////////////////////

            //Console.WriteLine(lstCustomer2.Contains(customer01));
            //if (lstCustomer2.Contains(customer04))
            //{

            //    Console.WriteLine(customer04.Id + " " + customer04.Name + " " + customer04.Salary);
            //}
            //else
            //{
            //    Console.WriteLine("Not Exist");
            //}


            //Console.WriteLine(lstCustomer2.Exists(x => x.Name.StartsWith("S")));
            //List<Customer> customersStartingWithS = lstCustomer2.FindAll(x => x != null && x.Name != null && x.Name.StartsWith("S")); ;

            //if (customersStartingWithS.Count > 0)
            //{
            //    Console.WriteLine("Customers found:");
            //    foreach (var customer in customersStartingWithS)
            //    {
            //        Console.WriteLine(customer.Name);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No customers with names starting with 'S' found.");
            //}
            //Console.WriteLine(lstCustomer2.Exists(x => x.Salary >= 500));
            //List<Customer> customersSalary = lstCustomer2.FindAll(x => x != null && x.Salary >= 500);

            //if (customersSalary.Count > 0)
            //{
            //    Console.WriteLine("Customers found:");
            //    foreach (var customer in customersSalary)
            //    {
            //        Console.WriteLine(customer.Name + " Salary " + customer.Salary);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No customers with names starting with 'S' found.");
            //}
            Customer findCustomer = new Customer();
            findCustomer = lstCustomer2.Find(x => x.Salary >= 489);
            Console.WriteLine(findCustomer.Id + " " + findCustomer.Name + " " + findCustomer.Salary);// it will give the first matching result. If there is no match it will throw a null exception runtime.

            Customer findLastCustomer = new Customer();
            findLastCustomer = lstCustomer.FindLast(x => x.Salary >= 500);
            Console.WriteLine(findLastCustomer.Id + " " + findLastCustomer.Name + " " + findLastCustomer.Salary);// it will give the Last matching result. If there is no match it will throw a null exception runtime.
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public class Customer02 : Customer
    {

    }
}
