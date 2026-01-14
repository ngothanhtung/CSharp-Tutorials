using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;

namespace OnlineShopApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : Controller
{
    // GET
    [HttpGet]
    public IActionResult GetProducts()
    {
        using var context = new OnlineShopDataContext();
        var products = context.Products
            .Include(p => p.Category)
            .Include(p => p.Supplier)
            //.Where(p => p.Discount > 0)
            .Select(p => new
            {
                p.Id,
                p.Name,
                p.Price,
                p.Discount,
                p.Stock,
                Category = new
                {
                    p.Category!.Id,
                    p.Category.Name
                },
                Supplier = new
                {
                    p.Supplier!.Id,
                    p.Supplier.Name,
                    p.Supplier.Email,
                    p.Supplier.Address
                }
            }).ToList();
        return Ok(products);
    }
}