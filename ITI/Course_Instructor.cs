using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.ITI
{
    public class Course_Instructor
    {
      
        public Course Course { get; set; }
        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        public Instructors Instructors { get; set; }
        [ForeignKey("Instructors")]
        public int Inst_Id { get; set; }
        public double Evaluation { get; set; }
    }
}
