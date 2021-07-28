using System;
class cflow4
{
public static void Main()
{
Console.WriteLine("Please enter your age");
int age = Convert.ToInt32(Console.ReadLine());


	if(age>=21)
	{
	Console.WriteLine("Answer Yes or No if you are a graduate");
	String grad = Console.ReadLine();
	if(grad == "Yes")
		Console.WriteLine("Take aptitude Test");

	else
	Console.WriteLine("We recruit only graduates");
	}
	else
	Console.WriteLine("You dont have the minimum age to be employed");
	
}
}