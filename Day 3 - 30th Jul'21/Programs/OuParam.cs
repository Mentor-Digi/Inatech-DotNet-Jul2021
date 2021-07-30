using System;
class OuParam
{
public int Sum(int num1, int num2, out int res)
{
res = num1+num2;
return res;
}
public static void Main()
{
int rsult;
OuParam obj = new OuParam();
obj.Sum(25,45, out rsult);
Console.WriteLine(rsult);
}
}