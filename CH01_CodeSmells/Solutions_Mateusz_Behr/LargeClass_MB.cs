using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{

    public class OrderProcessor()
    {
        public void ProcessOrders()
        {
            Console.WriteLine("Processing orders.");
        }
    }

    public class InventoryManager()
    {
        public void ManageInventory()
        {
            Console.WriteLine("Managing inventory.");
        }
    }

    public class DeliveryCoordinator()
    {
        public void CoordinateDeliveries()
        {
            Console.WriteLine("Coordinating deliveries.");
        }
    }

    public class ReturnHandler()
    {
        public void HandleReturns()
        {
            Console.WriteLine("Handling returns.");
        }
    }
    public class WarehouseManager
    {
        private readonly OrderProcessor orderProcessor = new OrderProcessor();
        private readonly InventoryManager inventoryManager = new InventoryManager();
        private readonly DeliveryCoordinator deliveryCoordinator = new DeliveryCoordinator();
        private readonly ReturnHandler returnHandler = new ReturnHandler();

        public void ProcessOrders() => orderProcessor.ProcessOrders();
        public void ManageInventory() => inventoryManager.ManageInventory();
        public void CoordinateDeliveries() => deliveryCoordinator.CoordinateDeliveries();
        public void HandleReturns() => returnHandler.HandleReturns();
    }
}

//1. Utwórz osobne klasy OrderProcessor, InventoryManager, DeliveryCoordinator, i ReturnHandler.
// 1. Przenieś odpowiednie metody do tych nowych klas.
// 1. Usuń zbędne metody z klasy WarehouseManager i zachowaj tylko te, które są faktycznie związane z zarządzaniem magazynem na wysokim poziomie.
// 
