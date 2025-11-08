using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Singleton
{
    public sealed class Vault
    {
        private static Vault _vault;
        private static object _lockObject = new Object();
        private string _digitalKey;
        private bool _accessed = false;
        private Vault()
        {
            _digitalKey = Guid.NewGuid().ToString();
        }

        public static Vault Instance
        {
            get
            {
                lock (_lockObject)
                {
                    if (_vault == null)
                    {
                        _vault = new Vault();
                    }
                }

                return _vault;
            }
        }

        public string GetDigitalKey()
        {
            if (_accessed)
            {
                throw new InvalidOperationException("Digital key was already used.");
            }

            _accessed = true;
            return _digitalKey;
        }
    }
}
