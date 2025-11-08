using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    public class ProductDetails
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
    public class ProductManager
    {
        public void RegisterProduct(ProductDetails product)
        {
            Console.WriteLine($"Product: {product.Name}, Category: {product.Category}, Price: {product.Price}, Quantity: {product.Quantity}");
        }
    }
}

//1. Utwórz nową klasę ProductDetails, która będzie zawierała pola Name, Category, Price, Quantity.
// 1. Zastąp listę parametrów w metodzie RegisterProduct jednym obiektem ProductDetails.
// 1. Zaktualizuj logikę metody, aby korzystała z nowego obiektu.