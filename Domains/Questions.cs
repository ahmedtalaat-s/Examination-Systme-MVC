using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class Questions
    {
        [Key]
        public int QuestionsId { get; set; }
        public string Body { get; set; }
        public QusetionType QusetionType { get; set; }
        public int Marks { get; set; }
        public string Header { get; set; }

        [ForeignKey("Exam")]
        public int ExamId { get; set; }
        public virtual Exam Exam { get; set; }

        public virtual List<Choices> Choices { get; set; }  = new List<Choices>();
        public virtual List<StudentAnswers> StudentAnswers { get; set; }  = new List<StudentAnswers>();






    }
}
