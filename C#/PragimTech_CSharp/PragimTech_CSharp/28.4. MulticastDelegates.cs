using System;
using System.Collections.Generic;

namespace MulticastDelegates
{
    public delegate void MultiCastDelegate();
    public delegate int MultiCastDelegateInt();
    public delegate int MultiCastDelegateOutParameter(out int delParam);
    class MulticastDelegatesClass
    {
        public static void Main284()
        {
            MulticastDelegatesClass mcd = new MulticastDelegatesClass();

            MultiCastDelegate del1, del2, del3, del4;
            del1 = new MultiCastDelegate(mcd.SampleDelegateMethodOne);   // the method is not static, So calling using an instance of the class
            del2 = new MultiCastDelegate(SampleDelegateMethodTwo);      // the method is  static, So calling directly
            del3 = new MultiCastDelegate(MulticastDelegatesClass.SampleDelegateMethodThree);      // the method is  static, So calling <Classname>.<Methodname>

            del4 = del1 + del2 + del3 - del2;    //Making del4 MultiCast
            del4();

            MultiCastDelegate del = new MultiCastDelegate(SampleDelegateMethodTwo);
            del += mcd.SampleDelegateMethodOne;
            del += SampleDelegateMethodThree;  // or MulticastDelegatesClass.SampleDelegateMethodThree
            del -= MulticastDelegatesClass.SampleDelegateMethodThree;  // or SampleDelegateMethodThree

            del();

            MultiCastDelegateInt delInt, delInt1, delInt2;
            delInt1 = new MultiCastDelegateInt(mcd.SampleDelegateMethodIntOne);
            delInt2 = new MultiCastDelegateInt(SampleDelegateMethodIntTwo);
            delInt = delInt1 + delInt2;

            int delegateOutput = delInt();
            Console.WriteLine(delegateOutput);


            MultiCastDelegateOutParameter delOutInt, delOutInt1, delOutInt2;
            delOutInt1 = new MultiCastDelegateOutParameter(mcd.SampleDelegateMethodOutOne);
            delOutInt2 = new MultiCastDelegateOutParameter(SampleDelegateMethodOutTwo);
            delOutInt = delOutInt2 + delOutInt1;

            int delegateOutOutPut, delegateOutParam = -1;
            delegateOutOutPut = delOutInt(out delegateOutParam);
            Console.WriteLine("Return the Output: " + delegateOutOutPut + " Output Param: " + delegateOutParam);
        }
        public void SampleDelegateMethodOne()
        {
            Console.WriteLine("Sample Delegate Method One");
        }
        public static void SampleDelegateMethodTwo()
        {
            Console.WriteLine("Sample Delegate Method Two");
        }
        public static void SampleDelegateMethodThree()
        {
            Console.WriteLine("Sample Delegate Method Three");
        }

        public int SampleDelegateMethodIntOne()
        {
            return 1;
        }
        public static int SampleDelegateMethodIntTwo()
        {
            return 2;
        }

        public int SampleDelegateMethodOutOne(out int intParame)
        {
            intParame = 1;
            return intParame;
        }
        public static int SampleDelegateMethodOutTwo(out int intParame)
        {
            intParame = 2;
            return intParame;
        }
    }

}