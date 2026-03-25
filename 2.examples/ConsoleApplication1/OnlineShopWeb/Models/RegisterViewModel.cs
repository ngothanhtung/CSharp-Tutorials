using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OnlineShopWeb.Models;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Thư điện tử bắt buộc phải nhập")]
    [EmailAddress(ErrorMessage = "Thư điện tử không hợp lệ")]
    [Display(Name = "Thư điện tử")]
    public required string Email { get; set; }

    [Required(ErrorMessage = "Mật khẩu không được để trống")]
    [DataType(DataType.Password)]
    [Display(Name = "Mật khẩu")]
    public required string Password { get; set; }

    [Required(ErrorMessage = "Tuổi không được để trống")]
    [Range(18, 60, ErrorMessage = "Tuổi không hợp lệ, tuổi phải trong khoảng 18 đến 60")]
    public int Age { get; set; }

    public string Country { get; set; } = "VN";

    public int? CategoryId { get; set; }

}