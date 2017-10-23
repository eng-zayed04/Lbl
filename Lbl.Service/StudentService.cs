using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lbl.Model.Students;
using Lbl.Repository;
using Lbl.RequestModel;

namespace Lbl.Service
{
    public class StudentService
    {
        private StudentRepository repository;

        public StudentService()
        {
            this.repository = new StudentRepository();
        }

        public bool Add(Student student)
        {
            return repository.Add(student);
        }

        public List<Student> Search(StudentRequestModel request)
        {
            IQueryable<Student> students = repository.Get();
            students = students.Where(x =>
                x.Name.ToLower().Contains(request.Name.ToLower()) && x.Phone.ToLower().Contains(request.Phone));

            students = students.OrderBy(x => x.Modified);

            if (request.OrderBy == "Name")
            {
                students = request.IsAscending ? students.OrderBy(x => x.Name) : students.OrderByDescending(x => x.Name);
            }
            if (request.OrderBy == "Phone")
            {
                students = request.IsAscending ? students.OrderBy(x => x.Phone) : students.OrderByDescending(x => x.Phone);
            }

            students = students.Skip((request.Page-1)*10).Take(request.PerPageCount);

            List<Student> list = students.ToList();
            return list;
        }
    }
}
