using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Utwórz nową klasę EventDetails, która będzie zawierała pola eventName, eventDate, location.
namespace DataClumps
{
    public class EventDetails
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }

        public EventDetails(string eventName, DateTime eventDate, string location)
        {
            EventName = eventName;
            EventDate = eventDate;
            Location = location;
        }
    }

}