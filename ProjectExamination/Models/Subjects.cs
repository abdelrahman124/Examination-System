using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExamination.Models
{
    public class Subjects
    {
        public int SubjectsId { get; set; }
        public string Subname { get; set; }

        public virtual Exams Exam { get; set; } = null!;
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; } = new List<StudentSubject>();



    }
}
