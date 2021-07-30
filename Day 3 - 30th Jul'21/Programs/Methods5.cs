using System;
class Methods5
{
public int sum()
{
int num1, num2, res;
num1 = 45;num2 =35;
res = num1+num2;
return res;
}

public void avg(Methods5 mobj) //ClassName Objname
{
int sm = mobj.sum();
double avg = sm/2;
Console.WriteLine("the average value is" + avg);
}
public static void Main()
{
Methods5 obj = new Methods5();
obj.avg(obj);
}
}