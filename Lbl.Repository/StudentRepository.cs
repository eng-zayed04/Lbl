using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lbl.Model;
using Lbl.Model.Students;

namespace Lbl.Repository
{
    public class StudentRepository
    {
        private BusinessDbContext db;

        public StudentRepository()
        {
            this.db = new BusinessDbContext();
        }

        public bool Add(Student student)
        {
            student.Id = Guid.NewGuid().ToString();
            this.db.Students.Add(student);
            int saveChanges = this.db.SaveChanges();
            return saveChanges > 0;
        }
    }
}
