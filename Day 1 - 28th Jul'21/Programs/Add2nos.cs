using System;
class Add2Nos
{
public static void Main()
{
Console.WriteLine("Enter 2 nos");
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(num1 + num2);
Console.WriteLine("The given numbers are " +num1 +" and  " +num2);
Console.WriteLine("The given numbers are {0} and {1}", num1 , num2);
Console.WriteLine("The given numbers are {0} and {1} and their sum is {2}", num1 , num2, num1+num2);//incomplete

}
}