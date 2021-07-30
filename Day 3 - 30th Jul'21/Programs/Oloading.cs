using System;
class Oloading
{
public void add()
{
int n1, n2;
n1 = 20; n2 =30;
Console.WriteLine(n1+n2);
}
public int add(int n1)
{
Console.WriteLine(n1+n1);
return n1+n1;
}

public void add(int num1, int num2)
{
Console.WriteLine(num1+num2);
}
public void add(int num1, double num2)
{
Console.WriteLine(num1+num2);
}
public void add(double num1, int num2)
{
Console.WriteLine(num1+num2);
}
public static void Main()
{
Oloading obj = new Oloading();
obj.add();
obj.add(40,50);
obj.add(40,50.5);
obj.add(3.4,5);
}
}