using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Sales
{
    public class Sales_Office
    {
        [Key]
        public int Number { get; set; }
        public string Location { get; set; }

        public Employee Manager { get; set; }
        [ForeignKey("Manager")]
        public int EmpId { get; set; }

        public List<Employee> Employees { get; set; }
        public List<Property> properties { get; set; }


    }
}
