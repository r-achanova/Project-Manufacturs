using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufacturs.Data.Models
{
 public   class Department
    {
        public Department()
        {
            this.Employees = new HashSet<Employee>();
        }
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Employee> Employees { get; set; }


    }
}
