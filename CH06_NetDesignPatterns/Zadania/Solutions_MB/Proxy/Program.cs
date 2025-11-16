using System;
using System.Collections.Generic;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Aplikacja do zarządzania plikami ---");

            PublicFile publicFile = new PublicFile("DokumentPubliczny.txt", "To jest publiczny dokument, każdy ma dostęp.");

            ProtectedFile privateFile = new ProtectedFile("DanePoufne.dat", "Bardzo tajne informacje! Tylko dla uprawnionych.", "sekretnehaslo123");

            FileAccessProxy publicFileProxy = new FileAccessProxy(publicFile);

            FileAccessProxy privateFileProxy = new FileAccessProxy(privateFile, "sekretnehaslo123");

            // Przechowywanie proxy w słowniku dla łatwiejszego wyboru
            var fileProxies = new Dictionary<string, IFileAccess>
        {
            {"1", publicFileProxy},
            {"2", privateFileProxy}
        };

            IFileAccess currentProxy = null;

            while (true)
            {
                Console.WriteLine("\n-------------------------------------------------");
                Console.WriteLine("Wybierz plik:");
                Console.WriteLine("1. DokumentPubliczny.txt");
                Console.WriteLine("2. DanePoufne.dat (chroniony hasłem)");
                Console.WriteLine("3. Zakończ program");
                Console.Write("Twój wybór: ");
                string choice = Console.ReadLine();

                if (choice == "3")
                {
                    Console.WriteLine("Zakończono program.");
                    break;
                }

                if (fileProxies.ContainsKey(choice))
                {
                    currentProxy = fileProxies[choice];
                    Console.WriteLine($"Wybrano: {(choice == "1" ? "DokumentPubliczny.txt" : "DanePoufne.dat")}");

                    if (choice == "2")
                    {
                        Console.Write("Wprowadź hasło: ");
                        string password = Console.ReadLine();
                        if (!((FileAccessProxy)currentProxy).Authenticate(password))
                        {
                            Console.WriteLine("Autoryzacja nieudana. Spróbuj ponownie.");
                            currentProxy = null;
                            continue;
                        }
                    }
                    else // Plik publiczny jest zawsze autoryzowany
                    {
                        ((FileAccessProxy)currentProxy).Authenticate(null);
                    }

                    if (currentProxy != null)
                    {
                        while (true)
                        {
                            Console.WriteLine("\n--- Dostęp do pliku ---");
                            Console.WriteLine("1. Odczytaj plik");
                            Console.WriteLine("2. Nadpisz dane w pliku");
                            Console.WriteLine("3. Dopisz dane do pliku");
                            Console.WriteLine("4. Wróć do wyboru pliku");
                            Console.Write("Twój wybór: ");
                            string fileAction = Console.ReadLine();

                            if (fileAction == "1")
                            {
                                currentProxy.ReadFile();
                            }
                            else if (fileAction == "2")
                            {
                                Console.Write("Wprowadź nową treść: ");
                                string newContent = Console.ReadLine();
                                currentProxy.WriteFile(newContent);
                            }
                            else if (fileAction == "3")
                            {
                                Console.Write("Wprowadź treść do dopisania: ");
                                string appendContent = Console.ReadLine();
                                currentProxy.AppendToFile(appendContent);
                            }
                            else if (fileAction == "4")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                }
            }
        }
    }
}