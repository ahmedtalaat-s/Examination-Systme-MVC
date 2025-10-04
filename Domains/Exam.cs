using System;
using System.Collections.Generic;
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

    }
}
