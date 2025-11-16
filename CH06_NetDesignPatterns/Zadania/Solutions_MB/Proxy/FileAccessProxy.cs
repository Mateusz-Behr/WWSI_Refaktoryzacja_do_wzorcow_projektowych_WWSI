using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Proxy
{
    public class FileAccessProxy : IFileAccess
    {
        private readonly IFileAccess _realFile;
        private bool _isAuthenticated; 
        private readonly string _proxyPassword;

        public FileAccessProxy(PublicFile publicFile)
        {
            _realFile = publicFile;
            _proxyPassword = null;
            _isAuthenticated = true;
            Console.WriteLine($"[Proxy] Utworzono proxy dla pliku publicznego.");
        }

        public FileAccessProxy(ProtectedFile protectedFile, string proxyPassword)
        {
            _realFile = protectedFile;
            _proxyPassword = proxyPassword;
            _isAuthenticated = false;
            Console.WriteLine($"[Proxy] Utworzono proxy dla pliku chronionego.");
        }

        public bool Authenticate(string password)
        {
            if (_proxyPassword == null)
            {
                _isAuthenticated = true;
                return true;
            }

            if (password == _proxyPassword)
            {
                if (_realFile is ProtectedFile pf && pf.VerifyPassword(password))
                {
                    _isAuthenticated = true;
                    Console.WriteLine("[Proxy] Autoryzacja pomyślna. Dostęp przyznany.");
                    return true;
                }
                else
                {
                    Console.WriteLine("[Proxy] Błąd logiczny: Hasło Proxy nie zgadza się z hasłem realnego pliku.");
                    _isAuthenticated = false;
                    return false;
                }
            }
            else
            {
                Console.WriteLine("[Proxy] Błąd autoryzacji: Nieprawidłowe hasło.");
                _isAuthenticated = false;
                return false;
            }
        }

        public void ReadFile()
        {
            Console.WriteLine($"[Proxy] Próba odczytu pliku '{(_realFile is PublicFile ? "publicznego" : "chronionego")}'.");
            if (_isAuthenticated)
            {
                _realFile.ReadFile();
            }
            else
            {
                Console.WriteLine("[Proxy] Odmowa dostępu: Brak autoryzacji do odczytu.");
            }
        }

        public void WriteFile(string content)
        {
            Console.WriteLine($"[Proxy] Próba nadpisania danych w pliku '{(_realFile is PublicFile ? "publicznym" : "chronionym")}'.");
            if (_isAuthenticated)
            {
                _realFile.WriteFile(content);
            }
            else
            {
                Console.WriteLine("[Proxy] Odmowa dostępu: Brak autoryzacji do zapisu.");
            }
        }

        public void AppendToFile(string content)
        {
            Console.WriteLine($"[Proxy] Próba dopisania do pliku '{(_realFile is PublicFile ? "publicznego" : "chronionego")}'.");
            if (_isAuthenticated)
            {
                _realFile.AppendToFile(content);
            }
            else
            {
                Console.WriteLine("[Proxy] Odmowa dostępu: Brak autoryzacji do dopisania.");
            }
        }

    }
}
