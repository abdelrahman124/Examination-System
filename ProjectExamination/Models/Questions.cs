using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExamination.Models
{
    public class Questions
    {
        public int QuestionsId { get; set; }
        public string Qbody { get; set; }
        public int Mark { get; set; }
        public int Model_Answer { get; set; }
        [ForeignKey("Exams")]
        public int Examsid { get; set; }

        public virtual Exams Exam { get; set; } = null!;



    }
}
