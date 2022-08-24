using Nasarna.Models;
using System.Collections.Generic;

namespace Nasarna.ViewModels
{
    public class CauseDetailViewModel
    {
        public Cause Cause { get; set; }
        public Payment Payment { get; set; }
        public List<Cause> RecentlyCauses { get; set; }
        public CauseCommentPostViewModel CauseComment { get; set; }
        public Message Message { get; set; }
    }
}
