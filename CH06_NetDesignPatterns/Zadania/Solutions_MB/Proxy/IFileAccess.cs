using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Proxy
{
    public interface IFileAccess
    {
        void ReadFile();
        void WriteFile(string content);
        void AppendToFile(string content);
    }
}
