using System;
abstract class Diet
{
public abstract void foodRestriction();
public void simpleMethod()
{
Console.WriteLine("Ordinary method in abstract class");
}
}
class Diabetes: Diet
{
public void display()
{
Console.WriteLine("Diabetessssss");
}
public override void foodRestriction()
{
Console.WriteLine("No whitesugar and less of carbohydrates");
}
}
class hyperTension:Diet
{
public override void foodRestriction()
{
Console.WriteLine("Reduce oil, fat and salt");
}
}
class AbsProg
{
public static void Main()
{
Diabetes obj = new Diabetes();
obj.display();
obj.foodRestriction();
obj.simpleMethod();
//Diet dbj = new Diet();
}
}
