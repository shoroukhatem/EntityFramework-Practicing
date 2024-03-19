using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Hospital
{
    public class Drug_Brand
    {
        public Drug Drug { get; set; }
        [ForeignKey("Drug")]
        public int Code { get; set; }
        public string Brand { get; set; }
    }
}
