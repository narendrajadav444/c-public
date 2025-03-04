using System;
class person{
	public void display(){
		Console.WriteLine("1st called.");
	}
}
class nj:person{
	public void display(){
		Console.WriteLine("called.");
	}
}
class demo{
	public static void Main(){
		nj n1 = new nj();
		n1.display();
	}
}