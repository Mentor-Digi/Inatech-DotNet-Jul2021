using System;
class Cflowx
{
public static void Main()
{
String grad ="";
Console.WriteLine("enter age");
int age = Convert.ToInt32(Console.ReadLine());
if(age>=21)
{
Console.WriteLine("are you a graduate?");
grad = Console.ReadLine();
}
if (age>=21 && grad =="Yes")
{
Console.WriteLine("eligible");
}
else
{
Console.WriteLine("Not eligible");
}
}
}