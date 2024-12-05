using System;

namespace Property
{

    class Property
    {
        static void Main23()
        {
            Student C1 = new Student();
            C1.Id = 100;
            C1.Name = "Swapnadip Saha";
            Console.WriteLine("ID {0}, Name {1}, PassMarks {2} ", C1.Id, C1.Name, C1.Passmrks);
        }
    }

    public class Student
    {
        private int _ID;
        private string _Name;
        private int _PassMarks = 35;
        //private string _city;
        //private string _email;

        public string City { get; set; }
        public int Email { get; set; }
        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student ID should be greater than 0");
                }
                this._ID = value;
            }
            get
            {
                return this._ID;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("name should not be Null");
                }
                this._Name = value;
            }
            get
            {
                return (string.IsNullOrEmpty(this._Name)) ? "No Name" : this._Name;
            }

        }
        public int Passmrks
        {
            get
            {
                return this._PassMarks;
            }

        }
        //public string City 
        //{
        //    set
        //    {
        //        this._city = value;
        //    }
        //    get
        //    {
        //        return this._city;
        //    }
        //}
        //public string Email
        //{
        //    set
        //    {
        //        this._email = value;
        //    }
        //    get
        //    {
        //        return this._email;
        //    }
        //}
    }
}