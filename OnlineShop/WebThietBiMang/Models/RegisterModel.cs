using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebThietBiMang.Models
{
    public class RegisterModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Tên đăng nhập")]//Hiển thị trên form
        [Required(ErrorMessage ="Yêu cầu nhập tên đăng nhập")]//Báo lỗi
        public string UserName { get; set; }

        [Display(Name = "Mật khẩu")]
        [StringLength(20,MinimumLength =6,ErrorMessage ="Độ dài mật khẩu ít nhất 6 ký tự")]//Độ dài ngắn của password
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("Password",ErrorMessage ="Mật khẩu xác nhận không đúng.")]//So sánh password
        public string ConfirmPassword { get; set; }

        [Display(Name = "Họ")]
        [Required(ErrorMessage = "Yêu cầu nhập họ tên")]
        public string FirstName { get; set; }

        [Display(Name = "Tên")]
        [Required(ErrorMessage = "Yêu cầu nhập họ tên")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Yêu cầu nhập Email")]
        public string Email { get; set; }
    }
}