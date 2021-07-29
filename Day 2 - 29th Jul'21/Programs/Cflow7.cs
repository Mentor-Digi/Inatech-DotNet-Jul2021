using System;
class Cflow7
{
public static void Main()
{
int count;
count = 25;
while(count<50)
{
Console.WriteLine(count);
count++;
}

do
{
Console.WriteLine(count);
count--;
}
while(count>25);
//interpolation
Console.WriteLine("the final value of the variable count is {0}",count);
Console.WriteLine($"the final value of the variable count is {count}");

}
}







