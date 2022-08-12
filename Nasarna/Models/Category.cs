using System.Collections.Generic;

namespace Nasarna.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Cause> Causes { get; set; }
    }
}
