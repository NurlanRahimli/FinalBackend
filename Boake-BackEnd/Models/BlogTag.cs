namespace Boake_BackEnd.Models
{
    public class BlogTag:BaseEntity
    {
        public int BlogId { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public Blog Blog { get; set; }
    }
}
