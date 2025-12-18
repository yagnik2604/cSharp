using System;
class MathHelper
{
    // compile time polymorphism
     public int add(int a, int b)
    {
        return a + b;
    }

    public int add(int a, int b, int c)
    {
        return a+b +c;
    }
    public double add(double a, double b)
    {
        return a + b;

    }
}

// run time polymorphism

class Animal
{
    public virtual void speak()
    {
        Console.WriteLine("animal make sound");
    }
    public virtual void eat()
    {
        Console.WriteLine("animal eat");
    }
}

class Dog: Animal
{  
    public override void speak()
    {   
        Console.WriteLine("dog barks");
    }
    public override void eat()
    {   
        base.eat(); // using base we call super class method 
        Console.WriteLine("first base class method call then i call");
    }
}


class Payment
{
    public virtual void Process()
    {
        Console.WriteLine("Processing general payment");
    }
}

class CreditCard : Payment
{
    public override void Process()
    {
        Console.WriteLine("Processing credit card payment");
    }
}

class UPI : Payment
{
    public override void Process()
    {
        Console.WriteLine("Processing UPI payment");
    }
}

class Program
{
    static void Main(string [] args)
     {
    //     MathHelper m = new MathHelper();
    //     Console.WriteLine(m.add(10,20));
    //     Console.WriteLine(m.add(10,20,30));
    //     Console.WriteLine(m.add(10.10,20.20));

    //  Animal d = new Dog();
    //  d.speak();
    //  d.eat();

    Payment p;

    p = new CreditCard();
    p.Process();

    p = new UPI();
    p.Process();
        
    }
}
