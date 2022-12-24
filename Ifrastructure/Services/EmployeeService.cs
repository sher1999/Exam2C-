using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Ifrastructure.Services
{
    public class EmployeeService
    {
        private List<Employee> employees;
        public EmployeeService()
        {
            employees = new List<Employee>();
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }
        public void Update(Employee employee, int id)
        {
            var employe = employees.Find(t => t.FirstName == employee.FirstName);

            if (employee == null) return;
        
        }
        public Employee GetEmployeetById(int id)
        {
            Employee employee = employees.Find(x => x.Id == id);
            return employee;


        }
        public void Delete(int id)
        {
            Employee employee = employees.Find(x => x.Id == id);
            return;
        }
        public int Count()
        {
            int count = employees.Count();
            return count;
        }
    }
}
