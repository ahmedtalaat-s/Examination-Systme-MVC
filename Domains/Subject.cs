using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public virtual List<UserSubject> UserSubjects { get; set; }
        public virtual List<Exam> Exams { get; set; } = new List<Exam>();
    }
}
