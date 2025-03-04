using System;

namespace unboxing{
    class Program{
        static void Main(string []args){
            int num = 44; // value type is int and assigned value 44
            object obj = num; // boxing implicit
            int unboxedNum = (int)obj; // unboxing explicit
            Console.WriteLine(num); // 44
            Console.WriteLine(unboxedNum); // 44
            Console.ReadLine();
        }
    }
}
