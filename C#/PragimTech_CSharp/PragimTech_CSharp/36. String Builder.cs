using System;
using System.Collections.Generic;
using System.Text;

namespace StringvsStringBuilder
{
    class StringvsStringBuilder
    {
        public static void Main36()
        {
            string userString = "C#";
            userString += " Video";
            userString += " Tutorial";
            userString += " for";
            userString += " beginners";
            userString += " -- String";

            Console.WriteLine(userString);

            StringBuilder sb = new StringBuilder("C#");
            sb.Append(" Video");
            sb.Append(" Tutorial");
            sb.Append(" for");
            sb.Append(" beginners");
            sb.Append(" -- StringBuilder");

            Console.WriteLine(sb);

        }
    }

}
