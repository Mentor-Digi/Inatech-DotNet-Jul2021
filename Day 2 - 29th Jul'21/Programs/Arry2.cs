using System;
class Arry2
{
public static void Main()
{
//datatype arrayname [rows , cols]
int [,] tarry = new int [2,3] {{22,23,24},{33,34,35}};
//nested for loop
for(int i =0;i<2;i++)
{
	for(int j=0;j<3;j++)	
	Console.Write(tarry[i,j] + "\t");
Console.WriteLine();
}
int [,] tdarray = new int[2,4];
for(int i=0;i<2;i++)
{
	for(int j=0;j<4;j++)	
	tdarray[i,j] = Convert.ToInt32( Console.ReadLine());
}
Console.WriteLine("Values of TDArray");
for(int i =0;i<2;i++)
{
	for(int j=0;j<4;j++)	
	Console.Write(tdarray[i,j] + "\t");
Console.WriteLine();
}

}
}