using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExamination.Models
{
    public class Exams
    {
       
        public int Examsid { get; set; }
        public int Time { get; set; }
        public int QuestionNum { get; set; }
       
        [ForeignKey(nameof(Subjects))]
        public int Subjectid { get; set; }

        public virtual Subjects Subject { get; set; } = null!;

        public virtual ICollection<Questions> GetQuestions { get; set; } = new List<Questions>();

    }
}
