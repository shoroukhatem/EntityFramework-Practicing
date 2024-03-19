using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.AirLines
{
    public class Route
    {
        public int Id { get; set; }
        public double Distance { get; set; }
        public string Destination {  get; set; }
        public string Origin {  get; set; }
        public string? Classification {  get; set; }




    }
}
