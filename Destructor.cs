using System;

class person{
	public void display(){
		Console.WriteLine("called");
		abc();
	}
	public static void abc(){
		Console.WriteLine("ABC called");
	}
}
class dem{
	public static void Main(string[] args){
		Console.WriteLine("Hii");
		person p1 = new person();
		Console.WriteLine("Hello");
	}
}