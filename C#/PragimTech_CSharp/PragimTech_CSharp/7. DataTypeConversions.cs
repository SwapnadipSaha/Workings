using System;
using System.Collections.Generic;
using System.Text;
class DataTypeConversions
{
    static void Main7()
    {
        //Implicit Conversions
        int i = 10;
        float f = i;
        Console.WriteLine("i={0} and f={1}",i,f);  //Output   i=10 and f=10

        //Explicit Conversions

        float f1 = 10.52f;
        int i1=(int) f1;   //type cast operator
        Console.WriteLine("i1={0} and f1={1}", i1, f1); //Output   i1=10 and f1=10.52

        float f2= 112.52f;
        int i2 = Convert.ToInt16(f2);   //Convert class
        Console.WriteLine("i2={0} and f2={1}", i2, f2); //Output   i2=113 and f2=112.52

        Console.WriteLine("Difference between type cast and Convert");

        float f3 = 1273733434333.45f;
        int i3 = (int)f3;   //type cast operator
        Console.WriteLine("i3={0} and f3={1}", i3, f3);  //Output    i3=-2147483648 and f3=1.2737334E+12

        float f4 = 1273733434333.45f;
        //int i4 = Convert.ToInt16(f4);    //Convert class
        //int i5 = Convert.ToInt32(f4);    //Convert class
        long i4 = Convert.ToInt64(f4);    //Convert class
        Console.WriteLine("i4={0} and f4={1}", i4, f4);  //Output    i4=1273733447680 and f4=1.2737334E+12

        Console.WriteLine("Difference between Parse and TryParse");

        string num = "100";
        int j = int.Parse( num);
        Console.WriteLine("String num={0} and int j={1}", num, j);  //Output    String num=100 and int j=100

        string num2 = "100A";
        int j2 = int.Parse(num2);
        Console.WriteLine("String num2={0} and int j2={1}", num2, j2);  //Output    Error 'Input string was not in a correct format. In this case should use TryParse'

        bool b = int.TryParse(num2, out j2);
        Console.WriteLine("String num2={0} and New int j2={1} and b={2}", num2, j2,b);  //Output    String num2=100A and New int j2=0 and b=False . Since the string could not be converted to int
         b = int.TryParse(num, out j);
        Console.WriteLine("String num={0} and New int j={1} and b={2}", num, j, b);  //Output       String num=100 and New int j=100 and b=True
    }
}

