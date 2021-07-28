using System;
class IntString
{
public static void Main()
{
Console.WriteLine("Please give us your Name");
String name = Console.ReadLine();

Console.WriteLine("How old are you?");
int age = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Thanks for joining us today");
Console.WriteLine(name + " Welcome to this program ");
Console.WriteLine("You are "+ age + " years old");

}
}