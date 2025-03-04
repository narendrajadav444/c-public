using System;
class xyz{
	int a;
	int b;
	public xyz(){
		fun(10,20);
	}
	public void fun(int x, int y){
		a = x;
		b = y;
	}
	public static void Main(){
		xyz obj1 = new xyz();
		int sum = obj1.a + obj1.b;
		Console.WriteLine("Sum of A and B: " + sum);
	}
}