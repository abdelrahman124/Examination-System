using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExamination.Models
{
    public class Login
    {
        public int LoginId { get; set; }
        public string Lname { get; set; }
        public string LPassword { get; set; }
        public int StudentsId { get; set; }


        public virtual Students Student { get; set; } = null!;


    }
}
