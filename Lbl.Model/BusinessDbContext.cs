using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lbl.Model.Migrations;

namespace Lbl.Model
{
    public class BusinessDbContext : DbContext
    {
        public BusinessDbContext() : base("DefaultBusinessConnection")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
