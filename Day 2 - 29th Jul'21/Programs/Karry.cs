using System;
class Karry2
{
public static void Main(){
int [,]sdtarry= new int[2,4];
for(int i=0;i<2;i++)
{
for(int j=0;j<4;j++)
sdtarry[i,j]=Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<2;i++)
{
for(int j=0;j<4;j++)
Console.Write(sdtarry[i,j]+"\t");
Console.WriteLine();
}
}
}