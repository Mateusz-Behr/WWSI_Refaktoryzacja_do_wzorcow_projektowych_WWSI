using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Proxy
{
    public class ProtectedFile : IFileAccess
    {
        private readonly string _fileName;
        private string _fileContent;
        private readonly string _password;

        public ProtectedFile(string fileName, string initialContent, string password)
        {
            _fileName = fileName;
            _fileContent = initialContent;
            _password = password;
            Console.WriteLine($"Plik '{_fileName}' (chroniony) został utworzony.");
        }

        public void ReadFile()
        {
            Console.WriteLine($"-- Odczytuję plik '{_fileName}' (chroniony): {_fileContent}");
        }

        public void WriteFile(string content)
        {
            _fileContent = content;
            Console.WriteLine($"-- Nadpisuję dane w pliku '{_fileName}' (chroniony): {content}");
        }

        public void AppendToFile(string content)
        {
            _fileContent += Environment.NewLine + content;
            Console.WriteLine($"Dopisuję do pliku chronionego '{_fileName}': {content}");
        }

        public bool VerifyPassword(string inputPassword)
        {
            return _password == inputPassword;
        }
    }
}
