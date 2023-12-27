using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using DTOLayer.DestinatonDTOs;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IMapper _mapper;

        public DestinationController(IDestinationService destinationService, IMapper mapper)
        {
            _destinationService = destinationService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }
        public IActionResult Index2()
        {
            //var values = _destinationService.TGetList();
            var values = _mapper.Map<List<DestinationListViewModel>>(_destinationService.TGetList());
            return View(values);
        }
        [HttpGet]
        public IActionResult AddDestination2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination2(DestinationAddDTO p)
        {
            DestinationAddDTOValidator validations = new DestinationAddDTOValidator();
            ValidationResult result = validations.Validate(p);
            if (result.IsValid)
            {
                Destination d = new Destination() { 
                    
                    Capacity = p.Capacity,
                    City = p.City,
                    DayNight = p.DayNight,
                    Price = p.Price,
                };
                _destinationService.TAdd(d);
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(p);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(Destination p)
        {

            _destinationService.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteDestination(int id)
        {
            var des = _destinationService.TGetById(id);
            _destinationService.TDelete(des);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var des = _destinationService.TGetById(id);
            return View(des);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination p)
        {

            _destinationService.TUpdate(p);
            return RedirectToAction("Index");
        }


    }
}
