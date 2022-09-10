using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyCoreProject.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Adınız Giriniz!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Lütfen Soyadınızı Giriniz!")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Resim Url Adresinizi Giriniz!")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage ="Lütfen Şifre Giriniz!")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Lütfen Şifreyi Tekrardan Giriniz!")]
        [Compare("Password",ErrorMessage ="Şifreler Eşleşmiyor!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="Lütfen Mail Adresinizi Giriniz!")]
        public string Mail { get; set; }
    }
}
