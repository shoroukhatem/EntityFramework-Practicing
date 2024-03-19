using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Sales
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Sales_Office Office { get; set; }
        [ForeignKey("Office")]
        public int Off_Number { get; set; }
    }
}
