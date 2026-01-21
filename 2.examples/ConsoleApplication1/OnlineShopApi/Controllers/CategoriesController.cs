using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        var categories = context.Categories.ToList();
        return Ok(categories);
    }

    public IActionResult CreateCategory([FromBody] Category category)
    {
        using var context = new OnlineShopDataContext();
        context.Categories.Add(category);
        context.SaveChanges();

        return Ok(category);
    }

    [HttpGet("raw-sql")]
    public IActionResult RawSql()
    {
        const string name = "Fashion";

        using var context = new OnlineShopDataContext();
        //var categories = context.Categories.FromSqlRaw("SELECT * FROM Categories WHERE Name LIKE '{0}'", name).ToList();
        // var categories = context.Categories.FromSql($"SELECT * FROM Categories WHERE Name LIKE N'Fashion'").ToList();
        // Nên dùng
        var categories = context.Categories.FromSqlRaw("SELECT * FROM Categories WHERE Name LIKE @p0", parameters: [name]).ToList();
        return Ok(categories);
    }

    [HttpGet("raw-sql-stored-procedure")]
    public IActionResult RawSqlStoredProcedure()
    {
        const string name = "Điện thoại";

        using var context = new OnlineShopDataContext();
        // var categories = context.Categories.FromSql($"usp_GetCategories {name}").ToList();
        // Nên dùng
        var categories = context.Categories.FromSqlRaw("usp_GetCategories @p0", parameters: [name]).ToList();
        return Ok(categories);
    }

    [HttpPost("raw-sql")]
    public IActionResult RawSqlCreateCategory([FromBody] Category category)
    {

        using var context = new OnlineShopDataContext();
        //var result = context.Database.ExecuteSql($"INSERT INTO Categories (Name, Description) VALUES ({category.Name}, {category.Description})");
        // Nên dùng, tránh bị SqlInjection
        var result = context.Database.ExecuteSqlRaw("INSERT INTO Categories (Name, Description) VALUES (@p0, @p1)", parameters: [category.Name, category.Description]);

        return Ok(new
        {
            Message = "OK",
            RowAffected = result
        });
    }

    [HttpPost("raw-sql-stored-procedure")]
    public IActionResult RawSqlStoredProcedureCreateCategory([FromBody] Category category)
    {
        using var context = new OnlineShopDataContext();
        //var result = context.Database.ExecuteSql($"usp_CreateCategory {category.Name}, {category.Description}");

        // Nên dùng, tránh bị SqlInjection
        var result = context.Database.ExecuteSqlRaw("usp_CreateCategory @p0, @p1", parameters: [category.Name, category.Description]);


        return Ok(new
        {
            Message = "OK",
            RowAffected = result
        });
    }
}