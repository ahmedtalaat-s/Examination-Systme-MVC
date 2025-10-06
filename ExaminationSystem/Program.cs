using Microsoft.Extensions.DependencyInjection;

namespace ExaminationSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Configure Dependency Injection
            var serviceProvider = DependencyContainer.Configure();

            // Resolve the main form
            //var form = serviceProvider.GetRequiredService<StudentExamForm>();
            Application.Run(new Form1());
        }
    }
}