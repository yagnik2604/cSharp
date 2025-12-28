using System;
using System.Collections.Generic;

namespace LinqBasics
{

    //==============Customer class================
    /*
      this is a class(type definition / blueprint)
      it does not hold data by itself
    */
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
               LINQ = language itegrated query
               which is use to query the data directly in c# using common syntax
               what kinds of data LINQ query ?
                 1. array
                 2. lists
                 3. dictionaries
                 4.object(in-memmory)
                 5.database(EF core)
                 6.XML / JSON

                 In real project, LINQ is mostly used in:
                    1.service layer
                    2. business logic
                    3. API response shaping
                    4. validaton and reporting

            */

            // ===========understanding this data ==================
            var customers = new List<Customer>
          {
            //List of named objects (Customer) created using object initializer syntax
        new Customer { Id = 1, Name = "Amit" },
        new Customer { Id = 2, Name = "Ravi" }
    /* 
    why new :
    👉 We write new because we are creating objects in memory.
         Without new, no object exists, so there is no data.
       
        means:
           “Create a new object (instance) in memory and return its reference.”
            
            so when you write:
                 new Customer{id = 1, Name ="yagnik"}

            c# does three things behind the scense
                1.allocate memmory in heap
                2.create a Customer object
                3.Sets Id and Name

    think like
        List<Customer> means:
            "this list can store Customer objects(list store objects)"
        
        but at the start:
           * there are no Customer object
           * only type definition
        so we must create actual object using new.
       */
};
            /*
               this is called:
                    obeject initialzer with named typed
                    Custmer -> named class
                    Order -> maned class
                    Object are created using {prototype = value} syntax
            */
    //===============simple output(proof object exist)===============
            foreach (var Customer in customers)
            {
                Console.WriteLine($"id: {Customer.Id}, NAme: {Customer.Name}");
            }
        
        }


    }
}

/*
  🔑 final mental model:
    
    Customer class -> created at compile time (blueprint)
    new Customer() -> object created at runtime ( real data)
    List<Customer> -> store reference to Customer objects
*/



