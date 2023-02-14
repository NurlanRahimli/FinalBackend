using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Boake_BackEnd.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        [Required]
        public int DiscountPercent { get; set; }
        public List<Book> Books { get; set; }
    }
}
