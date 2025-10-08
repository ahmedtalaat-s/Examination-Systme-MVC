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


            services.AddDbContext<ExaminationContext>();

            services.AddScoped<IAuthentications, AuthenticationService>();
            services.AddScoped<IAdmin, AdminService>();
            services.AddScoped<ITeacher, TeacherService>();
            services.AddScoped<IStudent, StudentService>();

            services.AddScoped<LoginForm>();
            services.AddScoped<ExamList>();
            services.AddScoped<ManageUser>();
            services.AddScoped<AdminMainPage>();
            services.AddScoped<SubjectManagement>();
            services.AddScoped<StudentMainPage>();
            services.AddScoped<AddSubject>();

            var serviceProvider = services.BuildServiceProvider();

            var loginForm = serviceProvider.GetRequiredService<LoginForm>();

            Application.Run(loginForm);
        }
    }
}
