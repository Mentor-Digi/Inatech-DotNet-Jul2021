using System;
public class Department
{
private String dtName;
public string deptName
{
	get{return dtName;}
	set{dtName = value;}
}
}

public class Company
{
public static void Main()
{
Department dobj = new Department();
dobj.deptName = "HR";
String dname = dobj.deptName;
Console.WriteLine(dname);
}
}//Property class - getset value
//Access Specifier