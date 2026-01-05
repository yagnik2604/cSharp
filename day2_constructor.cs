//Default Constructor
class Student
{
    public string Name;
}


//Parameterized Constructor
class Vehicle
{
    public string type;
    public int wheels;

    public Vehicle(string type, int wheel)
    {
        this.type = type;
        wheels = wheel;
    }
}

//-----------------------------------------------------------------------------------
//⭐ 3. Constructor Overloading
// Same constructor name, different parameters.
class Person
{
    public string Name;
    public int Age;

    public Person()                     // no parameters
    {
        Name = "Unknown";
        Age = 0;
    }

    public Person(string name)          // one parameter
    {
        Name = name;
        Age = 0;
    }

    public Person(string name, int age) // two parameters
    {
        Name = name;
        Age = age;
    }
}

//---------------------------------------------------------------------------
// Static Constructor
// Runs only once, automatically, when class loads (not when object is created!).
// Used for:
// ✔ initializing static fields
// ✔ configuration
// ✔ connecting to services

class Test
{
    static Test()
    {
        Console.WriteLine("Static constructor called!");
    }

    public Test()
    {
        Console.WriteLine("Normal constructor called!");
    }
}

//-----------------------------------------------------------------
// Copy Constructor (not built-in, but custom)
// Used to copy values of one object into another.
class Car
{
    public string Brand;
    public int Price;
    public Car(string brand, int price)
    {
        Brand = brand;
        Price = price;
    }
    public Car(Car c)
    {
        Brand = c.Brand;
        Price = c.Price;
    }
}

// base() in constructor
class Parent
{
     public Parent(string name)
    {
         Console.WriteLine("Parent cnstructor called" +" "+ name);

    }
}
class Child : Parent
{    
    //“Before running the Child constructor, call the Parent constructor and pass "Yagnik".”
     public Child():base("yagnik")
    {
        Console.WriteLine("child constructor called");
    }
}

class Program
{
    static void Main(string[] args)
    {

        // Test t1 = new Test();
        // Test t2 = new Test();
        // Static constructor called!
        // Normal constructor called!
        // Normal constructor called!




        // Car c1 = new Car("BMW", 9000000);
        // Console.WriteLine(c1.Brand);
        // Console.WriteLine(c1.Price);

        // Car c2 = new Car(c1);  // copy constructor
         
         var Obj = new Child();

    }
}

/*
    ---------------Constructor Execution Order-------------
      When you create a child object:
          1️⃣ Parent constructor
          2️⃣ Child constructor     Always.

*/
