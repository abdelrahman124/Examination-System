using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExamination.Models
{
    public class StudentSubject
    {
       
        public int subjectId { get; set; }
        public int studentId { get; set; }
        public int Grade { get; set; }
        public virtual Students Student { get; set; } = null!;
        public virtual Subjects Subject { get; set; } = null!;




    }
}
