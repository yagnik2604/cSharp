using System;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }

    public int Age { get; set; }
    public decimal Salary { get; set; }

}

class EmployeeDto
{
     public string Name { get; set;}
     public decimal Salary { get; set;}
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
    
    //select sinle peroperty
    var names = employees
                        .Select(e => e.Name).ToList();
    
    // select with calculation(transformation)
    var updatedSalary = employees
                                 .Select(e => e.Salary *1.1m).ToList();

    // select into anonymous type(use heavily in -> API responses, service layer, reporting)
    var card = employees
                        .Select(e => new
                        {
                            e.Name,
                            e.Age
                        }).ToList();

    foreach(var v in card)
        {
            Console.WriteLine(v);
        }                    
    
    // select to modify data
    var updated = employees
                           .Select(e => new Employee
                           {
                               Id = e.Id,
                               Name = e.Name,
                               Department = e.Department,
                               Age = e.Age,
                               Salary = e.Salary + 5000
                           }).ToList(); 
    foreach(var emp in updated)
        {
            Console.WriteLine($"{emp.Id} | {emp.Name} | {emp.Department} | {emp.Age} | {emp.Salary}");
        }

    // selection into DTO/ Custom class(best practice)
     var result = employees
                           .Select( e => new EmployeeDto
                           {
                               Name = e.Name,
                               Salary = e.Salary
                           }).ToList();

      
    }
}
/*
   'select' mean choose/transform data
         * 'where' decides which records
         * 'select' decides what data
        
        .select(item => expression)
          -takes one item
          - return something new
          -thay "something" becomes the new collection

         select always return a new aequence
*/