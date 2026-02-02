using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;

namespace OnlineShopApi.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController : ControllerBase
{
    // Khai báo context 1 lần và dùng chung cho các methods / requests
    private readonly OnlineShopDataContext _context;
    public OrdersController(OnlineShopDataContext context)
    {
        _context = context;
    }




    // GET
    [HttpGet("c12-c19")]
    // QueryString 
    public async Task<IActionResult> C12_C19([FromQuery(Name = "status")] string status, [FromQuery(Name = "fromDate")] string fromDate, [FromQuery(Name = "toDate")] string toDate)
    {
        var from = DateTime.Parse(fromDate);
        var to = DateTime.Parse(toDate).AddDays(1);

        var orders = await this._context.Orders
            .Where(o => o.Status == status && o.CreatedDate >= from && o.CreatedDate < to)
            .ToListAsync();
        return Ok(orders);
    }

    // GET
    [HttpGet("c19")]
    // QueryString 
    public async Task<IActionResult> C19([FromQuery(Name = "status")] string status, [FromQuery(Name = "year")] int year)
    {
        var orders = await this._context.Orders
            .Where(o => o.Status == status && o.CreatedDate.Year == year)
            .ToListAsync();
        return Ok(orders);
    }
}