using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.AirLines
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public string BD_Year { get; set; }
        public string BD_Month { get; set; }
        public string BD_Day { get; set; }
        public int AL_ID { get; set; }
        public List<Emp_Qualifications> EmpQualifications { get; set; }

    }
}
