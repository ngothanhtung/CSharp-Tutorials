using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using OnlineShop.Data;
using OnlineShopApi.Models;
using OnlineShopApi.Services;
using Scalar.AspNetCore;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// ✅ THÊM ĐOẠN NÀY: Đăng ký DbContext
builder.Services.AddDbContext<OnlineShopDataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Add JWT configuration
var jwtConfig = new JwtConfig();
builder.Configuration.GetSection("JwtConfig").Bind(jwtConfig);
builder.Services.AddSingleton(jwtConfig);

// Add JWT service
builder.Services.AddScoped<IJwtService, JwtService>();


// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});

// Add JWT Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtConfig.Issuer,
            ValidAudience = jwtConfig.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfig.Key)),
            ClockSkew = TimeSpan.Zero
        };
    });

builder.Services.AddAuthorization();


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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
