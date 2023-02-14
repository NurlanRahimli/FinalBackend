namespace Boake_BackEnd.Models
{
    public class BookType : BaseEntity
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
    }
}
