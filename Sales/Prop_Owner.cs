using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Sales
{
    public class Prop_Owner
    {
        [ForeignKey("Owner")]
        public int Own_Id { get; set; }
        public Owner Owner { get; set; }
        [ForeignKey("Property")]
        public int Prop_Id { get; set; }
        public Property Property { get; set; }

        public double Percent { get; set; }
    }
}
