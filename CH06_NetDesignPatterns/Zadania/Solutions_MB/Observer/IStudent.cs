using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Observer
{
    public interface IStudent
    {
        string LastName { get; }

        void ReceiveResult(string subject, double grade);
    }
}
