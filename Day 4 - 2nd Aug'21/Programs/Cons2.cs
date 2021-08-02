using System;
class Parent
{
	public Parent()
	{Console.WriteLine("Parent class constructor invoked");}
}
class Child:Parent
{
	public Child()
	{Console.WriteLine("Child class constructor invoked");}
}
class Cons2
{
public static void Main()
{
Child cobj = new Child();
}
}