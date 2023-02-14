using System.Collections.Generic;

namespace Boake_BackEnd.Models
{
    public class Author:BaseEntity
    {
        public string Name { get; set; }
        public List<AuthorBook> AuthorBooks { get; set; }

    }
}
