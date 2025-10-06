using DAL.ExaminationnContext;
using Microsoft.EntityFrameworkCore;
using Domains;

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
    public List<Exam> GetAll()
    {
        try
        {
            return _context.Exams.ToList();
        }
        catch (Exception ex) 
        {
            throw new Exception(ex.Message);
        }
    }

   
}