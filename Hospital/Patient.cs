using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Hospital
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }

        public  int Con_Id { get; set; }
        public  int Ward_Id { get; set; }

    }
}
