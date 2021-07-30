using System;
class Methods2
{
public void Display(String subject)
{
Console.WriteLine("Writing methods in the language " + subject);
}

public static void Main()
{
Console.WriteLine("Enter your Language");
String lang = Console.ReadLine();
Methods2 mobj1  = new Methods2();
mobj1.Display("C#");
mobj1.Display(lang);

}
}