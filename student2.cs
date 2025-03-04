using System;

class Student2{
	int id;//data member(also instance variable)
	string name;//data member()also instance variable)
	public void fun(){
		id = Convert.ToInt32(Console.ReadLine());
		name = Console.ReadLine();
		Console.WriteLine("Student ID is: " + id);
		Console.WriteLine("Student Name is: " + name);
	}
	public static void Main(string[] args){
		Student2 s1 = new Student2();//creating an object of Student
		Student2 s2 = new Student2();//creating an object of Student
		s1.fun();
		s2.fun();
		Console.ReadLine();
}
}