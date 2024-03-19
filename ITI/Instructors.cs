using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.ITI
{
    public class Instructors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public double Bouns {  get; set; }
        public double Salary { get; set;}
        public double Hour_Rate { get; set;}
        public int Dep_Id {  get; set; }
     }
}
