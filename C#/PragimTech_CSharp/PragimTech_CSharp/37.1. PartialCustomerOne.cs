using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    public partial class PartialCustomer : IPartialInterfaceOne
    {
        private string _firstName;
        private string _lastName;

        void IPartialInterfaceTwo.PartialInterfaceTwoMethod()
        {
            throw new NotImplementedException();
        }

        void IPartialInterfaceOne.PartialInterfaceOneMethod()
        {
            throw new NotImplementedException();
        }
    }
}
