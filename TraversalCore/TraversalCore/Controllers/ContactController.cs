using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using DTOLayer.ContactDTOs;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {

        private readonly IContactService _contactService;
        private readonly IWriteUsService _writeusService;

        public ContactController(IContactService contactService, IWriteUsService writeUsService)
        {
            _contactService = contactService;
            _writeusService = writeUsService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = _contactService.TGetList().Where(x=>x.Status==true).ToList();
            return View();
        }


        [HttpPost]
        public IActionResult Index(WriteUsDTO p)
        {
            WriteUsValidator v = new WriteUsValidator();
            ValidationResult result = v.Validate(p);
            if (result.IsValid)
            {
                WriteUs w = new WriteUs() {
                    Name = p.Name,
                    Email = p.Email,
                    Subject = p.Subject,
                    Details = p.Details,
                   Date = DateTime.Now,
                   Status = false
                };
                _writeusService.TAdd(w);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            ViewBag.v1 = _contactService.TGetList().Where(x => x.Status == true).ToList();

            return View(p);
        }

    }
}
