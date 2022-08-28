using Nasarna.Models;
using System.Collections.Generic;

namespace Nasarna.ViewModels
{
    public class EventViewModel
    {
        public Event Event { get; set; }
        public Contact Contact { get; set; }
        public List<Event> RecentlyEvents { get; set; }

    }
}
