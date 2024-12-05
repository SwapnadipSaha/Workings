using Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    public class PartialClassDemo
    {
        public static void Main37()
        {
            PartialCustomerMain c1 = new PartialCustomerMain();
            c1.FirstName = "Swapnadip";
            c1.LastName = "Saha";
            Console.WriteLine("Full Name is :{0}",c1.GetFullName());


            PartialCustomer pc1 = new PartialCustomer();
           pc1.FirstName = "Saha";
            pc1.LastName = "Swapnadip";
            Console.WriteLine("Full Name is :{0}", pc1.GetFullName());
        }
    }

}
