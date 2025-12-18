using System;

public class Person
{
    public string name;
    public int age;

}

public static class MethodEx
{
    public static bool IsAdult(this Person person)
    {
        return person.age >= 18;
    }
}

class Program
{
    static void Main()
    {
         Person p = new Person();
         p.name = "yagnik";
         p.age = 20;

         bool result = p.IsAdult();
         Console.WriteLine(result);
    }
}


//============== explaination ================================

/* 
if Person class is not public then code return error like
 error CS0051:
 Inconsistent accessibility:
 parameter type 'Person' is less accessible than
method 'MethodEx.IsAdult(Person)' */

/*
why this happen, In c# the core rule(very important)
 Apublic method cannot use less accessible type as a parameter

 Accessibility order:  private < internal < public
  so:
     Person -> internal
     isAdult() -> public
     this is illegal

     in simple term :
        Persion is not visible outside assembly
        so compiler says:
                 how can a public methd accept a type that other can't see?

*/

/*
Fix 1 ( best and simple) : make Person public
   public class Persion
   {
      public int age;
   }

Fix 2(reduce extension method accessibility)
    if Person should stay in internal:

    interanl static class MthodEx
    {
        internal static bool IsAdult(this Persion person){
             return persion.age >= 18;
        }
    }   
*/




// Fix 2 practicle example 

/*
namespace ExtensionMthodDemo
{
    // internal class (default is also internal)
    internal class Person
    {
        public int age;
    }

    internal static class MthosEx
    {
        internal static bool IsAdult(this Person person)
        {
             return person.age >= 18;
        }
    }

    class Program
    {
        static void Main()
        {
            Person p = new Person();
            p.age = 16;

            Console.WriteLine(p.IsAdult()); // False
        }
    }


} */