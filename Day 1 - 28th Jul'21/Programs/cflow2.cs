using System;
class cflow2
{
public static void Main()
{
Console.WriteLine("Please enter your age");
int age = Convert.ToInt32(Console.ReadLine());
	if(age>=21)
	{
	Console.WriteLine("Eligible");
	Console.WriteLine("Attend the interview");
	}
	//{} to create block - multiple statements 
	else
	
	Console.WriteLine("Not eligible");
	
}
}