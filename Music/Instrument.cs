using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Music
{
    public class Instrument
    {
        [Key]
        public string Name { get; set; }
        public string Key { get; set; }
    }
}
