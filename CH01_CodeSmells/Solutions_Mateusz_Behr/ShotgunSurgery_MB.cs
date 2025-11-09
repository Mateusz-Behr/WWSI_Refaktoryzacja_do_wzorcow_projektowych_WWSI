using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    public class Customer
    {
        public string Name { get; set; }
    }
    public class Order
    {
        public string OrderId { get; set; }
    }
    public class OrderService
    {
        public void CreateOrder(Customer customer)
        {
            Console.WriteLine($"Order created for customer {customer.Name}.");
        }
        public void SaveOrder(Order order)
        {
            Console.WriteLine($"Order {order.OrderId} saved.");
        }
    }
}

//1. Utwórz centralną klasę OrderService, która zajmie się zarządzaniem zamówieniami.
//1.Przenieś odpowiedzialności dotyczące zamówień do tej klasy.