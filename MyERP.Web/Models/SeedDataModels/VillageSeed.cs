using Microsoft.EntityFrameworkCore;
using MyERP.Web.Models.Common;

namespace MyERP.Web.Models.SeedDataModels
{
    public class VillageSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // تمثل DateTime.Now وقت إنشاء الميجريشن
            var createdAt = new DateTime(2025, 12, 25, 12, 00, 00);

            modelBuilder.Entity<Village>().HasData(
                new Village { Id = 1,  Name = "سخا", CreatedAt = createdAt },
                new Village { Id = 2,  Name = "ميت علوان", CreatedAt = createdAt }


                );

        }
    }
}
