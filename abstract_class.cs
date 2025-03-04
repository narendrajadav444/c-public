using System;

abstract class demo
{
	public void fun()
	{
		Console.WriteLine("FUN");
	}
	public abstract void absCls();
}
class xyz:demo
{
	public override void absCls()
	{
		Console.WriteLine("Abstract Class");
	}
}
class main_cls
{
	public static void Main()
	{
		xyz obj = new xyz();
		obj.fun();
		obj.absCls();
	}
}