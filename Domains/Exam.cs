using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string ExamName { get; set;}
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public string ExamType { get; set; }
        public Status Status { get; set;}

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }


        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual List<UserTakeExam> UserExams { get; set; } = new List<UserTakeExam>();
        public virtual List<Report> Reports { get; set; } = new List<Report>();
        public virtual List<Questions> Questions { get; set; } = new List<Questions>();

    }
}
