using System;

namespace Enums
{
    class Enums
    {
        public static void Main30()
        {
            Customer[] customer = new Customer[3];
            customer[0] = new Customer { Name = "SS", Gender = 0 };
            customer[1] = new Customer { Name = "EC", Gender = 1 };
            customer[2] = new Customer { Name = "AS", Gender = 2 };
            foreach (Customer cc in customer)
            {
                Console.WriteLine("Name-{0} and Gender {1}.", cc.Name, cc.Gender);
            }
            //output
            //Name-SS and Gender 0.
            //Name - EC and Gender 1.
            //Name - AS and Gender 2.
            //This does not make sense, as every time we have to check the documnetaion, for the defination of 0,1,2
            //or
            //We may have a function, which converts the int into string like............

            foreach (Customer cc1 in customer)
            {
                Console.WriteLine("Name-{0} and Gender {1}.", cc1.Name, Enums.getGender(cc1.Gender));
            }

            Customer1[] customer1 = new Customer1[3];
            customer1[0] = new Customer1 { Name = "SS", Gender = Gender.Unknown };
            customer1[1] = new Customer1 { Name = "EC", Gender = Gender.Male };
            customer1[2] = new Customer1 { Name = "AS", Gender = Gender.Female };
            foreach (Customer1 cc1 in customer1)
            {
                Console.WriteLine("Name-{0} and Gender {1}.", cc1.Name, cc1.Gender);
            }



            int[] vals = (int[])Enum.GetValues(typeof(Gender));// the GetValues() method is expecting a type to be passed in. A type can be a class, struct, enum etc. Here we are passing the name of the enum i.e. Gender. But as the parameter is type wer are passing typeof(Gender)=Enums.Gender. As the return type of GetValues() array of values, hence int[]
            foreach (short v in vals)
            {
                Console.WriteLine(v.ToString());
            }

            string[] name = Enum.GetNames(typeof(Gender));
            foreach (string n in name)
            {
                Console.WriteLine(n.ToString());
            }

            Gender g = new Gender();
            Season g1 = new Season();
            g = (Gender)g1;

            //or
            Gender g2 = (Gender)Season.Summer;
        }
        public static string getGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "No Idea";
            }
        }

        /// <summary>
        /// Optional In case of enums
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        public static string getGender1(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "No Idea";
            }
        }
    }
    class Customer
    {
        /// <summary>
        /// 0 for Unknown
        /// 1 for MALE
        /// 2 for FEMALE
        /// </summary>
        public string Name { get; set; }
        public int Gender { get; set; }
    }
    public enum Gender
    {
        Unknown = 1,
        Male = 2,
        Female = 3
    }

    public enum Season
    {
        Summer = 1,
        Winter = 2,
        Sprimg = 3
    }

    class Customer1
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}