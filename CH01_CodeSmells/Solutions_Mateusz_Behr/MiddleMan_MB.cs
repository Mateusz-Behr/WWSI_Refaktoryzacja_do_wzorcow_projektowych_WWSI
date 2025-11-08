using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    var repository = new InvoiceRepository();
    var invoice = repostitory.GetInvoiceById(123);
    repository.SaveInvoice(invoice);


    //public class InvoiceService
    //{
    //    private readonly InvoiceRepository _repository = new InvoiceRepository();

    //    public Invoice GetInvoiceById(int id)
    //    {
    //        return _repository.GetInvoiceById(id);
    //    }

    //    public void SaveInvoice(Invoice invoice)
    //    {
    //        _repository.SaveInvoice(invoice);
    //    }
    //}
}

//1. Usuń klasę InvoiceService.
// 1. Zastąp wszystkie odwołania do InvoiceService bezpośrednimi odwołaniami do InvoiceRepository.
// 1. Upewnij się, że kod nadal działa poprawnie po usunięciu klasy pośrednika.