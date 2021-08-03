using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class DivbyZero
    {
        public static void Main()
        {
            int x = 5;
            int y = 0;
            int z = 0;
            try
            {
                z = x / y;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(z);
            }
                Console.Read();
            
        }
    }
}
