using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Proxy
{
    public class PublicFile : IFileAccess
    {
        private readonly string _fileName;
        private string _fileContent;

        public PublicFile
            (string fileName, string initialContent)
        {
            _fileName = fileName;
            _fileContent = initialContent;
            Console.WriteLine($"Plik '{_fileName}' (publiczny) został utworzony.");
        }

        public void ReadFile()
        {
            Console.WriteLine($"-- Odczytuję plik '{_fileName}': {_fileContent}");
        }

        public void WriteFile(string content)
        {
            _fileContent = content;
            Console.WriteLine($"-- Nadpisuję dane w pliku '{_fileName}': {content}");
        }

        public void AppendToFile(string content)
        {
            _fileContent += Environment.NewLine + content;
            Console.WriteLine($" Dopisuję do pliku '{_fileName}': {content}");
        }
    }
}
