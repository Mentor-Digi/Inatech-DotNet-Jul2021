using System; 
class Jarray
{
public static void Main()
{
String [][] patName = new String[3][];//declaration of outer array (or) no of arrays
patName[0] = new String[3]{"cat","bat","mat"};
patName[1] = new String[2]{"gun","bun"};
patName[2] = new String[5]{"tip","sip","lip","nip","zip"};
for(int i =0;i<patName.Length;i++)
{
	for(int j=0;j<patName[i].Length;j++)
	Console.Write(patName[i][j] +"\t");
Console.WriteLine();
}
int [] marks = new int[]{98,97,96,95};
int tot =0;
for(int i = 0; i<marks.Length;i++)
	tot = tot+marks[i];
Console.WriteLine(tot);
Console.WriteLine("For Each / Enhanced for loop");
tot =0;
foreach(int i in marks)
	tot = tot+ i;
Console.WriteLine(tot);

}
}



