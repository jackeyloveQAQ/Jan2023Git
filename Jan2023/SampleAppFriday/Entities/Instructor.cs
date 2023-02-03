using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppFriday.Entities
{
    public class Instructor :Person
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public int Salary { get; set; }
        public override string Address { get; set; }
        public override int Age { get; set; }
        public string Title { get; set; }
        public int DepartmentId { get; set; }
        
        //Navi
        public List<Course> Courses { get; set; }
        public Department DepartmentType { get; set; }
    }
}
