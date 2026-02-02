using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// ✅ THÊM ĐOẠN NÀY: Đăng ký DbContext
builder.Services.AddDbContext<OnlineShopDataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// ✅ OpenAPI với Swagger UI
builder.Services.AddEndpointsApiExplorer();
// ✅ OpenAPI Configuration
builder.Services.AddOpenApi(options =>
{
    options.AddDocumentTransformer((document, context, cancellationToken) =>
    {
        document.Info = new()
        {
            Title = "Online Shop API",
            Version = "v1",
            Description = "API quản lý cửa hàng trực tuyến",
            Contact = new()
            {
                Name = "SOFTECH",
                Email = "support@softech.com",
                Url = new Uri("https://softech.com")
            },
            License = new()
            {
                Name = "MIT License",
                Url = new Uri("https://opensource.org/licenses/MIT")
            }
        };
        return Task.CompletedTask;
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    // ✅ Scalar UI (đẹp và hiện đại hơn Swagger UI)
    app.MapScalarApiReference(options =>
    {
        options
            .WithTitle("Online Shop API")
            .WithTheme(ScalarTheme.Purple)
            .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient);
    });

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
