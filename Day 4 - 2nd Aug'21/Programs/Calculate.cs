using System;
class Arithmetic
{
int num1, num2;
public Arithmetic(int num1, int num2)
{
this.num1 = num1;
this.num2 = num2;
}
public void add()
{
Console.WriteLine(num1+num2);
}
public void sub()
{
Console.WriteLine(num1-num2);
}
}
class Calculate:Arithmetic
{
public Calculate(int n1, int n2):base(n1,n2)
{

}
public static void Main()
{
Calculate obj = new Calculate(2,4);
obj.add();
}
}