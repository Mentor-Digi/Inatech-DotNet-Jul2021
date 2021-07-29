using System;
class Cflow5
{
public static void Main()
{
String gender;
Console.WriteLine("Please enter your gender");
gender = Console.ReadLine();
switch(gender)
{
case "Male": Console.WriteLine("Male members please go to first floor");
		break;
case "Female":Console.WriteLine("Female members please go to second floor");
	break;
case "Transgender": Console.WriteLine("Members please go to thr club house");
	break;
default: Console.WriteLine("We don't have a category matching yours, please choose Male, Female or Transgender");
	break;
}
}
}