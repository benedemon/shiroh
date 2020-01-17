namespace CustomerManager.Migrations
{
    using CustomerManager.Code.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CustomerManager.Code.DataAccess.GuestManagerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CustomerManager.Code.DataAccess.GuestManagerDbContext context)
        {
            context.Set<Guest>().AddOrUpdate(new Guest
            {
                ID = 1,
                FullName = "Raj Singh",
                PhoneNumber = "9958387299",
                EmailId = "rajsing@microsoft.com",
                RSVPDate = "29thFeb",
                TimeOfRSVP = new DateTime(2020, 1, 16)
            });
        }
    }
}
