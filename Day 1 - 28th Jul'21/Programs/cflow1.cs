using System;
class cflow1
{
public static void Main()
{
Console.WriteLine("Please enter your age");
int age = Convert.ToInt32(Console.ReadLine());
	if(age>=21)
	{
	Console.WriteLine("Eligible");
	}
}
}