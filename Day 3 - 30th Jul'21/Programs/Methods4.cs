using System;
class Methods4
{
public string Show(String name)
{
Console.WriteLine("Welcome " + name);
return name;
}
public static void Main()
{
Methods4 obj = new Methods4();
String str = obj.Show("Rinku");
Console.WriteLine("Printing from Main() " + str);
}
}