using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace FirstConsole
{
    class RegExp1
    {
        public void CleanString()
        {
            string DirtyData = "Here    is      a sentence      with     a lot    of whitespaces";
            string CleanedData = Regex.Replace(DirtyData, "\\s+", " ");
            Console.WriteLine(CleanedData);
        }
        public void MobileNo()
        {
            string[] mobileNo = { "9940623935", "9940623935", "+91-9940623935", "+919940623935", "9940623935", "+91-99406-23935", "+919940623935", "+91-9940-623935" };
            Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");
            //Regex regex = new Regex(@"d{5}d{5}");
            foreach (string mno in mobileNo)
            {
                Console.WriteLine("{0}{1} ValidNo ", mno, r.IsMatch(mno) ? " is" : "is not");
            }
            string nu = "9940623935";
            Regex r1 = new Regex(@"d{0-5}");
            Console.WriteLine(r1.IsMatch(nu));
        }
        public static void Main()
        {
            string FirstName = "HEMA";
            //FirstName = FirstName.ToUpper(FirstName);
            Regex regex = new Regex(@"\w[A-Z]");
            Console.WriteLine(regex.IsMatch(FirstName));

            String zipcode = "600 001";
             Console.WriteLine(Regex.IsMatch(zipcode, @"^[1-9]{1}[0-9]{2}\s{0,1}[0-9]{3}$"));
 
            Console.ReadLine();
        }
    }
}
