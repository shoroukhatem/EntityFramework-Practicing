using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.ITI
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Course> courses { get; set; }
    }
}
