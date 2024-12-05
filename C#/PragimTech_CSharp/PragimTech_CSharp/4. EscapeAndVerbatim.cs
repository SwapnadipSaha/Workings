using System;
class EscapeAndVerbatim
{
    static void Main4()
    {
        string name = "\"Swapnadip\"\n";
        string path= "D:\\!Desktop\\DATA FIX\\Appointment\\05042019";
        Console.WriteLine(" {0} {1}", name,path);

        string path1 = @"D:\!Desktop\DATA FIX\Appointment\05042019";
        Console.WriteLine(" {0}", path1);

    }
}

