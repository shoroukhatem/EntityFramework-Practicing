using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.AirLines
{
    public class AirLine
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }

        public string Address { get; set; }
        public string? Cont_Person { get; set; }
        public List<Aircraft> Aircrafts { get; set; }
        public List<Airline_Phones> Airline_Phones { get; set; }

        public List<Transaction> Transactions { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
