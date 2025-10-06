
using DAL.ExaminationnContext;
using Microsoft.EntityFrameworkCore;
using Domains;

namespace BL.Services;

public class AuthenticationService : IAuthentications
{
    private readonly ExaminationContext _context;
    public AuthenticationService(ExaminationContext context) {  _context = context; }
    public User login(string email, string password)
    {
        var user = _context.User.FirstOrDefault(u=>u.Email==email);
        return user;
    }

    public (bool status, string messageError) register(User user, List<int> subjects)
    {
        var existingUser = _context.User.FirstOrDefault(u => u.Email == user.Email);
        if (existingUser != null)
        {
            return (false,"user Alreday Exists");
        }
        try
        {
            _context.User.Add(user);
            var userId = _context.User.FirstOrDefault(u => u.Email == user.Email).UserId;

            foreach (var subjectId in subjects)
            {

            }
            return (true, "User registered successfully");
        }
        catch (Exception ex) { 
            return (false,ex.Message);
        }
    }

   
}


