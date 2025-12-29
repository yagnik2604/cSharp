
/*
an anonymous object is an object without  a class name
   - no class definition
   - created on the spot
   - used when you need temporary data shape

*/
using System;
class Program
{
    static void Main(string[] args)
    {
         var person = new
         {
            Name = "yagnik",
            Age = 22,
            city = "ahmedabad"

         };

         Console.WriteLine(person.Name);
         Console.WriteLine(person.Age);
         Console.WriteLine(person.city);
    }
}