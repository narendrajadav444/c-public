using System;

namespace boxing{
	class program{
		static void Main(String []args){
			int num = 23;//value type is int and assigned value 23
			object obj = num;//boxing implicit
			Console.WriteLine(num);
			Console.WriteLine(obj);
			Console.ReadLine();
		}
	}
}