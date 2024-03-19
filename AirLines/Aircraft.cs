using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.AirLines
{
    public class Aircraft
    {
        public int Id { get; set; }
        public int? Capacity { get; set; }
        public string? Model { get; set; }

        public string? MajPilot { get; set; }
        public string? Assistant { get; set; }
        public string? Host1 { get; set; }
        public string? Host2 { get; set; }

        public int AL_ID {  get; set; }

    }
}
