namespace Nasarna.Models
{
    public class CauseImage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CauseId { get; set; }
        public Cause Cause { get; set; }
    }
}
