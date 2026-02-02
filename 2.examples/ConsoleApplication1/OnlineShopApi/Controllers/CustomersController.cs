using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;

namespace OnlineShopApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomersController : ControllerBase
{
    // Khai báo context 1 lần và dùng chung cho các methods / requests
    private readonly OnlineShopDataContext _context;
    public CustomersController(OnlineShopDataContext context)
    {
        _context = context;
    }



    // GET
    [HttpGet("c28")]
    // QueryString 
    public async Task<IActionResult> C28([FromQuery(Name = "month")] int month, [FromQuery(Name = "day")] int day)
    {
        var customers = await this._context.Customers
            .Where(c => c.Birthday.HasValue && c.Birthday.Value.Day == day && c.Birthday.Value.Month == month)
            .ToListAsync();
        return Ok(customers);
    }


}