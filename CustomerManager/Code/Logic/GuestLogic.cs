using CustomerManager.Code.DataAccess;
using CustomerManager.Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManager.Code.Logic
{
    public class GuestLogic
    {
        private GuestRepository _guestRepo = null;

        public GuestLogic()
        {
            _guestRepo = new GuestRepository();
        }

        public List<Guest> GetGuestsFor29()
        {
            List<Guest> guests = _guestRepo.GetGuests("29thFeb").ToList();
            guests.ForEach(c => c.TimeOfRSVP = c.TimeOfRSVP.ToLocalTime());
            return guests;
        }

        public List<Guest> GetGuestsFor26()
        {
            var guests = _guestRepo.GetGuests("26thFeb").ToList();
            guests.ForEach(c => c.TimeOfRSVP = c.TimeOfRSVP.ToLocalTime());
            return guests;
        }

        public void AddGuestFor29(Guest guest)
        {
            _guestRepo.AddGuest(guest, "29thFeb");
        }

        public void AddGuestFor26(Guest guest)
        {
            _guestRepo.AddGuest(guest, "26thFeb");
        }
    }
}