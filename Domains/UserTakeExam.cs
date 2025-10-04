using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class UserTakeExam
    {
        public int UserId { get; set; }
        public int ExamId { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual User User { get; set; }

    }
}
