using DAL.Dtos;
using Domains;

namespace BL.Services;

public interface ITeacher
{
    void CreateExam(Exam exam);
    void EditExam( Exam exam);
    void DeleteExam(int id);
    Exam GetExamById(int id);
    List<Exam> GetAllExams(int instructorId);
    public List<InstructorExamResultDto> GetInstructorExamResults(int instructorId);

    public List<Subject> GetInstructorSubjects(int instructorId);



}