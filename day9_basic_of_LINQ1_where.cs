using System;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }

    public int Age { get; set; }
    public decimal Salary { get; set; }

}

class Program
{
    static void Main(string[] args)
    {

        var employees = new List<Employee>
{
    new Employee { Id = 1, Name = "Amit", Department = "IT", Age = 25, Salary = 40000 },
    new Employee { Id = 2, Name = "Ravi", Department = "HR", Age = 30, Salary = 35000 },
    new Employee { Id = 3, Name = "Neha", Department = "IT", Age = 28, Salary = 50000 },
    new Employee { Id = 4, Name = "Pooja", Department = "Finance", Age = 35, Salary = 60000 },
    new Employee { Id = 5, Name = "Karan", Department = "IT", Age = 22, Salary = 30000 }
};

        var itEmployees = employees.Where(e => e.Department == "IT").ToList();
        
        // multiple conditions (AND(&&) / OR(||))
        var seniorIT = employees
                                .Where(e => e.Department == "IT" && e.Age >= 28).ToList(); 
        
        // filter using calculation
        var highErners = employees
                                  .Where(e => e.Salary * 0.8 > 35000).ToList();
       
        // filter using collection method
        var containA = employees
                                      .Where(e => e.Name.Contains("a")).ToList();

        // filter using NULL / EMPTY check
        var validEmployees = employees
                                      .Where(e => !string.IsNullOrEmpty(e.Department)).ToList();
        
        // filter using index (* pagination,  * sampling data)
        var evenIndex = employees
                                 .Where((e, index) => index % 2 == 0).ToList();

        // chain multiple where ( readability)
        var result = employees
                              .Where(e => e.Department == "IT")
                              .Where(e => e.Age > 25)
                              .Where(e => e.Salary *0.8 >35000)
                              .ToList();

        // conditional where( dynamic filter) 
        string deptFilter = "IT"; // usage: search APIs, optional query params
        var filtered = employees
                                .Where(e => deptFilter == null || e.Department == deptFilter).ToList();

        // where with custom predicate method
        static bool IsHighSalary(Employee e)
        {
            return e.Salary >45000;
        }
        var richEmployees = employees
                                     .Where(IsHighSalary).ToList();

        // real project example(service layer)
          int budget = 1000000;
          var eligibleEmployees = employees
                                           .Where(e => e.Department == "IT")
                                           .Where(e => e.Age >= 25)
                                           .Where(e => e.Salary <= budget)
                                           .select(e => new
                                           {
                                               e.Name,
                                               e.Salary
                                           }).ToList();  
                                                                      
        
        // traversal of result list
        foreach (var emp in itEmployees)
        {
            Console.WriteLine($"{emp.Name} - {emp.Department}");
        }

    }
}

/*
 e => e.Department == "IT"  is called predicate
 
 A predicate is:
           A function that check condition and return TRUE or FALSE
           
*/

//------------------------------------===================================--------------------------

/*
   'Where' => where is filtering method
    "should i keep this item or not"
    so where needs rules that returns:
               * true -> keep it
               * false-> discard it

    exmple:
    var itEmployees = employees.Where(e => e.Department == "IT").ToList();
    
    //------------====step2====------------------------
    what does e mean?
         e is just varilable name
         it represent one employee at a time
         LINQ will assign it automatically

         .where(employee => employee.Department =="IT")

    //--------------------=====step3======----------------
    what does => mean?
     this is a lambda operator(=>)
     read it as:
           "For e, do thuis ..."
     so this means:
      "For each employee e, check something"
    
    //--------------====step4==-------------------
    what does e.Department == "IT" do?
     access Department of current employee
     compare it with "IT"
     result is true or false

     amit ->IT    -> true
     ravi ->hr    -> false

     //----------=====step5======---------------
     combine everything
      .where(e=>e.Department=="IT")
        read it like this:
          "Go through each employee e,
           keep only those employee whose department is IT. "
        

*/