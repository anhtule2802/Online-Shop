using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebThietBiMang.Models
{
    public class LoginModel
    {
        [Key]
        [Display(Name ="Tên Đăng Nhập")]
        [Required(ErrorMessage ="Hãy nhập tài khoản")]
        public string UserName { get; set; }
        [Display(Name = "Mật Khẩu")]
        [Required(ErrorMessage = "Hãy nhập mật khẩu")]
        public string Password { get; set; }
    }
}