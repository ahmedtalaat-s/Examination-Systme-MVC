using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Contracts
{
    public interface IStudent
    {
        List<Exam> GetAvailableExams(int studentId, string examType);
        Exam SelectExam(int studentId, int examId);
        bool CanEnterExam(Exam exam);
    }
}
