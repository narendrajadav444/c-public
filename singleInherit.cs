using System;
class person{
	public void display(){
		Console.WriteLine("Display called");
	}
	public static void display2(){
		Console.WriteLine("Display2 called");
	}
}
class NJ:person{
	public void fun(){
		Console.WriteLine("NJ");
	}
}
class demo{
	public static void Main(string[] args){
		Console.WriteLine("Hii");
		NJ n1 = new NJ();
		n1.display();
		//n1.display2();
		n1.fun();
		Console.WriteLine("Hello");
	}
}