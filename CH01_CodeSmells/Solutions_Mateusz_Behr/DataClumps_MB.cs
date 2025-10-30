using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    public class EventDetails
    {
        public string eventName { get; set; }
        public DateTime eventDate { get; set; }
        public string location { get;set; }
    }
    internal class DataClumps_MB
    {
        public void RegisterEvent(EventDetails eventDetails)    
        {
            Console.WriteLine($"Event: {eventDetails.eventName}, Date: {eventDetails.eventDate}, Location: {eventDetails.location}");
        }
    }
}
