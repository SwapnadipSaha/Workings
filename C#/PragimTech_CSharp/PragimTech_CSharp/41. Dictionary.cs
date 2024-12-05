using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dictionary
{
    public class Dictionary
    {
        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }

        }
        public static void Main41()
        {
            Customer cust001 = new Customer() { ID = 1001, Name = "Swapnadip", Salary = 500 };
            Customer cust002 = new Customer() { ID = 1002, Name = "Saha", Salary = 550 };
            Customer cust003 = new Customer() { ID = 1003, Name = "Pidanpaws", Salary = 450 };

            Dictionary<int, Customer> custDict = new Dictionary<int, Customer>();

            custDict.Add(cust001.ID, cust001);
            custDict.Add(cust002.ID, cust002);
            custDict.Add(cust003.ID, cust003);

            // To check whether the key is already exists in the dictionary as the keys are unique in Dictionary
            if (!custDict.ContainsKey(cust003.ID))
            {
                custDict.Add(cust003.ID, cust003);
            }
            if (custDict.ContainsKey(1004))
            {
                Customer cust = custDict[1004];   // Will give a runtime error as there is no ID exists. To sole the issue add a check (if condition)
            }
            // To  Retrieve   Method 1 
            Console.WriteLine("To  Retrieve   Method 1");
            Customer cust004 = custDict[cust001.ID];
            Console.WriteLine("Name of ID {0} is {1}", cust001.ID, cust004.Name);
            Console.WriteLine("-----------------------------------------------------------------------");

            // To  Retrieve   Method 2 
            Console.WriteLine("To  Retrieve   Method 2");
            Customer cust005 = custDict[1003];
            Console.WriteLine("Name of ID 1003 is {0}", cust005.Name);
            Console.WriteLine("-----------------------------------------------------------------------");

            // To  Retrieve   Method 3  foreach - KeyValuePair
            Console.WriteLine("To  Retrieve   Method 3 foreach - KeyValuePair");
            foreach (KeyValuePair<int, Customer> Dict in custDict)  //foreach (var Dict in custDict)   For better readibility use KeyValuePair
            {
                Console.WriteLine("Key is {0}", Dict.Key);
                Customer customer = Dict.Value;
                Console.WriteLine("ID={0},Name={1} and salary={2}", customer.ID, customer.Name, customer.Salary);
            }
            Console.WriteLine("-----------------------------------------------------------------------");

            // To  Retrieve   Method 4  foreach - Key
            Console.WriteLine("To  Retrieve   Method 4 foreach - Key");
            foreach (int Dict in custDict.Keys)
            {
                Console.WriteLine("Key is {0}", Dict);
            }
            Console.WriteLine("-----------------------------------------------------------------------");

            // To  Retrieve   Method 5  foreach - value
            Console.WriteLine("To  Retrieve   Method 5 foreach - value");
            foreach (Customer Dict in custDict.Values)
            {
                Console.WriteLine("Values are ID={0},Name={1} and salary={2}", Dict.ID, Dict.Name, Dict.Salary);
            }
            Console.WriteLine("-----------------------------------------------------------------------");

            //----------------TRYGETVALUE()--------------------
            Customer cc = new Customer();
            if (custDict.TryGetValue(100001, out cc))
            {
                Console.WriteLine("Values are ID={0},Name={1} and salary={2}", cc.ID + cc.Name + cc.Salary);
            }
            else
            {
                Console.WriteLine("Key not Found");
            }
            Console.WriteLine("-----------------------------------------------------------------------");

            //---------------Count()--------------------

            Console.WriteLine("Number of elements {0}", custDict.Count);
            Console.WriteLine("Number of elements {0}", custDict.Count());
            Console.WriteLine("Number of elements {0}", custDict.Count(KeyValuePair => KeyValuePair.Value.Salary > 500));
            Console.WriteLine("Number of elements {0}", custDict.Count(KeyValuePair => KeyValuePair.Value.Name.StartsWith("S")));
            Console.WriteLine("-----------------------------------------------------------------------");

            //---------------Remove()--------------------
            custDict.Remove(cust001.ID);
            custDict.Remove(1111);

            foreach (KeyValuePair<int, Customer> Dict in custDict)
            {
                Console.WriteLine("Key is {0}", Dict.Key);
                Customer customer = Dict.Value;
                Console.WriteLine("ID={0},Name={1} and salary={2}", customer.ID, customer.Name, customer.Salary);
            }
            Console.WriteLine("Number of elements {0}", custDict.Count);
            Console.WriteLine("-----------------------------------------------------------------------");



            //---------------Clear()--------------------
            custDict.Clear();
            Console.WriteLine("Number of elements {0}", custDict.Count);
            Console.WriteLine("-----------------------------------------------------------------------");

            //---------------From Array--------------------
            Customer[] arrCustomer = new Customer[3];
            arrCustomer[0] = cust001;
            arrCustomer[1] = cust002;
            arrCustomer[2] = cust003;

            Dictionary<int, Customer> custDict01 = arrCustomer.ToDictionary(cust => cust.ID, cust => cust);
            foreach (KeyValuePair<int, Customer> Dict in custDict01)
            {
                Console.WriteLine("Key is {0}", Dict.Key);
                Customer customer = Dict.Value;
                Console.WriteLine("ID={0},Name={1} and salary={2}", customer.ID, customer.Name, customer.Salary);
               

            }
            Console.WriteLine("-----------------------------------------------------------------------");
            //---------------From List--------------------
            List<Customer> lstCustomer = new List<Customer>() { };
            lstCustomer.Add(cust002);
            lstCustomer.Add(cust001);
            lstCustomer.Add(cust003);

            Dictionary<int, Customer> custDict02 = lstCustomer.ToDictionary(cust => cust.ID, cust => cust);
            foreach (KeyValuePair<int, Customer> Dict in custDict02)
            {
                Console.WriteLine("Key is {0}", Dict.Key);
                Customer customer = Dict.Value;
                Console.WriteLine("ID={0},Name={1} and salary={2}", customer.ID, customer.Name, customer.Salary);
              
            }
            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}

