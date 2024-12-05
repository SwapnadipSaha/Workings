using System;
using System.Collections.Generic;
using System.Text;

namespace PartialMethodDemo
{
    public partial class PartialMethod
    {
        partial void SamplePartialMethod();
        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod Invoked");
            SamplePartialMethod();
        }
    }
}
