using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class InstructorExamResultDto
    {
        public string ExamName { get; set; }
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        public int Score { get; set; }
    }
}
