namespace Nasarna.Models
{
    public class CauseTag
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int CauseId { get; set; }
        public Tag Tag { get; set; }
        public Cause Cause { get; set; }
    }
}
