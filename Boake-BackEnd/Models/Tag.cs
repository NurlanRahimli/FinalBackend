using System.Collections.Generic;

namespace Boake_BackEnd.Models
{
    public class Tag:BaseEntity
    {
        public string Name { get; set; }
        public List<BookTag> BookTags { get; set; }
        public List<BlogTag> BlogTags { get; set; }

    }
}
