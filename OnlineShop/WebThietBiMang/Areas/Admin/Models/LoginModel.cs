using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebThietBiMang.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage="Mời Nhập Username")]
        public string UserName { set; get; }
        [Required(ErrorMessage = "Mời Nhập Password")]
        public string Password { set; get; }

        public bool RememberMe { set; get; }
    }
}