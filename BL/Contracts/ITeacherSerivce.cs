using Domains;

namespace BL.Services;

public interface ITeacherService
{
    void CreateExam(Exam exam);
    void EditExam();
    void DeleteExam();
    Exam GetById(int id);
    IEnumerable<Exam> GetAll();
}