using System;
namespace GetterSetter
{

    class GetterSetter
    {
        static void Main22()
        {
            Student C1 = new Student();
            C1.SetId(100);
            C1.SetName(null);
            Console.WriteLine("ID {0}, Name {1}, PassMarks {2} ", C1.GetId(), C1.GetName(), C1.GetPassMarks());
        }
    }

    public class Student
    {
        private int _ID;
        private string _Name;
        private int _PassMarks = 35;

        public void SetId(int ID)
        {
            if (ID <= 0)
            {
                throw new Exception("Student ID should be greater than 0");
            }
            this._ID = ID;
        }

        public int GetId()
        {
            return this._ID;
        }

        public void SetName(String Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("name should not be Null");
            }
            this._Name = Name;
        }

        public string GetName()
        {

            return (string.IsNullOrEmpty(this._Name)) ? "No Name" : this._Name;
        }

        public int GetPassMarks()
        {
            return this._PassMarks;
        }
    }
}