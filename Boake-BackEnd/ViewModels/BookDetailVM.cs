using Boake_BackEnd.Models;
using System.Collections.Generic;

namespace Boake_BackEnd.ViewModels
{
    public class BookDetailVM
    {
        public Book Book { get; set; }
        public List<Book> RelatedBooks { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
