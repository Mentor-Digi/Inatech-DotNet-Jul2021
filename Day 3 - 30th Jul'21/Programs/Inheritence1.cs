using System;
class Father
{
public virtual void health()
{
Console.WriteLine("Good health is all what I have");
}
}
class Son : Father
{
public void wealth()
{
Console.WriteLine("I have accumulated some wealth");
}
}
class gSon: Son
{
public override void health()
{
Console.WriteLine("Good health is all what I have inherited from my grand father");
}
}
class implementClass
{
public static void Main()
{
Son sobj = new Son();
sobj.health(); 
sobj.wealth();
Father fobj = new Father();
fobj.health();
Father fsobj = new Son();
fsobj.health();
/*Son sfobj = new Father();
sfobj.health();
sfobj.wealth();*/
gSon gobj = new gSon();
gobj.health();
}
}