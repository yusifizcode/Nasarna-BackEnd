using Nasarna.Models;
using System.Collections.Generic;

namespace Nasarna.ViewModels
{
    public class HomeViewModel
    {
        public List<Cause> Causes { get; set; }
        public List<Payment> Payments { get; set; }
        public List<Volunteer> Volunteers { get; set; }
        public List<Event> Events { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
