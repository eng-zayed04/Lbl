using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lbl.Model.Teachers
{
    public class Teacher : Entity
    {
        [Index]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Index]
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
    }
}
