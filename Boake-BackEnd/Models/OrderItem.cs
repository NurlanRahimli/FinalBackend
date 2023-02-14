namespace Boake_BackEnd.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? BookId { get; set; }
        public string AppUserId { get; set; }
        public int OrderId { get; set; }
        public Book Book { get; set; }
        public AppUser AppUser { get; set; }
        public Order Order { get; set; }
    }
}
