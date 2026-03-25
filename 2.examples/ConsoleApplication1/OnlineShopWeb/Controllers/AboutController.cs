using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShopWeb.Models;

namespace OnlineShopWeb.Controllers
{
    public class AboutController : Controller
    {
        private readonly OnlineShopDataContext _context;
        public AboutController(OnlineShopDataContext context)
        {
            _context = context;
        }

        // https://localhost:5001/About
        [HttpGet]
        public IActionResult Index()
        {

            // Customers
            var customers = new List<Customer>();

            customers.Add(new Customer {
                Id = 1,
                FirstName = "Nguyễn",
                LastName = "Tuấn",
                Email = "tuan.nguyen@gmail.com"
            });

            customers.Add(new Customer
            {
                Id = 2,
                FirstName = "Nguyễn",
                LastName = "Nam",
                Email = "nam.nguyen@gmail.com"
            });

            customers.Add(new Customer
            {
                Id = 3,
                FirstName = "Trần",
                LastName = "Thái",
                Email = "thai.tran@gmail.com"
            });

            return View(customers);
        }

        public IActionResult MoreDetails()
        {
            return View();
        }

        //[Route("About/Company/Vietnam/Address", Name = "address")]
        
        public IActionResult Address()
        {
            var model = new RegisterViewModel()
            {
                Email = "",
                Password = "",
                Country = "VN",

            };



            var countries = new List<SelectListItem>();
            countries.AddRange([
                new SelectListItem { Value = "VN", Text = "Vietnam" },
                new SelectListItem() { Value = "MX", Text = "Mexico" },
                new SelectListItem() { Value = "CA", Text = "Canada" },
                new SelectListItem() { Value = "US", Text = "USA" }
            ]);

            ViewBag.Countries = countries;


            // Get categories from database
            var categoriesFromDatabase = this._context.Categories.ToList();

            var categories = new List<SelectListItem>();
            foreach (var category in categoriesFromDatabase)
            {
                categories.Add(new SelectListItem
                {
                    Value = category.Id.ToString(),
                    Text = category.Name
                });
            }

            ViewBag.Categories = categories;


            return View(model);
        }

        [HttpPost]
        //[Route("About/Company/Vietnam/Address", Name = "address")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Address([Bind("Email,Password,Age,Country,CategoryId")] RegisterViewModel data)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }

            // Không hợp lệ

            var countries = new List<SelectListItem>();
            countries.AddRange([
                new SelectListItem { Value = "VN", Text = "Vietnam" },
                new SelectListItem() { Value = "MX", Text = "Mexico" },
                new SelectListItem() { Value = "CA", Text = "Canada" },
                new SelectListItem() { Value = "US", Text = "USA" }
            ]);

            ViewBag.Countries = countries;


            // Get categories from database
            var categoriesFromDatabase = this._context.Categories.ToList();

            var categories = new List<SelectListItem>();
            foreach (var category in categoriesFromDatabase)
            {
                categories.Add(new SelectListItem
                {
                    Value = category.Id.ToString(),
                    Text = category.Name
                });
            }

            ViewBag.Categories = categories;

            return View(data);
        }
    }
}
