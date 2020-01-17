using CustomerManager.Code.Models;
using System;
using System.Linq;

namespace CustomerManager.Code.DataAccess
{
    public class GuestRepository
    {
        private GuestManagerDbContext _context = null;

        public GuestRepository()
        {
            _context = new GuestManagerDbContext();
        }

        public GuestRepository(GuestManagerDbContext context)
        {
            _context = context;
        }

        public IQueryable<Guest> GetGuests()
        {
            return _context.Guests;
        }

        public IQueryable<Guest> GetGuests(string rsvpDate)
        {
            return _context.Guests
                .Where(c => c.RSVPDate == rsvpDate).OrderByDescending(c => c.TimeOfRSVP);
        }

        public Guest GetGuest(int guestId)
        {
            return GetGuests().Single(c => c.ID == guestId);
        }

        public void AddGuest(Guest guest, string RSVPDate)
        {
            guest.RSVPDate = RSVPDate;
            guest.TimeOfRSVP = DateTime.UtcNow;
            _context.Guests.Add(guest);
            _context.SaveChanges();
        }

        public void DeleteGuest(Guest guest)
        {
            _context.Guests.Remove(guest);

            _context.SaveChanges();
        }
    }
}