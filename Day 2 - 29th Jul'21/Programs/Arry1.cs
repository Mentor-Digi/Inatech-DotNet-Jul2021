using System;
class Arry1
{
public static void Main()
{
//datatype [] arrayName  = new datatype[size]
int [] Nos = new int[3];
Nos[0] = 10;
Nos[1] = 20;
Nos[2] = 30;
for(int i=0;i<3;i++)
Console.WriteLine(Nos[i]);
int [] Morenos = new int[]{10,20,30,40,50,60};
for(int i=0;i<Morenos.Length;i++)
Console.WriteLine(Morenos[i]);
string [] names = new string[]{"Ram", "Seetha","Lakshman","Bharat","Hanuman"};
for(int i=0;i<names.Length;i++)
Console.WriteLine(names[i]);
}
}