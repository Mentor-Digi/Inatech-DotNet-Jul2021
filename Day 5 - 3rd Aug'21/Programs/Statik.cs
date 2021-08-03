using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class Statik
    {
        //static variable
        public static int num;
        public void count()
        {
            num++;
        }

        public int Getnum()
        {
            return num;
        }
        public static void Main()
        {
            Statik obj1 = new Statik();
            Statik obj2 = new Statik();
            obj1.count();
            obj1.count();
            obj1.count();
            obj2.count();
            obj2.count();
            obj2.count();
            obj2.count();
            obj2.count();
            //int n = 0;
            Console.WriteLine("Value os static variable num is : {0}", obj1.Getnum());
            Console.WriteLine("Value os static variable num is : {0}", obj2.Getnum());
            Console.ReadLine();
        }
    }
}
