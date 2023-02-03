using SampleAppFriday.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppFriday.Services
{
    
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void AddressChangeForStudent(int id, string address)
        {
            var stud = _studentRepository.GetById(id);
            stud.Address = address;
            _studentRepository.Update(stud);
        }
    }
}
