using System;

class userInput
{
	public static void Main()
	{
		Console.WriteLine("Enter value of A: ");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter value of B: ");
		int b = Convert.ToInt32(Console.ReadLine());
		int sum = a + b;
		Console.WriteLine("Sum of A and B is: " + sum);
	}
}