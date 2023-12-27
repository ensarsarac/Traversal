using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Models;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuidesController : Controller
    {
        private readonly IGuideService _guideService;

        public GuidesController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var guides = _guideService.TGetList();
            return View(guides);
        }

        public IActionResult DoNotActive(int id)
        {
            var guide = _guideService.TGetById(id);
            guide.Status = false;
            _guideService.TUpdate(guide);
            return RedirectToAction("Index");
        }

        public IActionResult DoActive(int id)
        {
            var guide = _guideService.TGetById(id);
            guide.Status = true;
            _guideService.TUpdate(guide);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            GuideAddViewModel model = new GuideAddViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddGuide(GuideAddViewModel model)
        {
            Guide g = new Guide();
            if (ModelState.IsValid)
            {
                if (model.Image != null)
                {
                    var resource = Directory.GetCurrentDirectory();
                    var extension = Path.GetExtension(model.Image.FileName);
                    var imagename = Guid.NewGuid() + extension;
                    var savelocation = resource + "/wwwroot/GuideImage/" + imagename;
                    var stream = new FileStream(savelocation, FileMode.Create);

                    await model.Image.CopyToAsync(stream);
                    g.Image = imagename;

                }
                g.Name = model.NameSurname;
                g.InstagramUrl = model.InstagramUrl;
                g.TwitterUrl = model.TwitterUrl;
                g.Description = model.Description;
                g.Status = false;

                _guideService.TAdd(g);

                return RedirectToAction("Index");
            }
            return View(model);
            
        }


        public IActionResult DeleteGuides(int id)
        {
            var guide = _guideService.TGetById(id);
            _guideService.TDelete(guide);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateGuides(int id)
        {
            GuideAddViewModel model = new GuideAddViewModel();
            var guide = _guideService.TGetById(id);
            model.Id = guide.GuideId;
            model.Description = guide.Description;
            model.NameSurname = guide.Name;
            model.TwitterUrl = guide.TwitterUrl;
            model.InstagramUrl = guide.InstagramUrl;
            
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> UpdateGuides(GuideAddViewModel g)
        {
            var guide = _guideService.TGetById(g.Id);

            if (g.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(g.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/GuideImage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);

                await g.Image.CopyToAsync(stream);
                guide.Image = imagename;

            }
            guide.Name = g.NameSurname;
            guide.InstagramUrl = g.InstagramUrl;
            guide.TwitterUrl = g.TwitterUrl;
            guide.Description = g.Description;
            guide.Status = false;

            _guideService.TUpdate(guide);


            return RedirectToAction("Index");
        }
    }
}