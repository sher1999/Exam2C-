using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Ifrastructure.Services
{
    public class DepartmentService
    {
        private List<Department> departments;

        public DepartmentService()
        {
            departments = new List<Department>();
        }
        public List<Department> GetDepartments()
        {
            return departments;
        }
        public void Add(Department department)
        {
            departments.Add(department);
        }
        public void Update(Department department, int id)
        {

        }
        public Department GetDepartmentById(int id)
        {
            Department department = departments.Find(x => x.Id == id);
            return department;


        }
        public void Delete(int id)
        {
            var existing = departments.Find(t => t.Id == id);
            if (existing == null) return;
            departments.Remove(existing);
        }
        public int Count()
        {
            int count = departments.Count();
            return count;
        }
    }
}
