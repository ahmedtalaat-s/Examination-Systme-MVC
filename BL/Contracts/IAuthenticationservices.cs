using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Domains;

namespace BL.Services;

public interface IAuthenticationservices
{
    User login(string email, string password);
    (bool status, string messageError)  register(User user, List<int> subjects);

}