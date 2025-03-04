// Demonstration of One-Dimensional Array
using System;

clas oneDimensionArray{
    public static void Main(){
        // declares a 1D Array of string.
        string[] weekDays;

        // allocating memory for days.
        weekDays = new string[] { "Sun", "Mon", "Tue", "Wed",
                             "Thu", "Fri", "Sat" };

        // Displaying Elements of array
        foreach(string day in weekDays)
            Console.Write(day + " ");
    }
}