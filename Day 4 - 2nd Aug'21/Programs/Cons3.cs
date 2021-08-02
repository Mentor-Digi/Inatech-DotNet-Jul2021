using System;
class Cons3
{
int num1,num2;
public Cons3()
{
num1 = 500;
Console.WriteLine("Default Constructor has assigned the value");
}

public Cons3(int n1)
{
num1 = n1;
Console.WriteLine("Cons with n1 is invoked");
}

public Cons3(int num1, int num2)
{
this.num1 = num1;
this.num2 = num2;
Console.WriteLine("Additional COnstructor" + (num1+num2));

}
public static void Main()
{
Cons3 obj = new Cons3();
Console.WriteLine(obj.num1);
Console.WriteLine("Enter a number");
int n = Convert.ToInt32(Console.ReadLine());
Cons3 obj1 = new Cons3(n);
Console.WriteLine(obj1.num1);

Cons3 obj2 = new Cons3(22,44);

}
}