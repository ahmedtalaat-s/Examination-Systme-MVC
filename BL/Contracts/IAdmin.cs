using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Contracts
{
    public interface IAdmin
    {
       
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
        List<User> GetAllUsers();
        User GetUserById(int userId);


        void AddSubject(Subject subject);
        void UpdateSubject(Subject subject);
        void DeleteSubject(int subjectId);
        List<Subject> GetAllSubjects();
        Subject GetSubjectById(int subjectId);
    }
}
