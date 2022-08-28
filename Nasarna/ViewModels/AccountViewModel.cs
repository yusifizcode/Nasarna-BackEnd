using Nasarna.Models;
using System.Collections.Generic;

namespace Nasarna.ViewModels
{
    public class AccountViewModel
    {
        public List<Cause> Causes { get; set; } = new List<Cause>();
        public AppUser User { get; set; }
        public Message Message { get; set; }
    }
}
