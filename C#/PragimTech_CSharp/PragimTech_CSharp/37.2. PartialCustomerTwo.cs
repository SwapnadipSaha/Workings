using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    public partial class PartialCustomer : IPartialInterfaceTwo
    {
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName { get => _lastName; set => _lastName = value; }  /*Property syntax-- right click refactor*/

        public string GetFullName()
        {
            return _firstName + ' ' + _lastName;
        }


    }
}
