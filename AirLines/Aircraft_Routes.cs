using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.AirLines
{
    public class Aircraft_Routes
    {
       public Aircraft Aircraft { get; set; }
        [ForeignKey("Aircraft")]
        public int AC_Id { get; set; }
       public Route Route { get; set; }
        [ForeignKey("Route")]
        public int Route_Id { get; set; }
        public DateTime Departure { get; set; }
        public int Num_Of_Pass { get; set; }
        public double Price { get; set; }
        public DateTime Arrival { get; set;}
    }
}
