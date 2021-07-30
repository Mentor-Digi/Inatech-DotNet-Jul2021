using System;
class ValRef
{
public void add(int num1)
{
num1 = num1+num1;
Console.WriteLine(num1);
}
public void sum(ref int n1)
{
n1 = n1 + n1;
Console.WriteLine(n1);
}
public static void Main()
{
int val = 5;
ValRef vobj = new ValRef();
vobj.add(val);
vobj.add(val);
vobj.add(val);
vobj.add(val);
int rval = 4;
vobj.sum(ref rval);
vobj.sum(ref rval);
vobj.sum(ref rval);
}
}