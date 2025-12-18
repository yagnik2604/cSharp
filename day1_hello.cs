
// namespace hello
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//              System.Console.WriteLine("hello");
//         }
//     }
// }

//---------------  another way ----------------------

using System;
namespace hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hellow");
            int x = 10;
            string name = "Alex";
            Console.WriteLine(x + name);
            Console.Write("Enter your city: ");
            string city = Console.ReadLine();
            Console.WriteLine("You live in " + city);

            int age = 18;

            if (age >= 18)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Minor");
            }

            int score = 80;
            if (score >= 90)
                Console.WriteLine("A");
            else if (score >= 80)
                Console.WriteLine("B");
            else
                Console.WriteLine("C");


            Console.WriteLine("enter number");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }
                //When condition depends on one variable → use switch
                // When depends on complex logic → use if

            //--------------------------------------------------------------------
            // for loop
            for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(i);
                }
            //  int i =1; it is block scoped(but still part of method scope)

            // while loop
            int k = 1;
            while (k <= 5)
            {
                Console.WriteLine(k);
                k++;
            }

            // do while loop 
            int j = 1;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j <= 5);

            // break statement 
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }

            // continue statement
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    continue;
                Console.WriteLine(i);
            }



        }
    }
}