namespace Library.Models
{
    public class Rental
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
    }
}
