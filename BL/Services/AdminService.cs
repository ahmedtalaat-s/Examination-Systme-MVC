using BL.Contracts;
using DAL.ExaminationnContext;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class AdminService:IAdmin
    {
        private readonly ExaminationContext _context;

        public AdminService(ExaminationContext context)
        {
            _context = context;
        }

        public void AddSubject(Subject subject)
        {
            try
            {
                if (subject != null) 
                {
                    _context.Add(subject);
                    _context.SaveChanges();
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Subject GetSubjectById(int id)
        {
            try
            {
                if(id != 0)
                {
                    return _context.Subject.FirstOrDefault(m => m.SubjectId == id);
                }
                return null;
               
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            

        }
        public void DeleteSubject(int subjectId)
        {
            try
            {
                if (subjectId != 0)
                {
                    var subject = GetSubjectById(subjectId);
                    _context.Remove(subject);
                    _context.SaveChanges();
                }


            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Subject> GetAllSubjects()
        {
            try
            {
                return _context.Subject.ToList();
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateSubject(Subject subject)
        {
            try
            {
                if (subject != null)
                {
                    _context.Update(subject);
                    _context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
                
            }
        }




        public void AddUser(User user)
        {
            try
            {
                if (user != null)
                {
                    _context.Add(user);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            
            
        }
        public void UpdateUser(User user)
        {
            try
            {
                if(user != null)
                {
                    _context.Update(user);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
        public User GetUserById(int id)
        {
            if(id != 0)
            {
                return _context.User.FirstOrDefault(k => k.UserId == id);
            }
            else
            {
                return null;
            }
           
        }
        public List<User> GetAllUsers()
        {
            try
            {
                return _context.User.ToList();
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteUser(int userId)
        {
            try
            {
                var user = GetUserById(userId);
                _context.Remove(user);
                _context.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

       
    }
}
