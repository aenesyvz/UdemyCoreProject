using System.ComponentModel.DataAnnotations;

namespace UdemyCoreProject.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullancı Adı")]
        [Required(ErrorMessage ="Lütfen Kullanıcı Adınızı Giriniz..!")]
        public string UserName { get; set; }
        [Display(Name ="Şifre")]
        [Required(ErrorMessage ="Lütfen Şifrenizi Giriniz!")]
        public string Password { get; set; }
    }
}
