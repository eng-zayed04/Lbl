using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lbl.Model.Students;
using Lbl.Service;

namespace Lbl.Server.Controllers
{
    public class StudentController : ApiController
    {
        public IHttpActionResult Post(Student student)
        {
            StudentService service = new StudentService();
            bool add = service.Add(student);
            return this.Ok(add);
        }
    }
}
