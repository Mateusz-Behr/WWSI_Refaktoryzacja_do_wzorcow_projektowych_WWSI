using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
//Masz klasy BaseNotificationSender i BaseReportGenerator oraz ich klasy pochodne(EmailNotificationSender, SmsNotificationSender oraz PdfReportGenerator, CsvReportGenerator). Twoim zadaniem jest usunięcie równoległych hierarchii dziedziczenia i wprowadzenie bardziej elastycznej architektury.

//Kod do refaktoryzacji:
 
    public interface ILogger
    {
        void LogMessage();
    }
    public interface IExporter
    {
        void ExportData();
    }

    public class FileLogger : BaseLogger
    {
        public override void LogMessage() { /* Implementacja dla pliku */ }
    }

    public class DatabaseLogger : BaseLogger
    {
        public override void LogMessage() { /* Implementacja dla bazy danych */ }
    }

    public class XmlExporter : BaseExporter
    {
        public override void ExportData() { /* Implementacja dla XML */ }
    }

    public class JsonExporter : BaseExporter
    {
        public override void ExportData() { /* Implementacja dla JSON */ }
    }

 
//Kroki do wykonania:
 
//1. Usuń klasy bazowe(BaseLogger i BaseExporter).
//1. Wprowadź interfejsy ILogger i IExporter.
//1. Przenieś metody do interfejsów i zastąp hierarchię klas bazowych implementacjami interfejsów.
//1. Dostosuj klasy pochodne, aby implementowały odpowiednie interfejsy.


}
