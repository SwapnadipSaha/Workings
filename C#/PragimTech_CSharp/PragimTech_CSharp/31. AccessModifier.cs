using System;

namespace AccessModifier
{
    class AccessModifier
    {
        public static void Main31()
        {

        }
    }
    class Customer
    {
        private int _id; // this field is available in only Customer class. 
        protected int Gender; // this field is available in only in the child classes, like CorporateCustomer. 
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }

    class CorporateCustomer : Customer
    {
        public void PrintId()
        {
            CorporateCustomer cc = new CorporateCustomer();
            cc.Gender = 101;
            base.Gender = 102;   // to access the base class member. Note base and this will not work in Static method
            this.Gender = 103;   // to access the base class member

        }

    }

}
