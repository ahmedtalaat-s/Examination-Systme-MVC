using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class StudentAnswers
    {
        [Key]
        public int StudentAnswersId { get; set; }
        public int IsCorrect { get; set; }

        [ForeignKey("Choice")]
        public int ChoiceId { get; set; }
        public virtual Choices Choice { get; set; }

        [ForeignKey("Questions")]
        public int QuestionId { get; set; }
        public virtual Questions Questions { get; set; }

        [ForeignKey("Report")]
        public int ReportId { get; set; }
        public virtual Report Report { get; set; }


    }
}
