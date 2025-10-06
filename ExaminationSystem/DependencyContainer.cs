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

            // Register DbContext
            services.AddDbContext<ExaminationContext>(options =>
                options.UseSqlServer("Your_Connection_String"));

            // Register Services
            services.AddScoped<StudentService>();

            return services.BuildServiceProvider();
        }
    }
}
