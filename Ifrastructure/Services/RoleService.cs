using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Ifrastructure.Services
{
    public class RoleService
    {
        private List<Role> roles;
        public RoleService()
        {
            roles = new List<Role>();
        }
        public List<Role> GetRoles()
        {
            return roles;
        }
        public void Add(Role employee)
        {
            roles.Add(employee);
        }
        public void Update(Role role, int id)
        {

        }
        public Role GetRoleById(int id)
        {
            Role role = roles.Find(x => x.Id == id);
            return role;
        }
        public List<Role> GetRolesByUserId(int id)
        {
            Role role = roles.Find(x => x.Id == id);
            return roles;

        }
        public void Delete(int id)
        {
            var existing = roles.Find(t => t.Id == id);
            if (existing == null) return;
            roles.Remove(existing);
        }
        public int Count()
        {
            int count = roles.Count();
            return count;
        }
    }
}
