using System;
class cflow3
{
public static void Main()
{
Console.WriteLine("Please enter your age");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Answer Yes or No if you are a graduate");
String grad = Console.ReadLine();

	if(age>=21 && grad == "Yes" )
	{
	Console.WriteLine("Eligible");
	Console.WriteLine("Attend the interview");
	}
	//{} to create block - multiple statements 
	else
	
	Console.WriteLine("Not eligible");
	
}
}