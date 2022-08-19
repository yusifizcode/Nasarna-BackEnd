namespace Nasarna.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int CauseId { get; set; }
        public string AppUserId { get; set; }
        public string CardNumber { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Cvc { get; set; }
        public int Value { get; set; }
        public Cause Cause { get; set; }
        public AppUser AppUser { get; set; }
    }
}
