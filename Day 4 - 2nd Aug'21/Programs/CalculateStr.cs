using System;
class Arithmetic
{
int num1, num2;
public Arithmetic(int num1, int num2)
{ 	this.num1 = num1;
	this.num2 = num2;  
	Console.WriteLine("Base class constructor");	}
public void add()
{
Console.WriteLine(num1+num2);
}
public void sub()
{
Console.WriteLine(num1-num2);
}
}
class CalculateStr:Arithmetic
{
String str;

public CalculateStr(int n1, int n2,String str ):base(n1,n2)
{
this.str = str;
Console.WriteLine("The derived class string is initialized to  "+ str);
}
~CalculateStr()
{
Console.WriteLine("Destructor Invoked");
}
public static void Main()
{
//CalculateStr cobj = new CalculateStr();
CalculateStr obj = new CalculateStr(2,4,"3rd Wave");
obj.add();
}
}


