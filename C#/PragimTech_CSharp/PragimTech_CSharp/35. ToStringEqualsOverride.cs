using System;
using System.Collections.Generic;
using System.Text;

namespace ToStringEqualsOverride
{
    class ToStringEqualsOverride
    {
        public static void Main35()
        {
            //------------------------ToString-----------------------------------
            int p = 10;
            Console.WriteLine(p.ToString());

            Customer c1 = new Customer();
            c1.FirstName = "Swapnadip";
            c1.LastName = "Saha";



            Console.WriteLine(c1.ToString());
            Console.WriteLine(Convert.ToString(c1));

            //------------------------Equals-----------------------------------

            int i = 10;
            int j = 10;
            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));

            Direction direction1 = Direction.east;
            Direction direction2 = Direction.west;

            Console.WriteLine(direction1 == direction2);
            Console.WriteLine(direction1.Equals(direction2));

            Customer c2 = c1;//Reference and values equality           

            Console.WriteLine(c1 == c2);    
            Console.WriteLine(c1.Equals(c2));

            Customer c3 = new Customer();
            c3.FirstName = "Swapnadip";
            c3.LastName = "Saha";
            //Reference inequality but values equality  

            Console.WriteLine(c1 == c3);        //Output False
            Console.WriteLine(c1.Equals(c3));   //Output False for base, true after override

            //If Reference equaity is true then value equality is obviously true but value equality does not gurranty Reference equaity.
            //Here == operands gives reference equakity, but .Equals gives value equality.

        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;

        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false; //  the provided obj is null. If it is, Equals returns false, meaning the current Customer instance is not equal to null.
            if (!(obj is Customer)) return false; //if the provided obj is not of type Customer (using the is keyword). If obj is not a Customer, the method returns false, as objects of different types cannot be considered equal.
            return this.FirstName == ((Customer)obj).FirstName 
            && this.LastName == ((Customer)obj).LastName;
            //if the FirstName and LastName properties of the current instance (this) match those of obj, which is cast to Customer. If both the FirstName and LastName properties match, Equals returns true, indicating that the two Customer objects are equal. Otherwise, it returns false
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }

    public enum Direction
    {
        north = 1,
        east = 2,
        west = 3,
        south = 4
    }

}
