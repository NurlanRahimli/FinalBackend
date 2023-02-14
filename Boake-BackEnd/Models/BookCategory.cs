namespace Boake_BackEnd.Models
{
    public class BookCategory:BaseEntity
    {
        public int Id { get; set; } 
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Book Book { get; set; }
    }
}
