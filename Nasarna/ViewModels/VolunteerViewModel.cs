using Nasarna.Models;
using System.Collections.Generic;

namespace Nasarna.ViewModels
{
    public class VolunteerViewModel
    {
        public Volunteer Volunteer { get; set; }
        public List<Volunteer> VolunteerUsers { get; set; }
    }
}
