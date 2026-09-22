using Microsoft.EntityFrameworkCore;
using MyERP.Web.Models.Common;

namespace MyERP.Web.Models.SeedDataModels
{
    public class LocalUnitsSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // تمثل DateTime.Now وقت إنشاء الميجريشن
            var createdAt = new DateTime(2025, 12, 25, 12, 00, 00);

            modelBuilder.Entity<LocalUnit>().HasData(
                new LocalUnit { Id = 1, CityCenterId = 1, Name = "الحمراء", CreatedAt = createdAt },
                new LocalUnit { Id = 2, CityCenterId = 1, Name = "محلة القصب", CreatedAt = createdAt }
                
                );

        }
    }
}
