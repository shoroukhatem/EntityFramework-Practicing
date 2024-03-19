using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.AirLines
{
    public class Transaction
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public double? Amount { get; set; }
        public DateTime Date { get; set; }
        public int AL_ID { get; set; }
    }
}
