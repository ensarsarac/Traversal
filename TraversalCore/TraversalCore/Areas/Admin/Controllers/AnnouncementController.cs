using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using DTOLayer.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Areas.Admin.Models;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var announcements = _announcementService.TGetList();

            var model = _mapper.Map<List<AnnouncementListViewModel>>(announcements);

            return View(model);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAdd p)
        {
            AnnouncementValidator v = new AnnouncementValidator();
            ValidationResult result = v.Validate(p);
            if (result.IsValid)
            {
                _announcementService.TAdd(new Announcement
                {
                    Title = p.Title,
                    Content = p.Content,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }

            return View();
        }


        public IActionResult DeleteAnnouncement(int id)
        {
            var value = _announcementService.TGetById(id);
            _announcementService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var value = _mapper.Map<AnnouncementUpdateDto>(_announcementService.TGetById(id));
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDto p)
        {
            AnnouncementUpdateValidator rules = new AnnouncementUpdateValidator();
            ValidationResult result = rules.Validate(p);
            if (ModelState.IsValid)
            {
                var value = _announcementService.TGetById(p.AnnouncementId);
                value.Title = p.Title;
                value.Content = p.Content;
                value.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                _announcementService.TUpdate(value);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    
                }
                return View(p);
            }
            
        }

    }
}
