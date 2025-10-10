using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class Report
    {
        [Key]
        public int ReportId { get; set; }
        public int Score { get; set; }
        public int MaxScore { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("Exam")]
        public int ExamId { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual List<StudentAnswers> StudentAnswers { get; set; } = new List<StudentAnswers>();

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }



    }
}
