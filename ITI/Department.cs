using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.ITI
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Hiring_Date { get; set; }
        public Instructors Manager { get; set; }
        [ForeignKey("Manager")]
        public int Ins_Id { get; set; }
        public List<Student> Students { get; set; }
        public List<Instructors> Instructors { get; set; }
    }
}
