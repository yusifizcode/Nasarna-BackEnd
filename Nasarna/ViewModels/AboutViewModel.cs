using Nasarna.Models;
using System.Collections.Generic;

namespace Nasarna.ViewModels
{
    public class AboutViewModel
    {
        public List<Cause> Causes { get; set; }
        public List<Payment> Payments { get; set; }
        public List<Volunteer> Volunteers { get; set; }
        public List<Event> Events { get; set; }
        public List<Mission> Missions { get; set; }
    }
}
