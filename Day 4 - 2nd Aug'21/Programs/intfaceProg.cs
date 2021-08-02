using System;
interface idiagnose
{
void bloodTest();
void Xray();
}
interface iCovid19
{
void rtpcr();
}
class Diabetes:idiagnose, iCovid19
{
public void bloodTest()
{
Console.WriteLine("Fasting sample");
}
public void Xray()
{
Console.WriteLine("Get a chest X-Ray");
}
public void rtpcr()
{
Console.WriteLine("Do a swab test");
}
}

class intfaceProg
{
public static void Main()
{
Diabetes dobj = new Diabetes();
dobj.bloodTest();
dobj.Xray();
dobj.rtpcr();
}
}