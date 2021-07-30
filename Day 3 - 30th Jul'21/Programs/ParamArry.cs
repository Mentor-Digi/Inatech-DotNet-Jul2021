using System;
class ParamArry
{
public void add(int [] marks)//Array as a parameter
{
int res =0;
for(int i =0;i<marks.Length; i++)
res += marks[i];
//res =( res +marks[i]) ;assignment operator
Console.WriteLine("Your total score is {0}", res);
}
public static void Main()
{
ParamArry pabj = new ParamArry();
int [] m = new int[]{99,98,97,96,95};
pabj.add(m);
}
}