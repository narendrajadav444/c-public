using System;

class Student{
	int id;//data member(also instance variable)
	string name;//data member()also instance variable)
	public static void Main(string[] args){
		Student s1 = new Student();//creating an object of Student
		s1.id = 384;
		s1.name = "Narendra Jadav";
		Console.WriteLine("Student ID is: "+s1.id);
		Console.WriteLine("Student Name is: "+s1.name);
		Console.ReadLine();
}
}