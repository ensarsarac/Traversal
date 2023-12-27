using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresini giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen telefon numaranızı giriniz.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz.")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }
    }
}
