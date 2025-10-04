using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class Choices
    {
        [Key]
        public int ChoicesId { get; set; }
        public bool IsCorrect { get; set; }
        public string Body { get; set; }

        [ForeignKey("Questions")]
        public int QuestionId { get; set; }
        public virtual Questions Questions { get; set; }

        public virtual List<StudentAnswers> StudentAnswers { get; set; } = new List<StudentAnswers>();



    }
}
