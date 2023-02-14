using System.Collections.Generic;

namespace Boake_BackEnd.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
