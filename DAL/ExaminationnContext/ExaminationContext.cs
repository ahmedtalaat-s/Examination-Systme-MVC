using Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL.ExaminationnContext
{
    public class ExaminationContext:DbContext
    {
        public ExaminationContext() { }

        public virtual DbSet<Choices> Choices { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<StudentAnswers> StudentAnswers { get; set; }
        public virtual DbSet<UserSubject> UserSubjects { get; set; }
        public virtual DbSet<UserTakeExam> UserExams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ExaminationProject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }

        //DESKTOP-I33LVHG\\SQLEXPRESS
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExaminationContext).Assembly);
        }

    }
}
