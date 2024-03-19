using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Hospital
{
    public class Nurse_Drug_Patient
    {
        public Nurse Nurse { get; set; }
        [ForeignKey("Nurse")]
        public int Nur_Num { get; set; }
        public Drug Drug { get; set; }
        [ForeignKey("Drug")]
        public int Drug_Code { get; set; }
        public Patient Patient { get; set; }
        [ForeignKey("Patient")]
        public int Pat_Id { get; set; }

        public string Date { get; set; }
        public string Time { get; set; }
        public string Dosage { get; set; }

    }
}
