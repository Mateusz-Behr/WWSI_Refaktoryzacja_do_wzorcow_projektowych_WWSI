using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    public class InvoiceGenerator
    {

        public void GenerateInvoice()
        {
            int invoiceNumber = 12345;
            PdfWriter pdfWriter = new PdfWriter($"Invoice_{invoiceNumber}.pdf");

            // Generowanie faktury
            pdfWriter.Write("Invoice Content");
            pdfWriter.Close();
        }

        public void OtherMethod()
        {
            // Metoda, która nie korzysta z tymczasowych pól
        }
    }
    
}
//Masz klasę InvoiceGenerator, która używa tymczasowych pól (_invoiceNumber, _pdfWriter) tylko w jednej metodzie GenerateInvoice. Twoim zadaniem jest usunięcie tych pól i przekształcenie ich w lokalne zmienne.

//Kroki do wykonania:

//1.Usuń tymczasowe pola(_invoiceNumber, _pdfWriter) z klasy InvoiceGenerator.
//1. Przekształć tymczasowe pola na lokalne zmienne wewnątrz metody GenerateInvoice.
//1. Upewnij się, że kod jest bardziej spójny i czytelny po refaktoryzacji.