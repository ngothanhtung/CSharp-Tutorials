using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;

namespace OnlineShopWeb.Controllers
{
    public class AboutController : Controller
    {
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
    }
}
