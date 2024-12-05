using System;
using System.Collections.Generic;
using System.Text;
class NullCoalacing
{
    static void Main1()
    {
        //Null Coalacing Operator
        string s = null;
        int? i = null;


        int? avl = null;
        int num;
        if (avl == null)
        {
            num = 0;
        }
        else
            {
            num = avl.Value;   //as null cannot implicitly convertable
            //or cast operator
            num =(int)avl;
        }
        //----------or----Null Coalescing Operator--------
        int? avl1 = null;
        int num1= avl1??0; //if avl1 is null then the default value here 0 else the value of avl1
    }
}

