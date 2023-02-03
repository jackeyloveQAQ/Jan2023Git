using SampleAppFriday.Contracts;
using SampleAppFriday.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppFriday.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public StudentRepository()
        {

        }

        public int DeleteById(int id)
        {
            throw new NotImplementedException();
            //db.SaveChanges();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Student obj)
        {
            throw new NotImplementedException();
            //db.SaveChanges();
        }

        public int Update(Student obj)
        {
            throw new NotImplementedException();
            //db.SaveChanges();
        }
    }
}
