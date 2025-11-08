using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    public class AdvancedHandler
    {
        public void HandleRequest(object request)
        {
            // Ogólna logika przetwarzania, która nigdy nie jest używana
        }

        public void HandleHttpRequest(HttpRequest request)
        {
            Console.WriteLine($"Handling HTTP request: {request.Url}");
        }

        public void HandleFileRequest(FileRequest request)
        {
            Console.WriteLine($"Handling file request: {request.FileName}");
        }
    }
}

//1. Usuń nieużywane metody (HandleRequest) oraz niepotrzebne abstrakcje.
// 1. Zachowaj tylko metody, które są faktycznie wykorzystywane (HandleHttpRequest, HandleFileRequest).
