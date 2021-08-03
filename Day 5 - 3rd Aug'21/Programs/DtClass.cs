using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class DtClass
    {
        public static void Main()
        {
            DateTime dt = new DateTime(2021, 08, 03);
            Console.WriteLine(dt.ToString());
            Console.WriteLine(System.DateTime.Now.ToString());
            Console.WriteLine(System.DateTime.Now.ToShortDateString());
            Console.WriteLine(System.DateTime.Now.ToShortTimeString());
            Console.WriteLine(System.DateTime.Now.ToLongDateString());
            Console.WriteLine(System.DateTime.Now.ToUniversalTime());
            Console.WriteLine(dt.DayOfWeek);
            Console.WriteLine(dt.AddYears(15));

            Console.Read();
        }
    }
}