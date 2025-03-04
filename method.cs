using System;

class xyz{
	public int sum(){
		Console.Write("Enter value of A: ");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter value of B: ");
		int b = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Sum of A and B is: "+ (a+b));
		return 0;
	}
	public static void Main(){
		xyz obj = new xyz();
		obj.sum();
	}
}