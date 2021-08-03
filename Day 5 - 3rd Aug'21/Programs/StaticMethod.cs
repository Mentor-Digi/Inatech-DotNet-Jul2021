using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class StaticMethod
    {
        int n1 =1;
        static int snum1;
        public void Count()
        {
            Console.WriteLine(n1++);
        }

        public static void sCount()
        {
            Console.WriteLine(snum1++);
        }
        public static void Main()
        {
            StaticMethod sobj = new StaticMethod();
            sobj.Count();
            sobj.Count();
            StaticMethod sobjx = new StaticMethod();
            sobjx.Count();
            sCount();
            sCount();
            Console.Read();
        }
    }
}
