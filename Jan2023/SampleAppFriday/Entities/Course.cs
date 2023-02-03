using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppFriday.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InstructorId { get; set; }
        public int DepartmentId { get; set; }
        //Navi Prop
        public Department DepartmentType { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
        public Instructor InstructorOfCourse { get; set; }
    }
}
