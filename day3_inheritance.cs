using System;

class Animal
{  
    public int weight;
    public void eat()
    {
        Console.WriteLine("animal are eating");
    }
}

class Dog : Animal
{
     public void bark()
    {
        Console.WriteLine("dog is barking");
    }
     public void size()
    {
        Console.WriteLine("dog size is " + weight);
    }
}
     

class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog();
        d.eat();
        d.bark();
        d.weight = 100;
        d.size();
    }
}