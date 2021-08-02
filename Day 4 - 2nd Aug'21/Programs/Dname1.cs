using System;
public class Department
{
private string deptName; //Encapsulation
public void SetName(String name)
{
deptName = name;
}

public String GetName()
{
return deptName;
}

}

class Company
{
public static void Main()
{
Department dobj = new Department();

dobj.SetName("Innovation");
String dname = dobj.GetName();
Console.WriteLine($"The department name is {dname}");
}
}