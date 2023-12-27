using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Member.Models
{
    public class ProfileViewModel
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string phonenumber { get; set; }
        public string password { get; set; }
        public string confirmpassword{ get; set; }
        public IFormFile imageurl { get; set; }
    }
}
