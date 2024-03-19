using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.ITI
{
    public class Student_Course
    {
        public Student Student { get; set; }
        [ForeignKey("Student")]
        public int Stud_Id { get; set; }
        public Course Course { get; set; }
        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        public double Grade { get; set; }

    }
}
