using Domain.Models;
using Ifrastructure.Services;

while (true)
{
    Console.WriteLine("Kadom serverro mekhohed? ");
    string n = Console.ReadLine();
    if (n == "stop") break;
    if (n== "department")
    {
        var departmentService=new DepartmentService();
        Console.WriteLine("Chi kor kardan mekhohed ? ");
        string s=Console.ReadLine();    
        while (true)
        {
            if (s == "stop") break;
            if (s=="get")
            {
                Console.WriteLine();
               var employee=new EmployeeService().GetEmployees();
                foreach (var emp in employee)
                {
                    Console.WriteLine(emp.FirstName + " "+ emp.LastName+" "+ "\n"+emp.Department.Description +" "+emp.Experiences.);

                }
            }

        }

    }
}