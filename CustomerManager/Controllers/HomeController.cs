using CustomerManager.Code.Logic;
using CustomerManager.Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GuestsFor29()
        {
            GuestLogic guestLogic = new GuestLogic();

            List<Guest> guests = guestLogic.GetGuestsFor29();

            return View(guests);
        }

        public ActionResult Create()
        {
            Guest guest = new Guest();

            return View(guest);
        }

        [HttpPost]
        public ActionResult Create(Guest guest)
        {
            if (ModelState.IsValid)
            {
                GuestLogic logic = new GuestLogic();

                logic.AddGuestFor29(guest);

                return RedirectToAction("Index");
            }
            else
            {
                return View(guest);
            }
        }
    }
}