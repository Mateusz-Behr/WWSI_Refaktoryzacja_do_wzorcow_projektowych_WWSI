using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    public class UserManager()
    {
        public void ManageUsers()
        {
            Console.WriteLine("Managing users.");
        }
    }

    public class SystemConfigurator()
    {
        public void ConfigureSystem()
        {
            Console.WriteLine("Configuring system.");
        }
    }

    public class LogRegistrar()
    {
        public void RegisterLog(string log)
        {
            Console.WriteLine($"Log: {log}");
        }
    }

    public class SystemReportGenerator()
    {
        public void GenerateSystemReport()
        {
            Console.WriteLine("System report generated.");
        }
    }
    public class AdminPanel
    {
        private readonly UserManager userManager = new UserManager();
        private readonly SystemConfigurator systemConfigurator = new SystemConfigurator();
        private readonly LogRegistrar logRegistrar = new LogRegistrar();
        private readonly SystemReportGenerator reportGenerator = new SystemReportGenerator();

        public void ManageUsers() => userManager.ManageUsers();
        public void ConfigureSystem() => systemConfigurator.ConfigureSystem();
        public void RegisterLog(string log) => logRegistrar.RegisterLog(log);
        public void GenerateSystemReport() => reportGenerator.GenerateSystemReport();
    }
}
