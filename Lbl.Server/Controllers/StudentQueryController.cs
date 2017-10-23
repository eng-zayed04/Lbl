using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lbl.Model.Students;
using Lbl.RequestModel;
using Lbl.Service;

namespace Lbl.Server.Controllers
{
    public class StudentQueryController : ApiController
    {
        public IHttpActionResult Post(StudentRequestModel request)
        {
            StudentService service = new StudentService();
            List<Student> students = service.Search(request);
            return this.Ok(students);
        }
    }
}
