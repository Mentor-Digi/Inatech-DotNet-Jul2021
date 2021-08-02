using System;
sealed class Zeeledclass
{
public void add(int num1, int num2)
{
int res = num1+num2;
Console.WriteLine(res);
}
}
class Zealedclass:Zeeledclass
{
public static void Main()
{
Zealedclass zobj = new Zealedclass();
zobj.add(10,20);
}
}