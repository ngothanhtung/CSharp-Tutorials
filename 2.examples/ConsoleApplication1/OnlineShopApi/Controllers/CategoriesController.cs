using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;

namespace OnlineShopApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriesController : ControllerBase
{
    // GET
    [HttpGet]
    public IActionResult GetCategories()
    {
        using var context = new OnlineShopDataContext();
        var products = context.Categories.ToList();
        return Ok(products);
    }

    public IActionResult CreateCategory([FromBody] Category category)
    {
        using var context = new OnlineShopDataContext();
        context.Categories.Add(category);
        context.SaveChanges();

        return Ok(category);
    }
}