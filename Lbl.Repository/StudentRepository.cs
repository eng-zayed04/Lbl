using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lbl.Model.Students;

namespace Lbl.Repository
{
    public class StudentRepository
    {
        public string Add(Student student)
        {
            student.Id = Guid.NewGuid().ToString();
            return student.Id;
        }
    }
}
