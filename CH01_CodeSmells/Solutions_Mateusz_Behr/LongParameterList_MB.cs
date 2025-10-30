using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    internal class LongParameterList_MB
    { 
        public void RegisterProduct(ProductInfo product)
        {
            // Rejestracja produktu
            Console.WriteLine($"Product: {product.Name}, Category: {product.Category}, Price: {product.Price}, Stock: {product.Stock}, Supplier: {product.Supplier}, Contact: {product.Contact}");
        }

        internal class ProductInfo
        {
            internal required string Name { get; set; }
            internal required string Category { get; set; }
            internal required decimal Price { get; set; }
            internal required int Stock { get; set; }
            internal required string Supplier { get; set; }
            internal required string Contact { get; set; }
        }
    }
}
