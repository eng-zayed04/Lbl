using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lbl.RequestModel
{
    public class BaseRequestModel
    {
        public BaseRequestModel()
        {
            this.PerPageCount = 10;
            this.Page = 1;
        }

        public int Page { get; set; }

        public int PerPageCount { get; set; }

        public string OrderBy { get; set; }

        public bool IsAscending { get; set; }
    }
}
