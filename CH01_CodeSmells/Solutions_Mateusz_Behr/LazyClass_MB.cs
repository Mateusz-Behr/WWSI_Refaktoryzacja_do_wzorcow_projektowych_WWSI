using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    public class NotificationSender
    {

    }
    
      
    public class MessagingService
    {
        private string _title;
        private string _message;
        private string _recipient;

        public void SetMessage(string recipient, string title, string message)
        {
            _recipient = recipient;
            _title = title;
            _message = message;
        }

        public void SendMessage()
        {
            //Logika wysyłania wiadomości
        }

        public void SendNotification()
        {
            Console.WriteLine($"Notification. Message {_title} has been sent to {_recipient}");
        }
    }
}

//1. Przenieś metodę SendNotification do innej klasy, która zarządza komunikacją (np. MessagingService).
//1.Usuń klasę NotificationSender.