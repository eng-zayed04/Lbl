using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lbl.Model.Migrations;
using Lbl.Repository;

namespace Lbl.Service
{
    public class StudentService
    {
        public bool Add(Student student)
        {
            StudentRepository repository = new StudentRepository();
            return repository.Add(student);
        }
    }
}
