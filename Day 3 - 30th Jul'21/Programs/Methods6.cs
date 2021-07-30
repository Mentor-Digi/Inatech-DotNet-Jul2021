using System;
class SumMethod
{
public int sum()
{
int num1, num2, res;
num1 = 45;num2 =35;
res = num1+num2;
return res;
}
}
class avgMethod
{
public void avg() 
{
SumMethod obj = new SumMethod();
int sm = obj.sum();
double avg = sm/2;
Console.WriteLine("the average value is" + avg);
}
public static void Main()
{
avgMethod obj = new avgMethod();
obj.avg();
}
}