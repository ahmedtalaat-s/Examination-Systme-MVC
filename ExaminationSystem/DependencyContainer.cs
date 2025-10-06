using BL.Contracts;
using BL.Services;
using DAL.ExaminationnContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public static class DependencyContainer
    {
        public static ServiceProvider Configure()
        {
            var services = new ServiceCollection();

            
            // Register Services
            services.AddScoped<IStudent, StudentService>();
            services.AddScoped<IAdmin, AdminService>();
            services.AddScoped<ITeacher, TeacherService>();
            services.AddScoped<IAuthentications, AuthenticationService>();
            

            return services.BuildServiceProvider();
        }
    }
}
