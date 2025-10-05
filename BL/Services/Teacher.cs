using DAL.ExaminationnContext;
using Microsoft.EntityFrameworkCore;
using Domains;

namespace BL.Services;

public class TeacherService : ITeacherService
{
    private readonly ExaminationContext _context;

    public TeacherService(ExaminationContext context)
    {
        _context = context;
    }

    public Exam GetById(int id)
    {
        var exam = _context.Exams.Find(id);

        if (exam is null)
            return null!;

        return exam;
    }

    public IEnumerable<Exam> GetAll()
    {
        var exams = _context.Exams.ToList();

        if (exams is null)
            return null!;

        return exams;
    }

    public void CreateExam(Exam exam)
    {
        _context.Exams.Add(exam);
        _context.SaveChanges();
    }

    public void EditExam()
    {
        throw new NotImplementedException();
    }

    public void DeleteExam()
    {
        throw new NotImplementedException();
    }
}