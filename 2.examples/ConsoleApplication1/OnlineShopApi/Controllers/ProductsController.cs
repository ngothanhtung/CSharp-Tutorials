using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShopApi.Models;

namespace OnlineShopApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    // Khai báo context 1 lần và dùng chung cho các methods / requests
    private readonly OnlineShopDataContext _context;
    public ProductsController(OnlineShopDataContext context)
    {
        _context = context;
    }

    // GET
    [HttpGet]
    public IActionResult GetProducts()
    {
        var products = this._context.Products
            .Include(p => p.Category)
            .Include(p => p.Supplier)
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

    // GET
    [HttpGet("{id}")]
    public async Task<IActionResult> GetProduct(int id)
    {

        var product = await this._context.Products
            .Include(p => p.Category)
            .Include(p => p.Supplier)
            .Where(p => p.Id == id)
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
            }).FirstOrDefaultAsync();
        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto dto)
    {
        // ModelState tự động validate dựa trên Data Annotations
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        // ✅ Validate CategoryId tồn tại
        var categoryExists = await this._context.Categories.AnyAsync(c => c.Id == dto.CategoryId);
        if (!categoryExists)
        {
            return BadRequest(new { Message = $"Category with id: {dto.CategoryId} not found" });
        }

        // ✅ Validate SupplierId tồn tại
        var supplierExists = await _context.Suppliers.AnyAsync(s => s.Id == dto.SupplierId);
        if (!supplierExists)
        {
            return BadRequest(new { Message = $"Supplier with id: {dto.SupplierId} not found" });
        }


        var product = new Product()
        {
            Name = dto.Name,
            Price = dto.Price,
            Discount = dto.Discount ?? 0,
            Stock = dto.Stock ?? 0,
            Description = dto.Description ?? string.Empty,
            CategoryId = dto.CategoryId,
            SupplierId = dto.SupplierId
        };

        // ✅ Lưu vào database
        _context.Products.Add(product);

        try
        {
            await this._context.SaveChangesAsync();
        }
        catch (DbUpdateException ex)
        {
            return StatusCode(500, "Error: " + ex.Message);
        }


        return CreatedAtAction(
            nameof(GetProduct),
            new { id = product.Id },
            product
        );
    }

    // GET
    [HttpGet("c1")]
    // QueryString 
    public async Task<IActionResult> C1([FromQuery(Name = "minDiscount")] decimal minDiscount)
    {

        var product = await this._context.Products
            .Include(p => p.Category)
            .Include(p => p.Supplier)
            .Where(p => p.Discount <= minDiscount)
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
                    p.Supplier.Address,
                    p.Supplier.PhoneNumber
                }
            }).FirstOrDefaultAsync();
        return Ok(product);
    }

    // GET
    [HttpGet("c3")]
    // QueryString 
    public async Task<IActionResult> C3([FromQuery(Name = "minStock")] int minStock)
    {

        var product = await this._context.Products
            .Include(p => p.Category)
            .Include(p => p.Supplier)
            .Where(p => p.Stock <= minStock)
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
                    p.Supplier.Address,
                    p.Supplier.PhoneNumber
                }
            }).FirstOrDefaultAsync();
        return Ok(product);
    }

    // GET
    [HttpGet("c4")]
    // QueryString 
    public async Task<IActionResult> C4([FromQuery(Name = "minTotalPrice")] int minTotalPrice)
    {

        var product = await this._context.Products
            .Include(p => p.Category)
            .Include(p => p.Supplier)
            .Where(p => (p.Price * (100 - p.Discount) / 100) <= minTotalPrice)
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
                    p.Supplier.Address,
                    p.Supplier.PhoneNumber
                }
            }).FirstOrDefaultAsync();
        return Ok(product);
    }
}