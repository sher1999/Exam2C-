using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Experience
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Description { get; set; }
        public string Company { get; set; } 
        public int EmployeeId { get; set; }
    }
}
