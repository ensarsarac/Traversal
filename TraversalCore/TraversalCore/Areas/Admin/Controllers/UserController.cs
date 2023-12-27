using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;
        private readonly ICommentService _commentService;

        public UserController(IAppUserService appUserService, IReservationService reservationService, ICommentService commentService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var users = _appUserService.TGetList();
            return View(users);
        }

        public IActionResult DeleteUser(int id)
        {
            var user = _appUserService.TGetById(id);
            _appUserService.TDelete(user);

            var commentUser = _commentService.TGetList().Where(x => x.AppUserId == id).ToList();
            foreach (var item in commentUser)
            {
                _commentService.TDelete(item);
            }

            var reservationUser = _reservationService.TGetList().Where(x => x.AppUserId == id).ToList();
            foreach (var item in reservationUser)
            {
                _reservationService.TDelete(item);
            }

            return RedirectToAction("Index");
        }


        public IActionResult ReservationUser(int id)
        {
            var values = _reservationService.GetListAllWithManager(id);
            return View(values);
        }


    }
}
