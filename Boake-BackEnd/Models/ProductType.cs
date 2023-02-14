using System.Collections.Generic;

namespace Boake_BackEnd.Models
{
    public class ProductType:BaseEntity
    {
        public string Name { get; set; }
        public List<BookType> BookTypes { get; set; }

    }
}
