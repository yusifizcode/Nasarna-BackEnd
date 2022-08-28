using Nasarna.Models;
using System.Collections.Generic;

namespace Nasarna.ViewModels
{
    public class CauseViewModel
    {
        public List<Cause> Causes { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Category> Categories { get; set; }
        public List<Cause> RecentlyCauses { get; set; } 
    }
}
