using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lbl.Model.Teachers;
using Lbl.Service;

namespace Lbl.Server.Controllers
{
    public class TeacherController : ApiController
    {
        public IHttpActionResult Post(Teacher teacher)
        {
            TeacherService service = new TeacherService();
            var add = service.Add(teacher);
            return this.Ok(add);
        }
    }
}
