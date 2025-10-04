using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class UserSubject
    {
        public int UserId { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual User User { get; set; }


    }
}
