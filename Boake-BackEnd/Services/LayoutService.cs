using Boake_BackEnd.DAL;
using Boake_BackEnd.Models;
using Boake_BackEnd.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boake_BackEnd.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<AppUser> _userManager;

        public LayoutService(AppDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            _context = context;
            _httpContext = httpContextAccessor;
            _userManager = userManager;
        }
        public async Task<BasketVM> ShowBasket()
        {
            
            BasketVM basketData = new BasketVM
            {
                TotalPrice = 0,
                BasketItems = new List<BasketItemVM>(),
                Count = 0
            };
            if (_httpContext.HttpContext.User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(_httpContext.HttpContext.User.Identity.Name);
                List<BasketItem> basketItems = _context.BasketItems.Include(b => b.AppUser).Where(b => b.AppUserId == user.Id).ToList();
                foreach (BasketItem item in basketItems)
                {
                    Book book = _context.Books.Include(f => f.Campaign).FirstOrDefault(f => f.Id == item.BookId);
                    if (book != null)
                    {
                        BasketItemVM basketItemVM = new BasketItemVM
                        {
                            Book = book,
                            Count = item.Count
                        };
                        basketItemVM.Price = basketItemVM.Book.CampaignId == null ? basketItemVM.Book.Price : basketItemVM.Book.Price * (100 - basketItemVM.Book.Campaign.DiscountPercent) / 100;
                        basketData.BasketItems.Add(basketItemVM);
                        basketData.Count++;
                        basketData.TotalPrice += basketItemVM.Price * basketItemVM.Count;
                    }
                }
            }
           

            return basketData;

        }
    }
}
