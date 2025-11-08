using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public string GetFormattedPrice()
        {
            return Price.ToString("C2");
        }

        public bool IsInStock()
        {
            return StockQuantity > 0;
        }
    }

}

//1. Dodaj logikę biznesową bezpośrednio do klasy Product.
// 1. Dodaj metodę GetFormattedPrice, która zwraca cenę sformatowaną jako tekst.
// 1. Dodaj metodę IsInStock, która zwraca true, jeśli StockQuantity jest większe niż 0.
