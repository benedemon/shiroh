using CustomerManager.Code.Logic;
using CustomerManager.Code.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Trace.WriteLine("GET /HOME");
            return View();
        }

        public ActionResult GuestsFor29()
        {
            Trace.WriteLine("GET /GuestsFor29");
            GuestLogic guestLogic = new GuestLogic();

            List<Guest> guests = guestLogic.GetGuestsFor29();

            return View(guests);
        }

        public ActionResult Create()
        {
            Trace.WriteLine("CREATE /GUEST");
            Guest guest = new Guest();

            return View(guest);
        }

        [HttpPost]
        public ActionResult Create(Guest guest)
        {
            Trace.WriteLine("POST /GUEST");
            if (ModelState.IsValid)
            {
                Trace.WriteLine("ModelState valid");
                GuestLogic logic = new GuestLogic();

                logic.AddGuestFor29(guest);

                Trace.WriteLine("RedirectingToIndex");
                return RedirectToAction("Index");
            }
            else
            {
                return View(guest);
            }
        }
    }
}