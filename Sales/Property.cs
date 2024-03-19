using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Sales
{
    public class Property
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Code { get; set; }
        public Sales_Office Office { get; set; }
        [ForeignKey("Office")]
        public int Off_Number { get; set; }

    }
}
