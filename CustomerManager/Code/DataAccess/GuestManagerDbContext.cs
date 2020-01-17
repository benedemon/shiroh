using CustomerManager.Code.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomerManager.Code.DataAccess
{
    public class GuestManagerDbContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; }
    }
}