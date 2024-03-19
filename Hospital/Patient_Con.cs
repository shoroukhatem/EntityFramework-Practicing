using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Hospital
{
    public class Patient_Con
    {
        public Consultant Consultant { get; set; }
        [ForeignKey("Consultant")]
        public int Con_Id { get; set; }
        public Patient Patient { get; set; }
        [ForeignKey("Patient")]
        public int Pat_Id { get; set; }
    }
}
