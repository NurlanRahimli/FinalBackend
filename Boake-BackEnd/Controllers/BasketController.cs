using Boake_BackEnd.DAL;
using Boake_BackEnd.Models;
using Boake_BackEnd.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boake_BackEnd.Controllers
{

    public class BasketController : Controller
    {
        private AppDbContext _context;
        private UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContext;
        public BasketController(AppDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            _context = context;
            _httpContext = httpContextAccessor;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return RedirectToAction("login", "account");
            }
            OrderVM model = new OrderVM
            {

                BasketItems = _context.BasketItems.Include(b => b.Book).ThenInclude(b => b.Campaign).Where(b => b.AppUserId == user.Id).ToList(),

            };


            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> Plus(int Id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            BasketItem basket = _context.BasketItems.Include(b => b.Book).ThenInclude(b => b.Campaign).FirstOrDefault(b => b.BookId == Id && b.AppUserId == user.Id);
            basket.Count++;
            _context.SaveChanges();
            decimal TotalPrice = 0;
            decimal Price = basket.Count * (basket.Book.CampaignId == null ? basket.Book.Price : basket.Book.Price * (100 - basket.Book.Campaign.DiscountPercent) / 100);
            List<BasketItem> basketItems = _context.BasketItems.Include(b => b.AppUser).Include(b => b.Book).Where(b => b.AppUserId == user.Id).ToList();
            foreach (BasketItem item in basketItems)
            {
                Book book = _context.Books.Include(b => b.Campaign).FirstOrDefault(b => b.Id == item.BookId);

                BasketItemVM basketItemVM = new BasketItemVM
                {
                    Book = book,
                    Count = item.Count
                };
                basketItemVM.Price = book.CampaignId == null ? book.Price : book.Price * (100 - book.Campaign.DiscountPercent) / 100;

                TotalPrice += basketItemVM.Price * basketItemVM.Count;

            }

            return Json(new { totalPrice = TotalPrice, Price });
        }
        public async Task<IActionResult> Minus(int Id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            BasketItem basket = _context.BasketItems.Include(b => b.Book).ThenInclude(b => b.Campaign).FirstOrDefault(b => b.BookId == Id && b.AppUserId == user.Id);
            if (basket.Count == 1)
            {
                basket.Count = 1;
            }
            else
            {
                basket.Count--;
            }
            _context.SaveChanges();
            decimal TotalPrice = 0;
            decimal Price = basket.Count * (basket.Book.CampaignId == null ? basket.Book.Price : basket.Book.Price * (100 - basket.Book.Campaign.DiscountPercent) / 100);
            List<BasketItem> basketItems = _context.BasketItems.Include(b => b.AppUser).Include(b => b.Book).Where(b => b.AppUserId == user.Id).ToList();
            foreach (BasketItem item in basketItems)
            {
                Book book = _context.Books.Include(b => b.Campaign).FirstOrDefault(b => b.Id == item.BookId);

                BasketItemVM basketItemVM = new BasketItemVM
                {
                    Book = book,
                    Count = item.Count
                };
                basketItemVM.Price = book.CampaignId == null ? book.Price : book.Price * (100 - book.Campaign.DiscountPercent) / 100;

                TotalPrice += basketItemVM.Price * basketItemVM.Count;

            }

            return Json(new { totalPrice = TotalPrice, Price });
        }

        public async Task<IActionResult> AddBasket(int id)
        {
            Book book = _context.Books.FirstOrDefault(f => f.Id == id);


            if (User.Identity.IsAuthenticated /*&& User.IsInRole("Member")*/)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user == null)
                {
                    return RedirectToAction("login", "account");
                }
                BasketItem basketItem = _context.BasketItems.FirstOrDefault(b => b.BookId == book.Id && b.AppUserId == user.Id);
                if (basketItem == null)
                {
                    basketItem = new BasketItem
                    {
                        AppUserId = user.Id,
                        BookId = book.Id,
                        Count = 1
                    };
                    _context.BasketItems.Add(basketItem);
                }
                else
                {
                    basketItem.Count++;
                }
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

                //return View("_basketPartial");
            }



            return RedirectToAction("login", "account");
        }
        public async Task<IActionResult> Add(int id, int count)
        {
            Book book = _context.Books.FirstOrDefault(f => f.Id == id);


            if (User.Identity.IsAuthenticated /*&& User.IsInRole("Member")*/)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user == null)
                {
                    return RedirectToAction("login", "account");
                }
                BasketItem basketItem = _context.BasketItems.FirstOrDefault(b => b.BookId == book.Id && b.AppUserId == user.Id);
                if (basketItem == null)
                {
                    basketItem = new BasketItem
                    {
                        AppUserId = user.Id,
                        BookId = book.Id,
                        Count = count
                    };
                    _context.BasketItems.Add(basketItem);
                }
                else
                {
                    basketItem.Count += count;
                }
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

                //return View("_basketPartial");
            }



            return RedirectToAction("login", "account");
        }
        #region
        //public async Task<IActionResult> Plus(int Id)
        //{
        //    AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
        //    if (user == null)
        //    {
        //        return RedirectToAction("login", "account");
        //    }
        //    BasketItem basket = _context.BasketItems.Include(b => b.Book).ThenInclude(b => b.Campaign).FirstOrDefault(b => b.BookId == Id && b.AppUserId == user.Id);
        //    if (basket.Count < basket.Book.Stock)
        //    {
        //        basket.Count++;

        //        _context.SaveChanges();
        //        decimal TotalPrice = 0;
        //        decimal Price = basket.Count * (basket.Book.CampaignId == null ? basket.Book.Price : basket.Book.Price * (100 - basket.Book.Campaign.DiscountPercent) / 100);
        //        List<BasketItem> basketItems = _context.BasketItems.Include(b => b.AppUser).Include(b => b.Book).Where(b => b.AppUserId == user.Id).ToList();
        //        foreach (BasketItem item in basketItems)
        //        {
        //            Book book = _context.Books.FirstOrDefault(b => b.Id == item.BookId);

        //            BasketItemVM basketItemVM = new BasketItemVM
        //            {
        //                Book = book,
        //                Count = item.Count
        //            };
        //            basketItemVM.Price = book.CampaignId == null ? book.Price : book.Price * (100 - book.Campaign.DiscountPercent) / 100;

        //                TotalPrice += basketItemVM.Price * basketItemVM.Count;

        //        }

        //        return Json(new { totalPrice = TotalPrice, Price });
        //    }
        //    else
        //    {
        //        TempData["Succeeded"] = false;

        //    }
        //    return RedirectToAction(nameof(Index));
        //}

        //public async Task<IActionResult> Minus(int Id)
        //{
        //    AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
        //    if (user == null)
        //    {
        //        return RedirectToAction("login", "account");
        //    }
        //    BasketItem basket = _context.BasketItems.Include(b => b.Book).ThenInclude(b=>b.Campaign).FirstOrDefault(b => b.BookId == Id && b.AppUserId == user.Id);
        //    if (basket.Count == 1)
        //    {
        //        basket.Count = 1;
        //    }
        //    else
        //    {
        //        basket.Count--;
        //    }
        //    _context.SaveChanges();
        //    decimal TotalPrice = 0;
        //    decimal Price = basket.Count * (basket.Book.CampaignId == null ? basket.Book.Price : basket.Book.Price * (100 - basket.Book.Campaign.DiscountPercent) / 100);

        //    List<BasketItem> basketItems = _context.BasketItems.Include(b => b.AppUser).Include(b => b.Book).Where(b => b.AppUserId == user.Id).ToList();
        //    foreach (BasketItem item in basketItems)
        //    {
        //        Book book = _context.Books.Include(b=>b.Campaign).FirstOrDefault(b => b.Id == item.BookId);

        //        BasketItemVM basketItemVM = new BasketItemVM
        //        {
        //            Book = book,
        //            Count = item.Count
        //        };
        //        basketItemVM.Price = book.CampaignId == null ? book.Price : book.Price * (100 - book.Campaign.DiscountPercent) / 100;

        //        TotalPrice += basketItemVM.Price * basketItemVM.Count;

        //    }

        //    return Json(new { totalPrice = TotalPrice, Price });
        //}
        #endregion

        public async Task<IActionResult> Remove(int Id)
        {
            if (User.Identity.IsAuthenticated /*&& User.IsInRole("Member")*/)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user == null)
                {
                    return RedirectToAction("login", "account");
                }
                List<BasketItem> basketItems = _context.BasketItems.Where(b => b.BookId == Id && b.AppUserId == user.Id).ToList();
                if (basketItems == null) return Json(new { status = 404 });
                foreach (var item in basketItems)
                {

                    _context.BasketItems.Remove(item);
                }
            }

            _context.SaveChanges();


            return Json(new { status = 200 });
        }

        public async Task<IActionResult> RemoveAll()
        {
            if (User.Identity.IsAuthenticated /*&& User.IsInRole("Member")*/)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                List<BasketItem> basketItems = _context.BasketItems.Where(b => b.AppUserId == user.Id).ToList();
                if (basketItems == null) return Json(new { status = 404 });
                foreach (var item in basketItems)
                {

                    _context.BasketItems.Remove(item);
                }
            }

            _context.SaveChanges();


            return RedirectToAction("index", "shop");
        }

        public async Task<IActionResult> Checkout()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            OrderVM model = new OrderVM
            {
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Email = user.Email,
                BasketItems = _context.BasketItems.Include(b => b.Book).ThenInclude(b => b.Campaign).Include(b => b.AppUser).Where(b => b.AppUserId == user.Id).ToList()

            };

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(OrderVM orderVM)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            OrderVM model = new OrderVM
            {
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Email = user.Email,
                BasketItems = _context.BasketItems.Include(b => b.Book).ThenInclude(b => b.Campaign).Where(b => b.AppUserId == user.Id).ToList()
            };
            if (!ModelState.IsValid) return View(model);


            if (model.BasketItems.Count == 0) return RedirectToAction("index", "home");
            Order order = new Order
            {
                CountryRegion = orderVM.CountryRegion,
                Address = orderVM.Address,
                Apartment = orderVM.Apartment,
                City = orderVM.City,
                State = orderVM.State,
                ZipCode = orderVM.ZipCode,
                TotalPrice = 0,
                Date = DateTime.Now,
                AppUserId = user.Id
            };

            foreach (BasketItem item in model.BasketItems)
            {
                order.TotalPrice += item.Book.CampaignId == null ? item.Count * item.Book.Price : item.Count * item.Book.Price * (100 - item.Book.Campaign.DiscountPercent) / 100;
                OrderItem orderItem = new OrderItem
                {
                    Name = item.Book.Name,
                    Price = item.Book.CampaignId == null ? item.Count * item.Book.Price : item.Count * item.Book.Price * (100 - item.Book.Campaign.DiscountPercent) / 100,
                    AppUserId = user.Id,
                    BookId = item.Book.Id,
                    Order = order
                };
                item.Book.Stock -= item.Count;
                item.Book.SaleCount += item.Count;
                if (item.Book.Stock == 0)
                {
                    item.Book.IsSale = false;
                }
                else
                {
                    item.Book.IsSale = true;
                }
                _context.OrderItem.Add(orderItem);
            }
            _context.BasketItems.RemoveRange(model.BasketItems);
            _context.Order.Add(order);
            _context.SaveChanges();
            TempData["Succeeded"] = true;

            return RedirectToAction("index", "home");
        }
    }
}
