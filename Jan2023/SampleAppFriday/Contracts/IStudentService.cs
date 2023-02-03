using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppFriday.Contracts
{
    public interface IStudentService
    {
        public void AddressChangeForStudent(int id, string address);
    }
}
