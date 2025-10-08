using BL.Contracts;
using BL.Services;
using DAL;
using DAL.ExaminationnContext;
using ExaminationSystem.Admin;
using ExaminationSystem.Instructor;
using ExaminationSystem.Student;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace ExaminationSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // ????? ??????? ????? ??????? (????? DPI ...)
            ApplicationConfiguration.Initialize();

            // 1?? ????? ServiceCollection (?? ??? Container ???? ????? ???? ??? Dependencies)
            var services = new ServiceCollection();

            // 2?? ????? ??? DbContext (ExaminationContext)
            services.AddDbContext<ExaminationContext>();

            // 3?? ????? ??????? (Services)
            services.AddScoped<IAuthentications, AuthenticationService>();
            services.AddScoped<IAdmin, AdminService>();
            services.AddScoped<ITeacher, TeacherService>();
            services.AddScoped<IStudent, StudentService>();
            

            // 4?? ????? ??? Forms ???? ????????
            services.AddScoped<LoginForm>();
            services.AddScoped<ExamList>();
            services.AddScoped<ManageUser>();
            services.AddScoped<AdminMainPage>();
            services.AddScoped<SubjectManagement>();
            services.AddScoped<StudentMainPage>();
            services.AddScoped<AddSubject>();


            // 5?? ???? ServiceProvider (???? ????? ???? ??????? ????????)
            var serviceProvider = services.BuildServiceProvider();

            // 6?? ??????? ??? Form ??????? (LoginForm) ?? ???? ??? DI
            var loginForm = serviceProvider.GetRequiredService<LoginForm>();
            //var loginForm = serviceProvider.GetRequiredService<AddUser>();
            //var loginForm = new AddExam();
            Application.Run(loginForm);
        }
    }
}
