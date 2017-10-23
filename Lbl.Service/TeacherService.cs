using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lbl.Model.Teachers;
using Lbl.Repository;

namespace Lbl.Service
{
    public class TeacherService
    {
        public bool Add(Teacher teacher)
        {
            TeacherRepository repository = new TeacherRepository();
            return repository.Add(teacher);
        }
    }
}
