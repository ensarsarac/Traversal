using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Lütfen email adresinizi giriniz.")]
        
        public string Email{ get; set; }

        [Required(ErrorMessage ="Lütfen şifrenizi giriniz.")]
        public string Sifre{ get; set; }
    }
}
