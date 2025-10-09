using DAL.ExaminationnContext;
using Microsoft.EntityFrameworkCore;
using Domains;
using DAL.Dtos;

namespace BL.Services;

public class TeacherService : ITeacher
{

    private readonly ExaminationContext _context;
    public TeacherService(ExaminationContext context)
    {
        _context = context;
    }
    public void CreateExam(Exam exam)
    {
        try
        {
            if (exam != null) 
            {
                _context.Add(exam);
                _context.SaveChanges();
            }
        }
        catch (Exception ex) 
        {
            throw new Exception(ex.Message);
        }
    }
    public Exam GetExamById(int id)
    {
        try
        {
            if (id != 0)
            {
                return _context.Exams.FirstOrDefault(j => j.ExamId == id);
            }
            return null;
        }
        catch (Exception ex)
        {
            
            throw new Exception(ex.Message);
            
        }
    }
    public void DeleteExam(int id)
    {
        try
        {
            if (id != 0)
            {
                var exam = GetExamById(id);
                _context.Remove(exam);
                _context.SaveChanges();
            }

        }
        catch (Exception ex) 
        {
            throw new Exception(ex.Message);
        }
      
       
    }
    public void EditExam(Exam exam)
    {
        try
        {
            if (exam != null)
            {
                _context.Update(exam);
                _context.SaveChanges();
            }
        }
        catch (Exception ex)
        {
            
            throw new Exception(ex.Message);
            
        }
    }
    public List<Exam> GetAllExams(int instructorId)
    {
        try
        {
            return _context.Exams.Include(n=>n.Subject).Where(m=>m.UserId == instructorId).ToList();
        }
        catch (Exception ex) 
        {
            throw new Exception(ex.Message);
        }
    }
    public List<InstructorExamResultDto> GetInstructorExamResults(int instructorId)
    {
        var result = (from exam in _context.Exams
                      join studentExam in _context.UserExams on exam.ExamId equals studentExam.ExamId
                      join student in _context.User on studentExam.UserId equals student.UserId
                      join reports in _context.Report on exam.ExamId equals reports.ExamId
                      join subject in _context.Subject on exam.SubjectId equals subject.SubjectId
                      where exam.UserId == instructorId
                      select new InstructorExamResultDto
                      {

                          ExamName=exam.ExamName,
                          StudentName =student.FullName,
                          SubjectName =subject.SubjectName,
                          Score = reports.Score,
                      }).ToList();

        return result;

    }
    public List<Subject> GetInstructorSubjects(int instructorId)
    {
        var subjects = (from userSubject in _context.UserSubjects.Where(m=>m.UserId == instructorId)
                        join subject in _context.Subject on userSubject.SubjectId equals subject.SubjectId
                        select new Subject 
                        {
                            SubjectName = subject.SubjectName,
                            SubjectId = subject.SubjectId,

                        }).ToList();
        return subjects;
    }
    public List<Questions> GetAllQuestion(int examId)
    {
        return _context.Questions.Where(j => j.ExamId == examId).ToList();
        
    }
    public void AddQuestion(int examId, Questions question, List<Choices> choices)
    {
        try
        {
            question.ExamId = examId;


            _context.Questions.Add(question);
            _context.SaveChanges();


            foreach (var choice in choices)
            {
                choice.QuestionId = question.QuestionsId;
            }

            _context.Choices.AddRange(choices);
            _context.SaveChanges();

        }
        catch (Exception ex) 
        {
            throw new Exception(ex.Message);
        }
       

        
    }
    public void DeleteQuestion(int questionId)
    {
        try
        {
            if (questionId != 0)
            {
                var question = _context.Questions.Include(n => n.Choices).FirstOrDefault(k => k.QuestionsId == questionId);
                _context.Remove(question);
                _context.SaveChanges();
            }
        }
        catch (Exception ex) 
        {
            throw new Exception(ex.Message);
        }
    }
}