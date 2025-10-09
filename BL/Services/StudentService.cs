using BL.Contracts;
using DAL.ExaminationnContext;
using Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class StudentService : IStudent
    {
        private readonly ExaminationContext _context;

        public StudentService(ExaminationContext context)
        {
            _context = context;
        }

        //public void EnrollInSubject(int studentId, int subjectId)
        //{
        //    bool alreadyEnrolled = _context.UserSubjects
        //        .Any(us => us.UserId == studentId && us.SubjectId == subjectId);

        //    if (!alreadyEnrolled)
        //    {
        //        var userSubject = new UserSubject
        //        {
        //            UserId = studentId,
        //            SubjectId = subjectId
        //        };

        //        _context.UserSubjects.Add(userSubject);
        //        _context.SaveChanges();
        //    }
        //}

      
        public List<Subject> GetStudentSubjects(int studentId)
        {
            return _context.UserSubjects
                .Include(us => us.Subject)
                .Where(us => us.UserId == studentId)
                .Select(us => us.Subject)
                .ToList();
        }

      
        public List<Exam> GetAvailableExams(int studentId, string examType)
        {
         
            var subjectIds = _context.UserSubjects
                .Where(us => us.UserId == studentId)
                .Select(us => us.SubjectId)
                .ToList();

            return _context.Exams
                .Include(e => e.Subject)
                .Where(e => subjectIds.Contains(e.SubjectId) && e.ExamType == examType)
                .ToList();
        }

       
        public Exam SelectExam(int studentId, int examId)
        {
            var exam = _context.Exams
                .Include(e => e.Questions)
                .ThenInclude(q => q.Choices)
                .FirstOrDefault(e => e.ExamId == examId);

            return exam;
        }

       
        public bool CanEnterExam(Exam exam)
        {
            if (exam.ExamType == "Practice")
                return true; 

            if (exam.ExamType == "Final")
            {
                var now = DateTime.Now;
                var endTime = exam.StartTime.AddMinutes(exam.Duration);

                return now >= exam.StartTime && now <= endTime;
            }

            return false;
        }

        public List<Exam> GetAllPracticeExam()
        {

           return _context.Exams
                .Include(l=>l.Subject)
                .Include(k=>k.Questions)
                .ThenInclude(o=>o.Choices)
                .Where(v=>v.ExamType == "practise")
                .ToList();

        }
    }
}
