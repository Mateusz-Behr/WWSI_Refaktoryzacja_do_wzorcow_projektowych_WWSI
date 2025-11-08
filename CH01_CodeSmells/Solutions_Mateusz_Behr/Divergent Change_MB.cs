using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    public class UserAccount
    {
        public string Username { get; set; }
        public string Password { get; set; }


    }
}

public class AuthenticationService
{
    public void Login(string username, string password)
    {
        // Logika logowania
        Console.WriteLine("User logged in.");
    }
    public void Logout()
    {
        // Logika wylogowania
        Console.WriteLine("User logged out.");
    }
}

public class UserReportGenerator
{
    public void GenerateReport()
    {
        // Logika generowania raportu
        Console.WriteLine("Generating user report.");
    }
}
