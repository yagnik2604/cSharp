using System;

class Car
{
     public string brand;
     public string model;
     public int price;

     public void display()
    {
        Console.WriteLine("car brand :" + brand);
        Console.WriteLine("car model :" + model);
        Console.WriteLine("car price :" + price);

    }
}

class Program
{
     static void Main(string[] args)
    {
        
        Car car1 = new Car();
        car1.brand = "toyota";
        car1.model = "fortuner";
        car1.price = 35000000;

        car1.display();

        Car car2 = new Car();
        car2.brand = "BMW";
        car2.model = "X5";
        car2.price = 9000000;
        car2.display();
    }
}