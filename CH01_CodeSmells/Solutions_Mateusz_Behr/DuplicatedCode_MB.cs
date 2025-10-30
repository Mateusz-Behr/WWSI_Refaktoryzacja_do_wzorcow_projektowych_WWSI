using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//### Duplikacja kodu (Duplicated Code)

//Masz metody LogError i LogWarning, które zawierają zduplikowaną logikę formatowania komunikatów logów. Twoim zadaniem jest usunięcie zduplikowanego kodu poprzez wyodrębnienie wspólnej logiki do nowej metody FormatLogMessage.

//    ```csharp
//public void LogError(string message, DateTime timestamp)
//{
//    string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
//    string formattedMessage = $"ERROR: [{formattedTimestamp}] {message}";
//    Console.WriteLine(formattedMessage);
//}

//public void LogWarning(string message, DateTime timestamp)
//{
//    string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
//    string formattedMessage = $"WARNING: [{formattedTimestamp}] {message}";
//    Console.WriteLine(formattedMessage);
//}
//```

//Kroki do wykonania:

//1.Wyodrębnij zduplikowaną logikę formatowania komunikatów do oddzielnej metody FormatLogMessage.
//1. Zamień zduplikowany kod w metodach LogError i LogWarning na wywołanie nowej metody FormatLogMessage.
//1. Zaktualizuj metody, aby były bardziej czytelne i łatwiejsze w utrzymaniu.

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    internal class DuplicatedCode_MB
    {
        public void LogError(string message, DateTime timestamp)
        {
            string formattedMessage = FormatLogMessage("ERROR", message, timestamp);
            Console.WriteLine(formattedMessage);
        }

        public void LogWarning(string message, DateTime timestamp)
        {
            string formattedMessage = FormatLogMessage("WARNING", message, timestamp);
            Console.WriteLine(formattedMessage);
        }
        private string FormatLogMessage(string level, string message, DateTime timestamp)
        {
            string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
            return $"{level}: [{formattedTimestamp}] {message}";

        }  

    }
}
