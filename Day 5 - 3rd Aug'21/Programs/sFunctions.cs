using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class sFunctions
    {
        public static void Main()
        {
            String str1 = "Peacock";
            String str2;
            Console.WriteLine(str1.Length);
            str2 = str1.Clone().ToString();
            Console.WriteLine(str2);
            Console.WriteLine(str2.Replace("cock", "hen"));
            Console.WriteLine(str1.CompareTo("India"));
            Console.WriteLine(str1.StartsWith("P"));
            Console.WriteLine(str2.EndsWith("cock"));
            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str2.ToLower());
            str1 = "    Peacock   ";
                Console.WriteLine(str1);
            Console.WriteLine(str1.Trim());
            Console.WriteLine(str2.Substring(3, 4));
            Console.ReadLine();
        }
    }
}
