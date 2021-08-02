using System;
class Cons1
{
public Cons1()
{
Console.WriteLine("Constructor Invoked");
}
public void Display()
{
Console.WriteLine("TRying to understand  Constructor");
}
public static void Main()
{
Cons1 obj  = new Cons1();
//obj.Display();//Explicit invoke
Cons1 obj1  = new Cons1();
Cons1 obj2  = new Cons1();
Cons1 obj3  = new Cons1();
Cons1 obj4  = new Cons1();
}
}