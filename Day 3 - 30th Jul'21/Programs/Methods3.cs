using System;
class Methods3
{
int num1 = 0;
int num2 = 0;
public void add2Nos(int num1, int num2)
{
this.num1 = num1;
this.num2 = num2;
Console.WriteLine(num1 + num2);
}
public void product2nos()
{
Console.WriteLine(num1*num2);
}
public static void Main()
{
Methods3 obj1 = new Methods3();
obj1.add2Nos(25,35);
Console.WriteLine("Value of num1 in Obj.num1 "+obj1.num1);
Console.WriteLine("Value of num2 in Obj.num2 " + obj1.num2);
obj1.add2Nos(500,700);
Console.WriteLine("Value of num1 in Obj.num1 "+obj1.num1);
Console.WriteLine("Value of num2 in Obj.num2 " + obj1.num2);
Methods3 obj2 = new Methods3();
obj2.add2Nos(567,234);
Console.WriteLine("Value of num1 in Obj2.num1 "+obj2.num1);
Console.WriteLine("Value of num2 in Obj2.num2 "+ obj2.num2);
obj2.num1 = 5;
obj2.num2 = 4;
obj2.product2nos();
Console.WriteLine("Value of num1 in Obj2.num1 "+obj2.num1);
Console.WriteLine("Value of num2 in Obj2.num2 " + obj2.num2);
}
}