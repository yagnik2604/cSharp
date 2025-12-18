
using System;

// Func is a delegate that RETURNS a value
/*
    Func<in1, in2, ..., out>
    ex:- Func<int, int, int> add;
        -> mean: 
                take int,
                take int ,
                return int = LAST type is always the return type 
*/

class Calulator
{
       public int Add(int a, int b)
    {
         return a+b;
    }
}


// Action -> action is delegate that return nothing(void)
/*
   Action<in1, in2,...> no return tyoe
   ex:- Action<string> print;

*/

class printer
{
    public void PrintMessage(string smg)
    {
        Console.WriteLine(smg);
    }
}


// Func & Action with lambda  ( real world example)

class MathEngine
{
      public int Execute(int a, int b, Func<int, int, int> op)
    {
         return op(a, b);
    }
}


class Program
{
    static void Main()
    {   
        // func
        Calulator calc = new Calulator();
        Func<int, int, int> f = calc.Add;
        Console.WriteLine(f(20, 10));

        // action
        printer p = new printer();
        Action<string> action = p.PrintMessage;
        action("hello");

        // real world example

        MathEngine engine = new MathEngine();

        int r1 = engine.Execute(10, 5, (a,b) => a+b);
        int r2 = engine.Execute(10,5,(a,b)=> a*b );

        Console.WriteLine(r1);
        Console.WriteLine(r2);


    }
}

