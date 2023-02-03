using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppFriday.Entities
{
    //Junction Table
    public class StudentCourse
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        //Navigation Properties
        public Student StudentInCourse { get; set; }
        public Course CourseInProgress { get; set; }
    }
}
