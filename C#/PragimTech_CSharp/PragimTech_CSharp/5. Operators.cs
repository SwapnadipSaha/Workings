using System;
using System.Collections.Generic;
using System.Text;
class Operators
{
    static void Main5()
    {
        //Ternary Operator

        int num = 11;
        int num1 = 11;
        bool isnum, isnum1;
        if (num == 10)
        {
            isnum = true;
        }
        else {
            isnum = false;
        }
        Console.WriteLine("Number == 10 is {0}", isnum);
        //Replaced by
        isnum1=(num1 == 11?true:false);
        Console.WriteLine("Number == 11 is {0}", isnum1);
    }
}

