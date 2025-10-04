using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public virtual List<Exam> Exams { get; set; } = new List<Exam>();
        public virtual List<UserSubject> UserSubjects { get; set; } = new List<UserSubject>();
        public virtual List<UserTakeExam> UserExams { get; set; }= new List<UserTakeExam>();

    }
}
