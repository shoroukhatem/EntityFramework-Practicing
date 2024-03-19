using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Hospital
{
    public class Drug
    {
        [Key]
        public int Code { get; set; }
        public double Dosage { get; set; }
    }
}
