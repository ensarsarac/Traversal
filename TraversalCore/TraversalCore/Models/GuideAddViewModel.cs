using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Models
{
    public class GuideAddViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Lütfen bu alanı doldurunuz.")]
        public IFormFile Image { get; set; }

        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz.")]
        public string NameSurname { get; set; }
        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz.")]
        public string TwitterUrl { get; set; }
        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz.")]
        public string InstagramUrl { get; set; }
    }
}
