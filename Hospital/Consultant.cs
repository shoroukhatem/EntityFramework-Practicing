using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Hospital
{
    public class Consultant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
