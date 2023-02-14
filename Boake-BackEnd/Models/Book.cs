using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boake_BackEnd.Models
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public bool IsSale { get; set; }
        public string ImageUrl { get; set; }
        public int SaleCount { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public List<BookCategory> BookCategories { get; set; }
        public List<BookType> BookTypes { get; set; }
        public List<AuthorBook> AuthorBooks { get; set; }
        public List<BookTag> BookTags { get; set; }
        [NotMapped]
        public List<int> AuthorIds { get; set; }
        [NotMapped]
        public List<int> CategoryIds { get; set; }
        [NotMapped]
        public List<int> TagIds { get; set; }
        [NotMapped]
        public List<int> BookTypeIds { get; set; }
        public int? CampaignId { get; set; }
        public Campaign Campaign { get; set; }
    }
}
