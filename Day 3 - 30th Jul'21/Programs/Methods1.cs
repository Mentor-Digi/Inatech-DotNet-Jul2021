using System;
class Methods1
{
public void Display()
{
Console.WriteLine("Exploring how to write methods in C#");
}
public static void Main()
{
//object
//Datatype var
Methods1  obj = new Methods1();
obj.Display();
obj.Display();
Methods1 obj2 = new Methods1();
obj2.Display();
}
}