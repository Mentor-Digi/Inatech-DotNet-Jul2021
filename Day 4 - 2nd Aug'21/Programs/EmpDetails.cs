using System;
class Address
{
public String bName;
public String aLine; 
public string city;
public Address(string bn, string al, string cy)
{
bName = bn;
aLine = al;
city = cy;
}
}
class EmpDetails
{
String EmpName;
int age;
public Address adobj;
public EmpDetails(string ename, int eage, Address address)
{
EmpName = ename;
age = eage;
adobj = address;
}
public void DisplayDetails()
{
Console.WriteLine($"Employees Name : {EmpName} and Lives in : {adobj.aLine}");
}
public static void Main()
{
Address adj = new Address("TCR","10, Janpath Street", "New Delhi");
EmpDetails eobj = new EmpDetails("Kiran", 21, adj);
/*Console.WriteLine($"Employee's name is {eobj.EmpName}");
Console.WriteLine($"Employee's age is {eobj.age}");
Console.WriteLine($"Employee lives in {adj.bName}");*/
eobj.DisplayDetails();
}

}







