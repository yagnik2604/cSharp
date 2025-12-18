
using System;


//A delegate is a type-safe reference to a method.
// Delegate = variable that stores a method
/*
namespace Delegate
{

    public delegate int Calulate(int a, int b);

    class Calulator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Calulator ch = new Calulator();

            Calulate op = ch.Add;

            int result = op(10, 20);
            Console.WriteLine(result);
        }
    }

}  */


// Delegate as Method Parameter (Real Use Case)
namespace Delegate
{

    public delegate int Calulate(int a, int b);

    class Calulator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    
    class MathEngine
    {
          public int Execute(int a, int b, Calulate ch)
        {
              return ch(a, b);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
           Calulator cl = new Calulator();
           MathEngine engine = new MathEngine();
      
           int r1 = engine.Execute(10, 5, cl.Add);
           int r2 = engine.Execute(10, 5, cl.Multiply);

           Console.WriteLine(r1);
           Console.WriteLine(r2);
        }
    }

} 