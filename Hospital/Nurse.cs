using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Hospital
{
    public class Nurse
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Ward Ward { get; set; }
        public int Ward_Id {  get; set; }
    }
}
