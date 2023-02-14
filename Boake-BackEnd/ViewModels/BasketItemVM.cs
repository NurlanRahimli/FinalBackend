using Boake_BackEnd.Models;

namespace Boake_BackEnd.ViewModels
{
    public class BasketItemVM
    {
        public Book Book { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}
